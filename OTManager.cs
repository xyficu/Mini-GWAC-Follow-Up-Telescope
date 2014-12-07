using System;
using System.Net;
using System.Net.Sockets;
//////////////////////////////////////////////////////////////////////////
/*OT处理类
 * 1. 实现OT服务的启动、监听、结束
 * 2. 实现对OT的优先级调度
 * 3. 
 * 
 * author: xyf
 * date: 2014-11-27
*/
//////////////////////////////////////////////////////////////////////////
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DDMAgent
{
    public class ClientInfo
    {
        public byte[] buffer;
        public string nickName { get; set; }
        public EndPoint id { get; set; }
        public IntPtr handle { get; set; }

    }

    public class SocketMessage
    {
        public bool isLogin { get; set; }
        public ClientInfo client { get; set; }
        public string message { get; set; }
        public DateTime Time { get; set; }
    }

    public class ServerInfo
    {
        public bool listenState { get; set; }

    }

    class OTManager
    {
        public string ErrMsg;
        frmOTList parent;
        ListBox otList;
        ServerInfo serverInfo;

        private Dictionary<Socket, ClientInfo> clientPool = new Dictionary<Socket, ClientInfo>();
        private List<SocketMessage> msgPool = new List<SocketMessage>();

        public void Run(int port)
        {
            if (serverInfo.listenState == false)
            {
                Thread serverSocketThread = new Thread(() =>
                {
                    Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    server.Bind(new IPEndPoint(IPAddress.Any, port));
                    server.Listen(10);
                    server.BeginAccept(new AsyncCallback(AcceptCallBack), server);
                });

                serverSocketThread.Start();
                serverInfo.listenState = true;
            }
            

        }

        private void AcceptCallBack(IAsyncResult result)
        {
            Socket server = (Socket)result.AsyncState;
            Socket client = server.EndAccept(result);
            try
            {
                //MessageBox.Show("accept is asynced called");
                //处理下一个客户端连接
                server.BeginAccept(new AsyncCallback(AcceptCallBack), server);
                byte[] buffer = new byte[1024];
                //接收客户端消息
                client.BeginReceive(buffer, 0, buffer.Length, 0, new AsyncCallback(ReceiveCallBack), client);
                ClientInfo info = new ClientInfo();
                info.id = client.RemoteEndPoint;
                info.handle = client.Handle;
                info.buffer = buffer;
                //把客户端存入clientPool
                this.clientPool.Add(client, info);
            }
            catch (System.Exception ex)
            {
                ErrMsg = ex.ToString();
            }
        }


        private void ReceiveCallBack(IAsyncResult result)
        {
            Socket client = (Socket)result.AsyncState;

            if (client == null || !clientPool.ContainsKey(client))
            {
                MessageBox.Show("returned");
                return;
            }

            try
            {
                int length = client.EndReceive(result);
                byte[] buffer = clientPool[client].buffer;

                //接收消息
                client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), client);
                string msg = Encoding.UTF8.GetString(buffer, 0, length);
                SocketMessage sm = new SocketMessage();
                sm.client = clientPool[client];
                sm.Time = DateTime.Now;
                sm.message = msg;
                parent.otItem = msg;
                parent.CallDelegate();



                msgPool.Add(sm);
            }
            catch (System.Exception ex)
            {
                //把客户端标记为关闭，并在clientPool中清除
                MessageBox.Show(ex.ToString());
                client.Disconnect(true);
                //Console.WriteLine("Client {0} disconnet", clientPool[client].Name);
                clientPool.Remove(client);
            }
        }

        //构造函数，初始化参数设置
        public OTManager(frmOTList frm)
        {

            parent = frm;
            serverInfo = new ServerInfo();
            serverInfo.listenState = false;

            //try
            //{
            //    ip = IPAddress.Parse("127.0.0.1");
            //    otServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //    otServerSocket.Bind(new IPEndPoint(ip, port));
            //    otServerSocket.Listen(10);
            //}
            //catch (System.Exception ex)
            //{
            //    ErrMsg = ex.ToString();
            //}

        }

        ////启动监听线程
        //public void StartListening()
        //{
        //    Thread otThread = new Thread(ListenClientConnect);
        //    otThread.Start();
        //    otList.Items.Add("start listening...");
        //}

        ////监听线程函数
        //private void ListenClientConnect()
        //{
        //    try
        //    {

        //            Socket clientSocket = otServerSocket.Accept();
        //            clientSocket.Send(Encoding.ASCII.GetBytes("Server Say Hello"));
        //            //启动接收线程
        //            Thread receiveThread = new Thread(ReceiveMsg);
        //            receiveThread.Start(clientSocket);

        //    }
        //    catch (System.Exception ex)
        //    {
        //        ErrMsg = ex.ToString();
        //    }

        //}

        ////接收线程函数
        //private void ReceiveMsg(object obj)
        //{
        //    Socket clientSocket = (Socket)obj;

        //    try
        //    {

        //        int msgLength = clientSocket.Receive(msg);
        //        str = Encoding.ASCII.GetString(msg, 0, msgLength);
        //        MessageBox.Show(str);
        //        otList.Items.Add(str);

        //    }
        //    catch (System.Exception ex)
        //    {
        //        clientSocket.Shutdown(SocketShutdown.Both);
        //        clientSocket.Close();
        //        ErrMsg = ex.ToString();
        //    }
        //}

    }
}
