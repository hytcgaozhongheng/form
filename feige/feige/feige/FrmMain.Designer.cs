namespace feige
{
    partial class FrmMain
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
            this.HeadPicture = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FriendList = new System.Windows.Forms.Panel();
            this.NiceName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HeadPicture
            // 
            this.HeadPicture.Location = new System.Drawing.Point(12, 12);
            this.HeadPicture.Multiline = true;
            this.HeadPicture.Name = "HeadPicture";
            this.HeadPicture.Size = new System.Drawing.Size(70, 70);
            this.HeadPicture.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // FriendList
            // 
            this.FriendList.Location = new System.Drawing.Point(12, 106);
            this.FriendList.Name = "FriendList";
            this.FriendList.Size = new System.Drawing.Size(260, 398);
            this.FriendList.TabIndex = 3;
            // 
            // NiceName
            // 
            this.NiceName.Location = new System.Drawing.Point(172, 12);
            this.NiceName.Name = "NiceName";
            this.NiceName.Size = new System.Drawing.Size(100, 21);
            this.NiceName.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 516);
            this.Controls.Add(this.NiceName);
            this.Controls.Add(this.FriendList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeadPicture);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HeadPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel FriendList;
        private System.Windows.Forms.TextBox NiceName;
    }
}

