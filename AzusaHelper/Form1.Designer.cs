namespace AzusaHelper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setResponseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.triggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.lSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.responseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(679, 315);
            this.listBox1.TabIndex = 3;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setTriggerToolStripMenuItem,
            this.setResponseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 48);
            // 
            // setTriggerToolStripMenuItem
            // 
            this.setTriggerToolStripMenuItem.Name = "setTriggerToolStripMenuItem";
            this.setTriggerToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.setTriggerToolStripMenuItem.Text = "Set Trigger";
            this.setTriggerToolStripMenuItem.Click += new System.EventHandler(this.setTriggerToolStripMenuItem_Click);
            // 
            // setResponseToolStripMenuItem
            // 
            this.setResponseToolStripMenuItem.Name = "setResponseToolStripMenuItem";
            this.setResponseToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.setResponseToolStripMenuItem.Text = "Set Response";
            this.setResponseToolStripMenuItem.Click += new System.EventHandler(this.setResponseToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.testToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentToolStripMenuItem,
            this.toolStripMenuItem1,
            this.triggerToolStripMenuItem,
            this.responseToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.lSToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.currentToolStripMenuItem.Text = "Current";
            this.currentToolStripMenuItem.Click += new System.EventHandler(this.currentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // triggerToolStripMenuItem
            // 
            this.triggerToolStripMenuItem.Name = "triggerToolStripMenuItem";
            this.triggerToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.triggerToolStripMenuItem.Text = "&Trigger";
            this.triggerToolStripMenuItem.Click += new System.EventHandler(this.triggerToolStripMenuItem_Click);
            // 
            // responseToolStripMenuItem1
            // 
            this.responseToolStripMenuItem1.Name = "responseToolStripMenuItem1";
            this.responseToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.responseToolStripMenuItem1.Text = "&Response";
            this.responseToolStripMenuItem1.Click += new System.EventHandler(this.responseToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            // 
            // lSToolStripMenuItem
            // 
            this.lSToolStripMenuItem.Name = "lSToolStripMenuItem";
            this.lSToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.lSToolStripMenuItem.Text = "&LS";
            this.lSToolStripMenuItem.Click += new System.EventHandler(this.lSToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.responseToolStripMenuItem,
            this.triggerToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.cancelToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "&Test";
            // 
            // currentToolStripMenuItem1
            // 
            this.currentToolStripMenuItem1.Name = "currentToolStripMenuItem1";
            this.currentToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.currentToolStripMenuItem1.Text = "&Current";
            this.currentToolStripMenuItem1.Click += new System.EventHandler(this.currentToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(121, 6);
            // 
            // responseToolStripMenuItem
            // 
            this.responseToolStripMenuItem.Name = "responseToolStripMenuItem";
            this.responseToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.responseToolStripMenuItem.Text = "&Response";
            this.responseToolStripMenuItem.Click += new System.EventHandler(this.responseToolStripMenuItem_Click);
            // 
            // triggerToolStripMenuItem1
            // 
            this.triggerToolStripMenuItem1.Name = "triggerToolStripMenuItem1";
            this.triggerToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.triggerToolStripMenuItem1.Text = "Trigger";
            this.triggerToolStripMenuItem1.Click += new System.EventHandler(this.triggerToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 6);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cancelToolStripMenuItem.Text = "Canc&el";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 317);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(679, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statLabel
            // 
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(39, 17);
            this.statLabel.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 339);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AZUSA Helper";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lSToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setTriggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setResponseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem triggerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statLabel;
    }
}

