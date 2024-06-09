using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RacingCar_Server
{
    public class Server : Form
    {
        private PictureBox pictureBox1;
        private Label label3;
        private Button buttonStop;
        private Button btConnect;
        private TextBox tbRooms;
        private Label label2;
        private TextBox tbUsers;
        private Label label1;
        private ListBox listBox1;

        public Server()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.tbRooms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RacingCar_Server.Properties.Resources.BackroundLobby;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 95);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(137, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 69);
            this.label3.TabIndex = 25;
            this.label3.Text = "Game Server";
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(561, 324);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(156, 66);
            this.buttonStop.TabIndex = 24;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(561, 222);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(156, 66);
            this.btConnect.TabIndex = 23;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbRooms
            // 
            this.tbRooms.Location = new System.Drawing.Point(678, 166);
            this.tbRooms.Name = "tbRooms";
            this.tbRooms.Size = new System.Drawing.Size(39, 22);
            this.tbRooms.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số phòng đua:";
            // 
            // tbUsers
            // 
            this.tbUsers.Location = new System.Drawing.Point(678, 128);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Size = new System.Drawing.Size(39, 22);
            this.tbUsers.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Số người chơi:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(43, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(466, 276);
            this.listBox1.TabIndex = 18;
            // 
            // Server
            // 
            this.BackgroundImage = global::RacingCar_Server.Properties.Resources.FServer1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.tbRooms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private static int numPlayers;
        private static int numRooms;
        private static Socket serverSocket;
        private static Socket client;
        private static Thread clientThread;
        private static List<Player> connectedPlayers = new List<Player>();
        private static RaceRoom[] Room;

        private void Server_Load(object sender, EventArgs e)
        {
            buttonStop.Enabled = false;
        }
        private async void btConnect_Click(object sender, EventArgs e)
        {
            
            //Xác minh số người chơi và số phòng đua là hợp lệ
            if (int.TryParse(tbRooms.Text, out numRooms) == false
                || int.TryParse(tbUsers.Text, out numPlayers) == false)
            {
                MessageBox.Show("Vui lòng nhập số người chơi và phòng đua phù hợp!!!");
                return;
            }
            if (!int.TryParse(tbUsers.Text, out numPlayers) || numPlayers <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng người chơi hợp lệ!!!");
                return;
            }
            if (!int.TryParse(tbRooms.Text, out numRooms) || numRooms <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng phòng đua hợp lệ!!!");
                return;
            }
            btConnect.Enabled = false;
            buttonStop.Enabled = true;
            tbRooms.Enabled = false;
            tbUsers.Enabled = false;
            //Tạo các phòng đua và thêm vào danh sách
            Room = new RaceRoom[numRooms];
            for (int i = 0; i < numRooms; i++)
            {
                Room[i] = new RaceRoom();
            }
            await Task.Run(() => StartServer());

        }
        private void StartServer()
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
                serverSocket.Bind(serverEP);
                serverSocket.Listen(numPlayers + 50);

                // Chấp nhận kết nối từ client
                while (true)
                {
                    client = serverSocket.Accept();
                    clientThread = new Thread(() => readingClientSocket(client));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể khởi động server: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void readingClientSocket(Socket client)
        {
            try
            {
                Player p = new Player();
                p.playerSocket = client;
                connectedPlayers.Add(p);

                byte[] buffer = new byte[1024];

                while (p.playerSocket.Connected)
                {
                    if (p.playerSocket.Available > 0)
                    {
                        string msg = "";

                        while (p.playerSocket.Available > 0)
                        {
                            int bRead = p.playerSocket.Receive(buffer);
                            msg += Encoding.UTF8.GetString(buffer, 0, bRead);
                        }
                        AnalyzingMessage(msg, p);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhận dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
      
        public static void AnalyzingMessage(string msg, object obj)
        {

            Player p = (Player)obj;
            string[] arrPayload = msg.Split(';');
            int tableIndex = -1; //table number
            int side = -1;//Seat number
            int a = 0;
            string sendString = "";
            int anotherSide = -1; //The seat number of the other side
            switch (arrPayload[0])
            {
                case "LOGIN":
                    {
                        p.name = arrPayload[1];
                        foreach (var player in connectedPlayers)
                        {
                            if (player.name == p.name)
                                a++;
                            
                        }
                        if (a > 1)
                        {
                            byte[] buffer = Encoding.UTF8.GetBytes("ERRORNAME;");
                            p.playerSocket.Send(buffer);
                            p.playerSocket.Shutdown(SocketShutdown.Both);
                            p.playerSocket.Close();
                            connectedPlayers.Remove(p);
                            Thread.Sleep(100);
                        }
                        else
                        if (connectedPlayers.Count > numPlayers)
                        {
                            byte[] buffer = Encoding.UTF8.GetBytes("SORRY;");
                            p.playerSocket.Send(buffer);
                            p.playerSocket.Shutdown(SocketShutdown.Both);
                            p.playerSocket.Close();
                            connectedPlayers.Remove(p);
                        }                           
                        else
                        {
                            byte[] buffer = Encoding.UTF8.GetBytes("TABLES;" + GetOnlineString());
                            p.playerSocket.Send(buffer);
                            Thread.Sleep(100);
                        }

                    }
                    break;
                case "SITDOWN":
                    {
                        tableIndex = int.Parse(arrPayload[1]);
                        side = int.Parse(arrPayload[2]);
                        Room[tableIndex].user[side].player = p;
                        Room[tableIndex].user[side].someone = true;
                        //gửi dữ liệu tới 2 user trong 1 phòng
                        //Format: SitDown, seat number, username
                        anotherSide = (side + 1) % 2;
                        foreach (var player in connectedPlayers)
                        {
                            if (Room[tableIndex].user[anotherSide].someone == true)
                            {
                                byte[] buffer = Encoding.UTF8.GetBytes("SITDOWN;" + tableIndex + ";" + anotherSide + ";" + Room[tableIndex].user[anotherSide].player.name);
                                player.playerSocket.Send(buffer);
                                Thread.Sleep(100);
                                byte[] buffers = Encoding.UTF8.GetBytes("SITDOWN;" + tableIndex + ";" + side + ";" + Room[tableIndex].user[side].player.name);
                                player.playerSocket.Send(buffers);
                                Thread.Sleep(100);
                            }
                            else
                            if (player.name == Room[tableIndex].user[side].player.name)
                            {
                                byte[] buffer = Encoding.UTF8.GetBytes("SITDOWN;" + tableIndex + ";" + side + ";" + Room[tableIndex].user[side].player.name);
                                player.playerSocket.Send(buffer);
                                Thread.Sleep(100);
                            }
                          
                        }
                            //gửi dữ liệu về tình trạng phòng chơi cho tất cả user
                        foreach (var player in connectedPlayers)
                        {
                            byte[] buffer = Encoding.UTF8.GetBytes("TABLES;" + GetOnlineString());
                            player.playerSocket.Send(buffer);
                            Thread.Sleep(100);
                        }
                    }
                    break;
                case "GETUP":
                    {
                        tableIndex = int.Parse(arrPayload[1]);
                        side = int.Parse(arrPayload[2]);
                        anotherSide = (side + 1) % 2;

                        //Send the departure information to two users in the format: GetUp, seat number, user name
                        foreach (var player in connectedPlayers)
                        {
                            if (Room[tableIndex].user[anotherSide].someone == true)
                            {
                                byte[] buffer = Encoding.UTF8.GetBytes("GETUP;" + tableIndex + ";" + side + ";" + arrPayload[3]);
                                player.playerSocket.Send(buffer);
                                Thread.Sleep(100);
                            }
                            else
                            if (player.name == Room[tableIndex].user[side].player.name)
                            {
                                byte[] buffer = Encoding.UTF8.GetBytes("GETUP;" + tableIndex + ";" + side + ";" + arrPayload[3]);
                                player.playerSocket.Send(buffer);
                                Thread.Sleep(100);
                            }
                        }
                        Room[tableIndex].user[side].someone = false;          
                        //gửi dữ liệu về tình trạng phòng chơi cho tất cả user
                        foreach (var player in connectedPlayers)
                        {
                            byte[] buffer = Encoding.UTF8.GetBytes("TABLES;" + GetOnlineString());
                            player.playerSocket.Send(buffer);
                            Thread.Sleep(100);
                        }                        
                    }
                    break;
                case "TALK":
                    {
                        tableIndex = int.Parse(arrPayload[2]);
                        side = int.Parse(arrPayload[3]);
                        anotherSide = (side + 1) % 2;
                        foreach (var player in connectedPlayers)
                        {
                            if (player.name == Room[tableIndex].user[anotherSide].player.name && Room[tableIndex].user[anotherSide].player.name != null)
                            {
                                byte[] buffer = Encoding.UTF8.GetBytes("TALK;" + arrPayload[1] + ";" + "a");
                                player.playerSocket.Send(buffer);
                                Thread.Sleep(100);
                            }
                        }
                    }
                    break;
                case "DISCONNECT":
                    {
                        // Remove the disconnected player from list
                        foreach (var player in connectedPlayers)
                        {
                            if (player.name == arrPayload[1])
                            {
                                player.playerSocket.Shutdown(SocketShutdown.Both);
                                player.playerSocket.Close();
                                connectedPlayers.Remove(player);
                            }
                        }
                    }
                    break;
                case "START":
                    {
       
                        tableIndex = int.Parse(arrPayload[2]);
                        side = int.Parse(arrPayload[3]);
                        anotherSide = (side + 1) % 2;
                        foreach (var player in connectedPlayers)
                        {
                            if (player.name == Room[tableIndex].user[anotherSide].player.name && Room[tableIndex].user[anotherSide].player.name != null)
                            {
                                byte[] buffer = Encoding.UTF8.GetBytes("TALK;" + arrPayload[1] + ";" + "b" + ";" + arrPayload[4] + ";" + arrPayload[5]);
                                player.playerSocket.Send(buffer);
                                Thread.Sleep(100);
                            
                            }
                           
                            if (player.name == Room[tableIndex].user[side].player.name && Room[tableIndex].user[anotherSide].player.name != null && side ==0)
                            {
                                byte[] buffer = Encoding.UTF8.GetBytes("START;" + tableIndex + ";" + side) ;
                                player.playerSocket.Send(buffer);
                                Room[tableIndex].user[anotherSide].player.playerSocket.Send(buffer);
                                Thread.Sleep(100);
                            }
                        }
                    }
                    break;             
                default:
                    break;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server đã dừng kết nối, các người chơi sẽ thoát theo trình tự!!!", "Thông báo");
            foreach (var player in connectedPlayers)
            {       
                    player.playerSocket.Close();         
            }
            connectedPlayers.Clear();
            serverSocket.Close(); // Đóng socket của máy chủ
            buttonStop.Enabled = false;
            tbUsers.Enabled = true;
            tbRooms.Enabled = true;
            btConnect.Enabled = true;
        }
        private static string GetOnlineString()
        {
            string str = "";
            for (int i = 0; i < Room.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    str += Room[i].user[j].someone == true ? "1" : "0";
                }
            }
            return str;
        }
    }
}
