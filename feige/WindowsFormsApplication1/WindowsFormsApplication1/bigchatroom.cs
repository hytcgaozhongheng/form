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


namespace WindowsFormsApplication1
{
    public partial class chat : Form
    {
        public chat()
        {
            InitializeComponent();
        }

        private void chatsend_Click(object sender, EventArgs e)
        {
            UdpClient uc = new UdpClient();
            string ip = this.id.Text;
            string name = this.textBox3.Text+":";
            string msg = "PUBLIC"+"|"+this.chatbox.Text+"|"+name;
            byte[] bmsg = Encoding.Default.GetBytes(msg);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip),9527);
            uc.Send(bmsg,bmsg.Length,ipep);
        }

        
        private void listen()
        {
            UdpClient uc = new UdpClient(9527);
            while (true)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 0);

                byte[] bmsg = uc.Receive(ref ipep);
                string msg = Encoding.Default.GetString(bmsg);
                string[] data = msg.Split('|');
                if (data[0] == "PUBLIC")
                {
                    this.chatroom.Text += data[2]+data[1]+ "\r\n";
                }
                else if(data[0]=="INROOM")
                {
                    this.chatroom.Text += data[2] + "上线啦"+ "\r\n";
                }
            }
        }

        private void chat_Load(object sender, EventArgs e)
        {
            chat.CheckForIllegalCrossThreadCalls = false;
            
            Thread th = new Thread(new ThreadStart(listen));
            th.IsBackground = true;
            th.Start();

            UdpClient uc = new UdpClient();
            string ip = this.id.Text;
            string name = this.textBox3.Text + ":";
            string msg = "INROOM" + "|" + this.chatbox.Text + "|" + name;
            byte[] bmsg = Encoding.Default.GetBytes(msg);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), 9527);
            uc.Send(bmsg, bmsg.Length, ipep);
        }

      
    }
}
