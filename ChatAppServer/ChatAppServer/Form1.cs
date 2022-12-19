using ChatAppServer.ServerSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Text.Json;
using ChatAppServer.Model;
using ChatAppServer.Controller;

namespace ChatAppServer
{
    public partial class Form1 : Form
    {
        private delegate void CallDelegate(string text);
        private TcpListener serverSocket;
        private List<Worker> workers = new List<Worker>();
        private readonly UserController userController = new UserController();
        private readonly ChatController chatController = new ChatController();
        private readonly GroupController groupController = new GroupController();
        private Thread thread;
        public Form1()
        {
            InitializeComponent();
        }
        private IPAddress LocalIPAddress()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "Start")
            {
                try
                {
                    serverSocket = new TcpListener(LocalIPAddress(), 2008);
                    serverSocket.Start();
                    thread = new Thread(WaitForConnection) { IsBackground = true };
                    thread.Start();
                    listBox.Items.Add(DateTime.Now.ToString() + ":Server is running at : " + LocalIPAddress().ToString() + ":2008!");
                    btn_start.Text = "Stop";
                } catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong!");
                }
                
            }
            else
            {
                serverSocket.Stop();
                listBox.Items.Add(DateTime.Now.ToString()+":Server stopped!");
                btn_start.Text = "Start";
            }
        }

        public void WaitForConnection()
        {
            try
            {
                while (true)
                {
                    TcpClient socket = serverSocket.AcceptTcpClient();
                    Worker worker = new Worker(socket);
                    AddWorker(worker);
                    worker.Start();
                }
            } catch (Exception ex)
            {
                thread.Abort();
            }

        }

        private void Worker_MessageReceived(object sender, MessageEventArgs e)
        {
            HandleMessage(sender as Worker, e.Message);
        }

        private void Worker_Disconnected(object sender, EventArgs e)
        {
            RemoveWorker(sender as Worker);
        }

        private void AddWorker(Worker worker)
        {
            lock (this)
            {
                workers.Add(worker);
                worker.Disconnected += Worker_Disconnected;
                worker.MessageReceived += Worker_MessageReceived;
            }
        }

        private void RemoveWorker(Worker worker)
        {
            SetText(DateTime.Now.ToString() + worker.Username.ToString() + "disconnected!");
            lock (this)
            {
                worker.Disconnected -= Worker_Disconnected;
                worker.MessageReceived -= Worker_MessageReceived;
                workers.Remove(worker);
                worker.Close();
            }
        }

        private void SetText(string text)
        {
            if (listBox.InvokeRequired)
            {
                var dlg = new CallDelegate(SetText);
                listBox.Invoke(dlg, new object[] { text });
            }
            else
            {
                listBox.Items.Add(text + Environment.NewLine);
            }
        }
        private string ParseToJson(object obj)
        {
            return JsonSerializer.Serialize(obj);
        }

        private void HandleMessage(Worker from, String message)
        {
            lock (this)
            {
                try
                {
                    SetText(DateTime.Now.ToString() + from.Username.ToString() + message);
                    var request = JsonSerializer.Deserialize<Base>(message);
                    if (request.model != null && request.action != null)
                    {
                        switch (request.model.ToLower())
                        {
                            case "user":
                                {

                                    userController.UserHandler(request, workers, from);
                                }
                                break;
                            case "group":
                                {
                                    if (!groupController.GroupHandler(request, workers, from).Result)
                                    {
                                        from.Send(new response { action = "Error", content = "Some thing went wrong, please try again later!" }.ParseToJson());
                                    }
                                }
                                break;
                            case "chat":
                                {
                                    if (!chatController.ChatHandler(request, workers, from).Result)
                                    {
                                        from.Send(new response { action = "Error", content = "Some thing went wrong, please try again later!" }.ParseToJson());
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                } catch(Exception ex)
                {
                    SetText(DateTime.Now + ": Exception: " + ex.Message);
                }
                
            }
        }
    }
}
