using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Text;

using System.Runtime.InteropServices;

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
        static void Process(List<string> messages)
        {

            string msg;
            foreach (string message in messages)
            {
                msg = System.Web.HttpUtility.UrlDecode(message);
                
                    if (msg.StartsWith("EVENT("))
                    {
                        Shared.msg.Enqueue("@" + msg.Replace("EVENT(", "").TrimEnd(')'));
                    }
                    else
                    {
                        Shared.msg.Enqueue(msg);
                    }
                
                
                if (msg.Contains("PRC"))
                {
                    Console.WriteLine("PRCPath?");
                    Shared.msg.Enqueue("EXEC(\"" + Console.ReadLine() + "\")");
                }

            }
        }

        static Thread AZUSAlistener;
        static int AZUSAPid=-1;
        static bool AZUSAAlive = true;

        static List<string> messages = new List<string>();




        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            AZUSAlistener = new Thread(new ThreadStart(ListenToConsole));
            AZUSAlistener.Start();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }



        static void ListenToConsole()
        {

            Console.WriteLine("RegisterAs(Application)");
            Console.WriteLine("LinkRID(INPUT,true)");
            Console.WriteLine("LinkRID(EVENT,false)");
            Console.WriteLine("GetAzusaPid()");

            for (int i = 0; i < 5; i++)                
            {
                try
                {
                    AZUSAPid = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch { }
            }



            List<string> msg = new List<string>();
            //Listen for PortHasChanged

            while (AZUSAAlive)
            {
                try
                {
                    System.Diagnostics.Process.GetProcessById(AZUSAPid);
                    msg.Add(Console.ReadLine().Trim());
                    Process(msg);
                    msg.Clear();
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