namespace DisWebSocketServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clbOnlineClient = new System.Windows.Forms.CheckedListBox();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_msg = new System.Windows.Forms.CheckBox();
            this.button_StopListen = new System.Windows.Forms.Button();
            this.button_StartListen = new System.Windows.Forms.Button();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_event = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_clientCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_Port = new System.Windows.Forms.ToolStripLabel();
            this.tsl_msg = new System.Windows.Forms.ToolStripLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new DisWebSocketServer.ListViewNF();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clbOnlineClient);
            this.groupBox2.Controls.Add(this.textBox_msg);
            this.groupBox2.Controls.Add(this.button_Send);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 176);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送消息给客户端";
            // 
            // clbOnlineClient
            // 
            this.clbOnlineClient.FormattingEnabled = true;
            this.clbOnlineClient.Location = new System.Drawing.Point(100, 66);
            this.clbOnlineClient.Name = "clbOnlineClient";
            this.clbOnlineClient.Size = new System.Drawing.Size(420, 100);
            this.clbOnlineClient.TabIndex = 7;
            // 
            // textBox_msg
            // 
            this.textBox_msg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_msg.Location = new System.Drawing.Point(100, 32);
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.Size = new System.Drawing.Size(565, 21);
            this.textBox_msg.TabIndex = 5;
            this.textBox_msg.Text = "this is a StriveEngine demo";
            // 
            // button_Send
            // 
            this.button_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Send.Enabled = false;
            this.button_Send.Location = new System.Drawing.Point(584, 66);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 4;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "发送的文本：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "在线客户端：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_msg);
            this.groupBox1.Controls.Add(this.button_StopListen);
            this.groupBox1.Controls.Add(this.button_StartListen);
            this.groupBox1.Controls.Add(this.textBox_port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chb_msg
            // 
            this.chb_msg.AutoSize = true;
            this.chb_msg.Checked = true;
            this.chb_msg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_msg.Location = new System.Drawing.Point(459, 36);
            this.chb_msg.Name = "chb_msg";
            this.chb_msg.Size = new System.Drawing.Size(84, 16);
            this.chb_msg.TabIndex = 14;
            this.chb_msg.Text = "收到的消息";
            this.chb_msg.UseVisualStyleBackColor = true;
            this.chb_msg.CheckedChanged += new System.EventHandler(this.chb_msg_CheckedChanged);
            // 
            // button_StopListen
            // 
            this.button_StopListen.Enabled = false;
            this.button_StopListen.Location = new System.Drawing.Point(332, 29);
            this.button_StopListen.Name = "button_StopListen";
            this.button_StopListen.Size = new System.Drawing.Size(75, 23);
            this.button_StopListen.TabIndex = 13;
            this.button_StopListen.Text = "停止监听";
            this.button_StopListen.UseVisualStyleBackColor = true;
            this.button_StopListen.Click += new System.EventHandler(this.button_StopListen_Click);
            // 
            // button_StartListen
            // 
            this.button_StartListen.Location = new System.Drawing.Point(225, 29);
            this.button_StartListen.Name = "button_StartListen";
            this.button_StartListen.Size = new System.Drawing.Size(75, 23);
            this.button_StartListen.TabIndex = 12;
            this.button_StartListen.Text = "启动";
            this.button_StartListen.UseVisualStyleBackColor = true;
            this.button_StartListen.Click += new System.EventHandler(this.button_StartListen_Click);
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(100, 32);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(100, 21);
            this.textBox_port.TabIndex = 11;
            this.textBox_port.Text = "9000";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "监听端口：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_event,
            this.toolStripLabel_clientCount,
            this.toolStripLabel1,
            this.toolStripLabel_Port,
            this.tsl_msg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 506);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(671, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel_event
            // 
            this.toolStripLabel_event.Name = "toolStripLabel_event";
            this.toolStripLabel_event.Size = new System.Drawing.Size(18, 22);
            this.toolStripLabel_event.Text = "--";
            // 
            // toolStripLabel_clientCount
            // 
            this.toolStripLabel_clientCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_clientCount.Name = "toolStripLabel_clientCount";
            this.toolStripLabel_clientCount.Size = new System.Drawing.Size(75, 22);
            this.toolStripLabel_clientCount.Text = "在线数量：0";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "监听端口：";
            // 
            // toolStripLabel_Port
            // 
            this.toolStripLabel_Port.Name = "toolStripLabel_Port";
            this.toolStripLabel_Port.Size = new System.Drawing.Size(0, 22);
            // 
            // tsl_msg
            // 
            this.tsl_msg.Name = "tsl_msg";
            this.tsl_msg.Size = new System.Drawing.Size(80, 22);
            this.tsl_msg.Text = "显示收到消息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 255);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "收到的消息";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 17);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(665, 235);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "时间";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "客户端";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "消息内容";
            this.columnHeader3.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 531);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebSocket服务端（V1.0.0）";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox clbOnlineClient;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_StopListen;
        private System.Windows.Forms.Button button_StartListen;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_event;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_clientCount;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Port;
        private System.Windows.Forms.GroupBox groupBox3;
        private ListViewNF listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.CheckBox chb_msg;
        private System.Windows.Forms.ToolStripLabel tsl_msg;
    }
}

