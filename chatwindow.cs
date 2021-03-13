using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace baborant
{
    public partial class chatwindow : Form
    {
        Socket sck;
        EndPoint eplocal, epRemote;
        byte[] buffer;
        public chatwindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // socket 
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            textLocalIP.Text = GetLocalIP();
            textServerIP1.Text = GetLocalIP();
        }
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }
        private void buttonServerConnect_Click(object sender, EventArgs e)
        {
            // binding socket
            eplocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
            sck.Bind(eplocal);

            // connect to server

            epRemote = new IPEndPoint(IPAddress.Parse(textServerIP1.Text), Convert.ToInt32(textServerPort1.Text));
            sck.Connect(epRemote);

            // listening

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallback), buffer);
        }
        private void MessageCallback(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                // convery
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedmessage = aEncoding.GetString(receivedData);
                // ADD TEH MEHAS
                listChatLog.Items.Add("anon: " + receivedmessage);
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallback), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void buttonSendButton_Click(object sender, EventArgs e)
        {
            // covert
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textSendText.Text);
            // sending
            sck.Send(sendingMessage);
            // add to chatlog
            listChatLog.Items.Add("me: " + textSendText.Text);
            textSendText.Text = "";




        }




    }
}
