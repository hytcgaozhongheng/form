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

                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmMain.CheckForIllegalCrossThreadCalls = false;

            Thread th = new Thread(new ThreadStart(listen));
            Thread.Sleep(100);
            th.IsBackground = true;
            th.Start();

            UdpClient uc = new UdpClient();
            string myname = this.NiceName.Text;
            string msg = "LOGIN|" + myname + "|12|大家来找我吧";
            byte[] bmsg = Encoding.Default.GetBytes(msg);
            
            uc.Send(bmsg, bmsg.Length, new IPEndPoint(IPAddress.Parse("255,255,255,255"),0));
        }

       
    }
}
