namespace feige
{
    partial class UCFriend
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFriend));
            this.headerimage = new System.Windows.Forms.PictureBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.lblShuoshuo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headerimage)).BeginInit();
            this.SuspendLayout();
            // 
            // headerimage
            // 
            this.headerimage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerimage.BackgroundImage")));
            this.headerimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.headerimage.Image = ((System.Drawing.Image)(resources.GetObject("headerimage.Image")));
            this.headerimage.Location = new System.Drawing.Point(14, 14);
            this.headerimage.Name = "headerimage";
            this.headerimage.Size = new System.Drawing.Size(60, 60);
            this.headerimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerimage.TabIndex = 0;
            this.headerimage.TabStop = false;
            this.headerimage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(138, 14);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(41, 12);
            this.lblNickName.TabIndex = 1;
            this.lblNickName.Text = "label1";
            // 
            // lblShuoshuo
            // 
            this.lblShuoshuo.AutoSize = true;
            this.lblShuoshuo.Location = new System.Drawing.Point(138, 42);
            this.lblShuoshuo.Name = "lblShuoshuo";
            this.lblShuoshuo.Size = new System.Drawing.Size(41, 12);
            this.lblShuoshuo.TabIndex = 2;
            this.lblShuoshuo.Text = "label2";
            // 
            // UCFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblShuoshuo);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.headerimage);
            this.Name = "UCFriend";
            this.Size = new System.Drawing.Size(256, 76);
            this.Load += new System.EventHandler(this.UCFriend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headerimage;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.Label lblShuoshuo;
    }
}
