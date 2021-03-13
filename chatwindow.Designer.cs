namespace baborant
{
    partial class chatwindow
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
            this.groupServerList = new System.Windows.Forms.GroupBox();
            this.textServerIP1 = new System.Windows.Forms.TextBox();
            this.textServerPort1 = new System.Windows.Forms.TextBox();
            this.ServerIP1 = new System.Windows.Forms.Label();
            this.ServerPort1 = new System.Windows.Forms.Label();
            this.textSendText = new System.Windows.Forms.TextBox();
            this.buttonSendButton = new System.Windows.Forms.Button();
            this.listChatLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLocalIP = new System.Windows.Forms.TextBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.LocalIP = new System.Windows.Forms.Label();
            this.LocalPort = new System.Windows.Forms.Label();
            this.buttonServerConnect = new System.Windows.Forms.Button();
            this.groupServerList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupServerList
            // 
            this.groupServerList.Controls.Add(this.textServerIP1);
            this.groupServerList.Controls.Add(this.textServerPort1);
            this.groupServerList.Controls.Add(this.ServerIP1);
            this.groupServerList.Controls.Add(this.ServerPort1);
            this.groupServerList.Location = new System.Drawing.Point(2, 3);
            this.groupServerList.Name = "groupServerList";
            this.groupServerList.Size = new System.Drawing.Size(95, 110);
            this.groupServerList.TabIndex = 0;
            this.groupServerList.TabStop = false;
            this.groupServerList.Text = "server";
            // 
            // textServerIP1
            // 
            this.textServerIP1.Location = new System.Drawing.Point(0, 83);
            this.textServerIP1.Name = "textServerIP1";
            this.textServerIP1.Size = new System.Drawing.Size(89, 20);
            this.textServerIP1.TabIndex = 3;
            // 
            // textServerPort1
            // 
            this.textServerPort1.Location = new System.Drawing.Point(0, 36);
            this.textServerPort1.Name = "textServerPort1";
            this.textServerPort1.Size = new System.Drawing.Size(89, 20);
            this.textServerPort1.TabIndex = 2;
            // 
            // ServerIP1
            // 
            this.ServerIP1.AutoSize = true;
            this.ServerIP1.Location = new System.Drawing.Point(6, 66);
            this.ServerIP1.Name = "ServerIP1";
            this.ServerIP1.Size = new System.Drawing.Size(54, 13);
            this.ServerIP1.TabIndex = 1;
            this.ServerIP1.Text = "ServerIP1";
            // 
            // ServerPort1
            // 
            this.ServerPort1.AutoSize = true;
            this.ServerPort1.Location = new System.Drawing.Point(6, 20);
            this.ServerPort1.Name = "ServerPort1";
            this.ServerPort1.Size = new System.Drawing.Size(63, 13);
            this.ServerPort1.TabIndex = 0;
            this.ServerPort1.Text = "ServerPort1";
            // 
            // textSendText
            // 
            this.textSendText.Location = new System.Drawing.Point(2, 260);
            this.textSendText.Name = "textSendText";
            this.textSendText.Size = new System.Drawing.Size(323, 20);
            this.textSendText.TabIndex = 1;
            // 
            // buttonSendButton
            // 
            this.buttonSendButton.Location = new System.Drawing.Point(329, 260);
            this.buttonSendButton.Name = "buttonSendButton";
            this.buttonSendButton.Size = new System.Drawing.Size(31, 20);
            this.buttonSendButton.TabIndex = 2;
            this.buttonSendButton.Text = " gay";
            this.buttonSendButton.UseVisualStyleBackColor = true;
            this.buttonSendButton.Click += new System.EventHandler(this.buttonSendButton_Click);
            // 
            // listChatLog
            // 
            this.listChatLog.FormattingEnabled = true;
            this.listChatLog.Location = new System.Drawing.Point(103, 3);
            this.listChatLog.Name = "listChatLog";
            this.listChatLog.Size = new System.Drawing.Size(269, 251);
            this.listChatLog.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLocalIP);
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.LocalIP);
            this.groupBox1.Controls.Add(this.LocalPort);
            this.groupBox1.Location = new System.Drawing.Point(2, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            // 
            // textLocalIP
            // 
            this.textLocalIP.Location = new System.Drawing.Point(0, 71);
            this.textLocalIP.Name = "textLocalIP";
            this.textLocalIP.Size = new System.Drawing.Size(89, 20);
            this.textLocalIP.TabIndex = 3;
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(0, 32);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(89, 20);
            this.textLocalPort.TabIndex = 2;
            // 
            // LocalIP
            // 
            this.LocalIP.AutoSize = true;
            this.LocalIP.Location = new System.Drawing.Point(3, 55);
            this.LocalIP.Name = "LocalIP";
            this.LocalIP.Size = new System.Drawing.Size(43, 13);
            this.LocalIP.TabIndex = 1;
            this.LocalIP.Text = "LocalIP";
            // 
            // LocalPort
            // 
            this.LocalPort.AutoSize = true;
            this.LocalPort.Location = new System.Drawing.Point(-3, 16);
            this.LocalPort.Name = "LocalPort";
            this.LocalPort.Size = new System.Drawing.Size(52, 13);
            this.LocalPort.TabIndex = 0;
            this.LocalPort.Text = "LocalPort";
            // 
            // buttonServerConnect
            // 
            this.buttonServerConnect.Location = new System.Drawing.Point(2, 112);
            this.buttonServerConnect.Name = "buttonServerConnect";
            this.buttonServerConnect.Size = new System.Drawing.Size(95, 40);
            this.buttonServerConnect.TabIndex = 5;
            this.buttonServerConnect.Text = "Connect";
            this.buttonServerConnect.UseVisualStyleBackColor = true;
            this.buttonServerConnect.Click += new System.EventHandler(this.buttonServerConnect_Click);
            // 
            // chatwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 287);
            this.Controls.Add(this.buttonServerConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listChatLog);
            this.Controls.Add(this.buttonSendButton);
            this.Controls.Add(this.textSendText);
            this.Controls.Add(this.groupServerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "chatwindow";
            this.Text = "I\'m going to kill president biden";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupServerList.ResumeLayout(false);
            this.groupServerList.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupServerList;
        private System.Windows.Forms.TextBox textSendText;
        private System.Windows.Forms.Button buttonSendButton;
        private System.Windows.Forms.ListBox listChatLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textServerIP1;
        private System.Windows.Forms.TextBox textServerPort1;
        private System.Windows.Forms.Label ServerIP1;
        private System.Windows.Forms.Label ServerPort1;
        private System.Windows.Forms.TextBox textLocalIP;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.Label LocalIP;
        private System.Windows.Forms.Label LocalPort;
        private System.Windows.Forms.Button buttonServerConnect;
    }
}

