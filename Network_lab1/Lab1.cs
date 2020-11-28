using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Threading;
using System.IO;
using System.Collections;

namespace Network_lab1
{
    public class Client
    {
        string server;
        int port;
        string path;
        Dispatcher dispatcher;
        Form1 form;
        public Client(string _server, int _port, string _path, Dispatcher _disp, Form1 _form)
        {
            server = _server;
            port = _port;
            path = _path;
            dispatcher = _disp;
            form = _form;
        }
        public void connect()
        {
            FileInfo fileInfo = new FileInfo(path);
            bool retry = true;
            using (FileStream fstream = File.OpenRead(path))
            {
                while (retry)
                {
                    try
                    {
                        TcpClient client = new TcpClient();
                        client.Connect(server, port);
                        NetworkStream stream = client.GetStream();

                        dispatcher.BeginInvoke(new Action<int>((_progress) => form.Client_progressBar.Value = _progress), 0);

                        Thread.Sleep(10000);
                        byte[] length = BitConverter.GetBytes(fileInfo.Length);
                        byte[] name = Encoding.UTF8.GetBytes(fileInfo.Name);
                        byte[] name_length = BitConverter.GetBytes(name.Length);
                        byte[] file_data = new byte[32768];
                        stream.Write(length, 0, length.Length);
                        stream.Write(name_length, 0, name_length.Length);
                        stream.Write(name, 0, name.Length);

                        long progress = 0;
                        do
                        {
                            int bytes = fstream.Read(file_data, 0, file_data.Length);
                            progress += bytes;
                            stream.Write(file_data, 0, bytes);
                            dispatcher.BeginInvoke(new Action<int>((_progress) => form.Client_progressBar.Value = _progress), (int)(100 * progress / fileInfo.Length));
                        } while (progress < fileInfo.Length);

                        retry = false;
                        // закрываем поток
                        stream.Close();
                        // закрываем подключение
                        client.Close();
                    }
                    catch (IOException e)
                    {
                        var result = MessageBox.Show(e.Message + " Повторить попытку отправки?", "IOException", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                            retry = false;
                    }
                    catch (SocketException e)
                    {
                        var result = MessageBox.Show(e.Message + " Повторить попытку отправки?", "SocketException", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                            retry = false;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Exception");
                    }
                }
            }
        }
    }

    public class Server
    {
        public bool work = true;
        int port;
        Dispatcher dispatcher;
        Form1 form;
        string path;
        public Server(int _port, Dispatcher _disp, Form1 _form, string _path)
        {
            port = _port;
            dispatcher = _disp;
            form = _form;
            path = _path;
        }
        ~Server()
        {
            work = false;
        }
        public void Start()
        {
            TcpListener server = null;
            try
            {
                server = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
                dispatcher.BeginInvoke(new Action<string>((message) => form.Server_Status_Label.Text = message), "Server started on 127.0.0.1:" + port);
                server.Start();
                while (work)
                {
                    if (server.Pending())
                    {
                        TcpClient client = server.AcceptTcpClient();

                        byte[] data = new byte[32768];
                        StringBuilder response = new StringBuilder();
                        NetworkStream stream = client.GetStream();

                        stream.Read(data, 0, 8);
                        long length = BitConverter.ToInt64(data, 0);
                        stream.Read(data, 0, 4);
                        int name_length = BitConverter.ToInt32(data, 0);
                        int bytes = stream.Read(data, 0, name_length);
                        string name = Encoding.UTF8.GetString(data, 0, bytes);

                        using (FileStream fstream = new FileStream($"{path}\\" + name, FileMode.OpenOrCreate))
                        {
                            dispatcher.BeginInvoke(new Action<string>((message) => form.Server_Status_Label.Text = message), "Start downloading file " + name);
                            dispatcher.BeginInvoke(new Action<int>((_progress) => form.Server_progressBar.Value = _progress), 0);
                            DateTime start = DateTime.Now;
                            long progress = 0;
                            do
                            {
                                progress += stream.Read(data, 0, data.Length);
                                fstream.Write(data, 0, data.Length);
                                DateTime now = DateTime.Now;
                                TimeSpan time = now - start;
                                TimeSpan time_left = new TimeSpan(time.Ticks * (length - progress) / progress);
                                dispatcher.BeginInvoke(new Action<string>((message) => form.time_label1.Text = message), "Time0 passed " + time.ToString(@"hh\:mm\:ss"));
                                dispatcher.BeginInvoke(new Action<string>((message) => form.time_label2.Text = message), "Time0 left " + time_left.ToString(@"hh\:mm\:ss"));
                                dispatcher.BeginInvoke(new Action<int>((_progress) => form.Server_progressBar.Value = _progress), (int)(100 * progress / length));
                                //for (int i = 0; i < 10000; i++) ;
                            }
                            while (progress != length); // stream.DataAvailable); // пока данные есть в потоке*/
                            dispatcher.BeginInvoke(new Action<string>((message) => form.Server_Status_Label.Text = message), "Finish downloading file " + name);
                        }

                        // закрываем поток
                        stream.Close();
                        // закрываем подключение
                        client.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (server != null)
                    server.Stop();
            }
            dispatcher.BeginInvoke(new Action<string>((message) => form.Server_Status_Label.Text = message), "Server not listen");
        }

        public void Listen()
        {
            try
            {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);
                s.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), port));
                s.Listen(10);

                ArrayList listenList = new ArrayList();
                while (work)
                {
                    listenList.Add(s);
                    Socket.Select(listenList, null, null, 1000);
                    for (int i = 0; i < listenList.Count; i++)
                    {
                        Socket accept = ((Socket)listenList[i]).Accept();
                        byte[] message = Encoding.ASCII.GetBytes("Me too");
                        accept.Send(message);
                        accept.Close();
                    }
                }
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.Message, "SocketException" + e.ErrorCode);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception");
            }
        }
    }
}
