namespace ChatClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLocalP = new System.Windows.Forms.Label();
            this.textLocal = new System.Windows.Forms.Label();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textFriendsP = new System.Windows.Forms.Label();
            this.textFriends = new System.Windows.Forms.Label();
            this.textFriendsPort = new System.Windows.Forms.TextBox();
            this.textFriendsIp = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLocalP);
            this.groupBox1.Controls.Add(this.textLocal);
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.Location = new System.Drawing.Point(61, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client1";
            // 
            // textLocalP
            // 
            this.textLocalP.AutoSize = true;
            this.textLocalP.Location = new System.Drawing.Point(172, 78);
            this.textLocalP.Name = "textLocalP";
            this.textLocalP.Size = new System.Drawing.Size(47, 17);
            this.textLocalP.TabIndex = 3;
            this.textLocalP.Text = "PORT";
            // 
            // textLocal
            // 
            this.textLocal.AutoSize = true;
            this.textLocal.Location = new System.Drawing.Point(172, 26);
            this.textLocal.Name = "textLocal";
            this.textLocal.Size = new System.Drawing.Size(20, 17);
            this.textLocal.TabIndex = 2;
            this.textLocal.Text = "IP";
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(322, 78);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(214, 22);
            this.textLocalPort.TabIndex = 1;
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(322, 23);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(214, 22);
            this.textLocalIp.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textFriendsP);
            this.groupBox2.Controls.Add(this.textFriends);
            this.groupBox2.Controls.Add(this.textFriendsPort);
            this.groupBox2.Controls.Add(this.textFriendsIp);
            this.groupBox2.Location = new System.Drawing.Point(667, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client2";
            // 
            // textFriendsP
            // 
            this.textFriendsP.AutoSize = true;
            this.textFriendsP.Location = new System.Drawing.Point(218, 76);
            this.textFriendsP.Name = "textFriendsP";
            this.textFriendsP.Size = new System.Drawing.Size(47, 17);
            this.textFriendsP.TabIndex = 3;
            this.textFriendsP.Text = "PORT";
            // 
            // textFriends
            // 
            this.textFriends.AutoSize = true;
            this.textFriends.Location = new System.Drawing.Point(218, 28);
            this.textFriends.Name = "textFriends";
            this.textFriends.Size = new System.Drawing.Size(20, 17);
            this.textFriends.TabIndex = 2;
            this.textFriends.Text = "IP";
            // 
            // textFriendsPort
            // 
            this.textFriendsPort.Location = new System.Drawing.Point(341, 76);
            this.textFriendsPort.Name = "textFriendsPort";
            this.textFriendsPort.Size = new System.Drawing.Size(201, 22);
            this.textFriendsPort.TabIndex = 1;
            // 
            // textFriendsIp
            // 
            this.textFriendsIp.Location = new System.Drawing.Point(341, 26);
            this.textFriendsIp.Name = "textFriendsIp";
            this.textFriendsIp.Size = new System.Drawing.Size(201, 22);
            this.textFriendsIp.TabIndex = 0;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(61, 581);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(1084, 22);
            this.textMessage.TabIndex = 2;
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 16;
            this.listMessage.Location = new System.Drawing.Point(61, 253);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(1228, 276);
            this.listMessage.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1278, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1204, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 633);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label textLocalP;
        private System.Windows.Forms.Label textLocal;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label textFriendsP;
        private System.Windows.Forms.Label textFriends;
        private System.Windows.Forms.TextBox textFriendsPort;
        private System.Windows.Forms.TextBox textFriendsIp;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

