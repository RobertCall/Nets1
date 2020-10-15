using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Network_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            try
            {
                string src_addr = src_ip_textBox.Text;
                int src_port = Int32.Parse(src_port_textBox.Text);
                string dst_addr = dst_ip_textBox.Text;
                int dst_port = Int32.Parse(dst_port_textBox.Text);
                Socket_Generator sg = new Socket_Generator(src_addr, src_port, dst_addr, dst_port);
                Thread genThread = new Thread(new ThreadStart(sg.generate));
                genThread.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Unable to parse port");
            }
        }
    }
    public class Socket_Generator
    {
        string src_addr;
        string dst_addr;
        int src_port;
        int dst_port;
        public Socket_Generator(string _src_addr, int _src_port, string _dst_addr, int _dst_port)
        {
            src_addr = _src_addr;
            dst_addr = _dst_addr;
            src_port = _src_port;
            dst_port = _dst_port;
        }
        public void generate()
        {
            try
            {
                Socket s = new Socket(SocketType.Raw, ProtocolType.Tcp);
                s.Connect(dst_addr, dst_port);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception");
            }
        }
    }
}
