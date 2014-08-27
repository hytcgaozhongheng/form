using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace feige
{
    public partial class UCFriend : UserControl
    {
        private FrmMain fg;
        public FrmMain Fg
        {
            get { return fg; }
            set { fg = value; }

        }
        private Friend curFriend;
        public Friend CurFriend
        {
            get { return CurFriend; }
            set
            {
                curFriend = value;
                this.lblNickName.Text = value.NickName;
                this.lblShuoshuo.Text = value.Shuoshuo;
                this.headerimage.Image = this.fg.liHeadImages.Images[value.HeadImageINdex];
            }
        }
        
        public UCFriend()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {




        }

        private void UCFriend_Load(object sender, EventArgs e)
        {

        }
    }
}
