namespace WindowsFormsApplication1
{
    partial class chat
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.chatsend = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.chatroom = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chatbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chatsend
            // 
            this.chatsend.Location = new System.Drawing.Point(691, 428);
            this.chatsend.Name = "chatsend";
            this.chatsend.Size = new System.Drawing.Size(75, 23);
            this.chatsend.TabIndex = 0;
            this.chatsend.Text = "发送";
            this.chatsend.UseVisualStyleBackColor = true;
            this.chatsend.Click += new System.EventHandler(this.chatsend_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 11);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(601, 21);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "胖大海";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(64, 54);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(601, 21);
            this.id.TabIndex = 1;
            this.id.Text = "255.255.255.255";
            // 
            // chatroom
            // 
            this.chatroom.Location = new System.Drawing.Point(64, 91);
            this.chatroom.Multiline = true;
            this.chatroom.Name = "chatroom";
            this.chatroom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatroom.Size = new System.Drawing.Size(601, 315);
            this.chatroom.TabIndex = 1;
   
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(691, 11);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 395);
            this.textBox5.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(29, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 3;
            this.name.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ip";
            // 
            // chatbox
            // 
            this.chatbox.Location = new System.Drawing.Point(64, 430);
            this.chatbox.Name = "chatbox";
            this.chatbox.Size = new System.Drawing.Size(601, 21);
            this.chatbox.TabIndex = 1;
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.chatbox);
            this.Controls.Add(this.chatroom);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.chatsend);
            this.Name = "chat";
            this.Text = "飞ge";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chatsend;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox chatroom;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chatbox;

    }
}

