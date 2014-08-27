using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace feige
{
    public partial class FrmMain : Form
    {
        public delegate void delAddFriend(Friend friend);
        public FrmMain()
        {
            InitializeComponent();
        }

        private void listen()
        {
            UdpClient uc = new UdpClient(9527);
            while (true)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 0);

                byte[] bmsg = uc.Receive(ref ipep);
                string msg = Encoding.Default.GetString(bmsg);
                string[] datas = msg.Split('|');
                if( datas.Length !=4)
                {
                    continue;
                }
                if(datas[0]=="LOGIN")
                {
                    Friend friend = new Friend();

                    int curIndex = Convert.ToInt32(datas[2]);
                    
                    if(curIndex<0||curIndex>this.liHeadImages.Images.Count)
                    {
                        curIndex = 0;
                    }

                    friend.HeadImageINdex = curIndex;
                    friend.NickName = datas[1];
                    friend.Shuoshuo = datas[3];

                    UCFriend ucf = new UCFriend();
                    object[] pars = new object[1];
                    pars[0] = friend;
                    this.Invoke(new delAddFriend(this.addUcf), pars[0]);
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            


            Thread th = new Thread(new ThreadStart(listen));
            
            th.IsBackground = true;
            th.Start();

            Thread.Sleep(100);

            UdpClient uc = new UdpClient();
            string myname = System.Environment.MachineName;
            string msg = "LOGIN|" + myname + "|12|大家来找我吧";
            byte[] bmsg = Encoding.Default.GetBytes(msg);

            uc.Send(bmsg, bmsg.Length, new IPEndPoint(IPAddress.Parse("255.255.255.255"), 9527));
            
        }
        public void addUcf(Friend f)
        {
            UCFriend ucf = new UCFriend();
            ucf.Fg = this;
            ucf.CurFriend = f;
            ucf.Top = this.FriendList.Controls.Count * ucf.Height;
            this.FriendList.Controls.Add(ucf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}
