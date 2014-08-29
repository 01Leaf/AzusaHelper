using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Text;
using ZMQ;

namespace AzusaHelper
{
    static class Program
    {
        //初始化引擎
        static bool Initialize()
        {

            //請加入自己的代碼

            return true;


        }

        //對消息進行處理
        static void Process(List<string> messages, bool console)
        {

            //請改成自己的代碼

            foreach (string msg in messages)
            {
                if (console)
                {
                    Shared.msg.Enqueue("@" + msg);
                }
                else
                {
                    Shared.msg.Enqueue(msg);
                }
                if (msg.Contains("PRC"))
                {
                    Console.WriteLine("PRCPath?");
                    Shared.msg.Enqueue("EXEC(" +Console.ReadLine()+")");
                }

            }
        }

        static Thread AZUSAlistener;
        static Thread ZMQlistener;
        static int AZUSAPid;
        static bool AZUSAAlive = true;

        static string[] InputPorts = new string[] { };
        static bool PortChanged = false;
        static List<Socket> connections = new List<Socket>();
        static List<string> messages = new List<string>();


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AZUSAlistener = new Thread(new ThreadStart(ListenToConsole));
            AZUSAlistener.Start();

            ZMQlistener = new Thread(new ThreadStart(ListenToZMQ));
            ZMQlistener.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());          
            
        }

        static void ListenToZMQ()
        {
            using (Context ctx = new Context())
            {
                while (AZUSAAlive)
                {
                    connections.Clear();

                    foreach (string port in InputPorts)
                    {
                        if (port.Trim() != "")
                        {
                            Socket client = ctx.Socket(SocketType.SUB);
                            client.Connect(port);
                            client.Subscribe("", Encoding.UTF8);

                            connections.Add(client);
                        }
                    }

                    PortChanged = false;

                    while (!PortChanged && AZUSAAlive)
                    {
                        foreach (Socket socket in connections)
                        {
                            messages.Add(socket.Recv(Encoding.UTF8));
                        }

                        Process(messages, false);

                        messages.Clear();
                    }
                }

            }
        }

        static void ListenToConsole()
        {

            Console.WriteLine("RegisterAs(AI)");
            Console.WriteLine("GetInputPorts()");
            InputPorts = Console.ReadLine().Split(',');
            PortChanged = true;

            Console.WriteLine("GetAzusaPid()");
            AZUSAPid = Convert.ToInt32(Console.ReadLine());

            List<string> msg=new List<string>();
            //Listen for PortHasChanged

            while (AZUSAAlive)
            {
                try
                {
                    System.Diagnostics.Process.GetProcessById(AZUSAPid);
                    msg.Add(Console.ReadLine().Trim());
                    
                    if (msg[0] == "PortHasChanged")
                    {
                        Console.WriteLine("GetInputPorts()");
                        InputPorts = Console.ReadLine().Split(',');
                        PortChanged = true;
                        msg.Clear();
                    }
                    else
                    {
                        Process(msg,true);
                        msg.Clear();
                    }
                }
                catch
                {
                    AZUSAAlive = false;
                    Environment.Exit(0);
                    break;
                }
            }
        }
    }
}
