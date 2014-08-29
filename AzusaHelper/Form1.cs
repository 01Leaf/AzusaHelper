using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AzusaHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Shared.msg.Count != 0)
            {
                string tmp = Shared.msg.Dequeue();
                if (Shared.trig_testing && tmp == Shared.trigger) { MessageBox.Show("Triggered!"); Shared.trig_testing = false; }
                if (Shared.testing && tmp == Shared.trigger) { Console.WriteLine(Shared.response); Shared.testing = false; }
                listBox1.Items.Insert(0,tmp);

            }
            if (Shared.testing || Shared.trig_testing)
            {
                statLabel.ForeColor = Color.Red;
                statLabel.Text = "[TESTING] " + Shared.trigger + ", " + Shared.response;
            }
            else
            {
                statLabel.ForeColor = Color.Black;
                statLabel.Text = Shared.trigger + ", " + Shared.response;
            }
        }

        private void lSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory+"\\ls.txt");
        }

        private void setTriggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Shared.trigger = listBox1.Text;
        }

        private void setResponseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shared.response = listBox1.Text;
        }

        private void responseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Shared.response);
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string current = Shared.trigger + ", " + Shared.response;
            if (InputBox("Current Behavior", "", ref current) == DialogResult.OK)
            {
                Shared.trigger = current.Split(',')[0];
                Shared.response = current.Replace(Shared.trigger + ", ", "");
            }
        }


        private void triggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string resp = Shared.trigger;
            if (InputBox("Current Trigger", "", ref resp) == DialogResult.OK)
            {

                Shared.response = resp;
            }
        }

      


        private void responseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string resp = Shared.response;
            if (InputBox("Current Response", "", ref resp) == DialogResult.OK)
            {

                Shared.response = resp;
            }
        }

        private void triggerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Shared.trig_testing = true;
        }

        private void currentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Shared.testing = true;
        }


        #region InputBox
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        #endregion

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Shared.trigger + ", " + Shared.response);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shared.trig_testing = false;
            Shared.testing = false;
        }


        

      

      

      

      
    }




}
