using DisEntity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisWebSocketServer
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            try
            {
                _server = new WSocketServer();
                _server.MessageReceived += Server_MessageReceived;
                _server.NewConnected += Server_NewConnected;
                _server.Closed += _server_Closed;
            }
            catch (Exception ex)
            {
                WSocketServer._Logger.Error(ex.ToString());
            }
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //实例化委托
            addListView = new AddListView(ShowClientMsg);
            addOnlineItem = new AddOnlineItem(ShowAddOnlineItem);
            removeOnlineItem = new RemoveOnlineItem(ShowRemoveOnlineItem);
        }
        #endregion

        #region 对象
        /// <summary>
        /// websocket对象
        /// </summary>
        WSocketServer _server = null;

        /// <summary>
        /// 存储session和对应ip端口号的泛型集合
        /// </summary>
        Dictionary<string, SuperWebSocket.WebSocketSession> clientConnectionItems = new Dictionary<string, SuperWebSocket.WebSocketSession>();

        /// <summary>
        /// 标识是否显示消息 true 显示 false 不显示
        /// </summary>
        bool MsgFalg = true;

        #endregion

        #region 启动监听
        /// <summary>
        /// 启动监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_StartListen_Click(object sender, EventArgs e)
        {
          
            int port = 9000;
            if (textBox_port.Text == string.Empty)
            {
                MessageBox.Show("请填写端口", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                port = Convert.ToInt32(textBox_port.Text.Trim());
            }
            catch
            {
                MessageBox.Show("请填写正确的端口", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            button_StartListen.Enabled = false;
            button_StopListen.Enabled = true;
            button_Send.Enabled = true;
            try
            {
                var result = _server.Open(port, "DIS");
                if (result)
                {
                    this.toolStripLabel_event.Text = "启动成功";
                    this.toolStripLabel_event.ForeColor = Color.Green;
                    this.toolStripLabel1.Text = "监听端口：" + port.ToString();
                    WSocketServer._Logger.Info("服务器启动成功");
                }
                else
                {
                    this.toolStripLabel_event.Text = "启动失败";
                    this.toolStripLabel_event.ForeColor = Color.Red;
                    this.toolStripLabel1.Text = "监听端口：" + port.ToString();
                    button_StartListen.Enabled = true;
                    button_StopListen.Enabled = false;
                    button_Send.Enabled = false;
                    WSocketServer._Logger.Error("服务器启动失败");
                }
            }
            catch (Exception ex)
            {
                WSocketServer._Logger.Error("服务器启动失败:"+ ex.ToString());
            }
        }
        #endregion

        #region WebSocket监听
        /// <summary>
        /// 接收到的数据
        /// </summary>
        /// <param name="session">session</param>
        /// <param name="rData">value</param>
        private void Server_MessageReceived(SuperWebSocket.WebSocketSession session, string rData)
        {
            //IP地址
            string ipAddress_Receive = session.RemoteEndPoint.ToString();
            if (rData.Equals(""))
            {
                //空数据不返回服务器信息
                return;
            }
            try
            {
                //接收到客户端链接发送的东西
                ReceiveData receiveData = JsonConvert.DeserializeObject<ReceiveData>(rData);
                switch (receiveData.Type)
                {
                    case "HeartBeat":
                        //心跳
                        //发送客户端连接成功信息
                        _server.SendMessage(session, "HeartBeat");
                        break;
                    default:
                        //返回用户发送数据
                        _server.SendMessage(session, JsonConvert.SerializeObject(receiveData));
                        break;
                }
            }
            catch
            {
                WSocketServer._Logger.Error("接收异常数据:" + rData);
                //错误数据不反回服务器信息
                return;
            }
            if (MsgFalg)
            {
                //服务端显示客户端发送接受信息
                this.BeginInvoke(addListView, ipAddress_Receive, rData);
            }
        }
        /// <summary>
        /// 新连接
        /// </summary>
        /// <param name="obj"></param>
        private void Server_NewConnected(SuperWebSocket.WebSocketSession session)
        {
            //对新链接做处理，验证链接是否合法等等，不合法则关闭该链接
            //新链接进行数据初始化
            if (!session.Path.ToString().Equals("DIS"))
            {
                string ipAddress_Connect = session.RemoteEndPoint.ToString();
                clientConnectionItems.Add(ipAddress_Connect, session);
                if (MsgFalg)
                {
                    //服务端显示客户端发送接受信息
                    this.BeginInvoke(addListView, ipAddress_Connect, "连接成功");
                }
                clientCountEvent("在线数量：" + clientConnectionItems.Count());
                //添加到CheckedBoxList 
                this.BeginInvoke(addOnlineItem, ipAddress_Connect);
                //发送客户端连接成功信息
                _server.SendMessage(session, "success");
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="obj"></param>
        private void _server_Closed(SuperWebSocket.WebSocketSession session)
        {
            string ipAddress_Close = session.RemoteEndPoint.ToString();
            clientConnectionItems.Remove(ipAddress_Close);
            if (MsgFalg)
            {
                //服务端显示客户端发送接受信息
                this.BeginInvoke(addListView, ipAddress_Close, "关闭连接");
            }
            //移除 CheckedBoxList 指定item 
            this.BeginInvoke(removeOnlineItem, ipAddress_Close);
            clientCountEvent("在线数量：" + clientConnectionItems.Count());
        }
        #endregion

        #region 关闭所有监听
        /// <summary>
        /// 关闭所有监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_StopListen_Click(object sender, EventArgs e)
        {
            //销毁webScoket
            _server.Dispose();
            //清空连接的用户信息
            clientConnectionItems = new Dictionary<string, SuperWebSocket.WebSocketSession>();
            //设置按钮
            button_StartListen.Enabled = true;
            button_StopListen.Enabled = false;
            button_Send.Enabled = false;
            //清空发送列表
            clbOnlineClient.Items.Clear();
            //重置底部导航信息
            this.toolStripLabel_event.Text = "停止监听";
            this.toolStripLabel_event.ForeColor = Color.Blue;
            this.toolStripLabel1.Text = "监听端口：";
            clientCountEvent("在线数量：0");
        }
        #endregion

        #region ListView Add
        /// <summary>
        /// 创建一个委托，是为访问TextBox控件服务的。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="msg"></param>
        public delegate void AddListView(string client, string msg);
        //定义一个委托变量
        public AddListView addListView;
        /// <summary>
        /// 线上客户端信息
        /// </summary>
        /// <param name="client"></param>
        /// <param name="msg"></param>
        private void ShowClientMsg(string client, string msg)
        {
            ListViewItem item = new ListViewItem(new string[] { DateTime.Now.ToString(), client.ToString(), msg });
            this.listView1.Items.Insert(0, item);
        }

        #endregion

        #region checkedBoxList Add
        /// <summary>
        /// 创建一个委托，是为访问控件服务的。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="msg"></param>
        public delegate void AddOnlineItem(string itemName);
        //定义一个委托变量
        public AddOnlineItem addOnlineItem;

        /// <summary>
        /// 添加上线的指静脉设备
        /// </summary>
        /// <param name="itemName"></param>
        private void ShowAddOnlineItem(string itemName)
        {
            this.clbOnlineClient.Items.Insert(0, itemName);
        }

        #endregion

        #region checkedBoxList Remove
        /// <summary>
        /// 创建一个委托，是为访问控件服务的。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="msg"></param>
        public delegate void RemoveOnlineItem(string itemName);
        //定义一个委托变量
        public RemoveOnlineItem removeOnlineItem;

        /// <summary>
        /// 移出下线的指静脉设备
        /// </summary>
        /// <param name="itemName"></param>
        private void ShowRemoveOnlineItem(string itemName)
        {
            this.clbOnlineClient.Items.Remove(itemName);
        }

        #endregion

        #region 在线数量
        /// <summary>
        /// 在线数量
        /// </summary>
        /// <param name="msg"></param>
        private void clientCountEvent(string msg)
        {
            if (this.InvokeRequired)
            {
                Action<string> actionDelegate = (x) =>
                {
                    this.toolStripLabel_clientCount.Text = msg;
                };
                this.toolStrip1.Invoke(actionDelegate, msg);
            }
            else
            {
                this.toolStripLabel_clientCount.Text = msg;
            }
        }
        #endregion

        #region 设置是否显示消息
        /// <summary>
        /// 设置是否显示消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chb_msg_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_msg.Checked)
            {
                MsgFalg = true;
                tsl_msg.Text = "显示接到消息";
            }
            else
            {
                MsgFalg = false;
                tsl_msg.Text = "不显示接到消息";
            }
        }

        #endregion

        #region 发送一条信息
        /// <summary>
        /// 发送一条信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Send_Click(object sender, EventArgs e)
        {

            if (clbOnlineClient.CheckedItems.Count != 0)
            {
                if (textBox_msg.Text == string.Empty)
                {
                    textBox_msg.Focus();
                    MessageBox.Show("请输入有效的发送数据", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string s = "";
                for (int x = 0; x <= clbOnlineClient.CheckedItems.Count - 1; x++)
                {
                    s = clbOnlineClient.CheckedItems[x].ToString();
                    foreach (SuperWebSocket.WebSocketSession session in clientConnectionItems.Values)
                    {
                        //客户端网络节点号
                        string remoteEndPointStr = session.RemoteEndPoint.ToString();
                        if (remoteEndPointStr == s)
                        {
                            try
                            {
                                ReceiveData sendData = new ReceiveData();
                                //发送数据
                                sendData.Type = "msg";
                                sendData.Msg = textBox_msg.Text.Trim();
                                _server.SendMessage(session, JsonConvert.SerializeObject(sendData));
                                MessageBox.Show("发送成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            catch (Exception ex)
                            {
                                WSocketServer._Logger.Error(ex.ToString());
                                MessageBox.Show(ex.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}
