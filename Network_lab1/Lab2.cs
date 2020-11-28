using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using PacketDotNet;
using SharpPcap;

namespace Network_lab1
{
    public class Generator
    {
        string ip;
        public Generator(string _ip)
        {
            ip = _ip;
        }

        public void check()
        {
            /*for(int i = 1; i < 65535; i++)
            {

            }*/
            /*try
            {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);
                byte[] send_data = new byte[1024];
                byte[] recv_data = new byte[1024];

                IPEndPoint iep = new IPEndPoint(IPAddress.Parse(ip), 8888);
                EndPoint ep = (EndPoint)iep;

                s.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 1000);
                s.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.IpTimeToLive, 128);

                Buffer.BlockCopy(BitConverter.GetBytes(0x08), 0, send_data, 0, 1);
                Buffer.BlockCopy(BitConverter.GetBytes(0), 0, send_data, 1, 1);
                Buffer.BlockCopy(BitConverter.GetBytes(87), 0, send_data, 2, 2);
                byte[] message = Encoding.ASCII.GetBytes("I like dogs");
                Buffer.BlockCopy(message, 0, send_data, 4, message.Length);

                s.SendTo(send_data, message.Length + 4, SocketFlags.None, iep);
                MessageBox.Show("lalal");
                int recv = s.ReceiveFrom(recv_data, ref ep);
                MessageBox.Show(Encoding.ASCII.GetString(recv_data, 0, recv_data.Length));

                MessageBox.Show("Response from: " + ep.ToString());
                s.Close();
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.Message, "SocketException" + e.ErrorCode);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception");
            }*/
            var devices = CaptureDeviceList.Instance;
            MessageBox.Show("alalal");

            // дифференцируем по типу устройства
            foreach (ICaptureDevice dev in devices)
            {
                MessageBox.Show(dev.Name + dev.Description);
            }
        }
    }
}
