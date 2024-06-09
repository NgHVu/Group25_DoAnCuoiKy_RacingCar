using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingCar_Client
{
    class ClientSocket
    {
        public static Socket clientSocket;
        public static Thread recvThread;
        public static string datatype = "";
       
        public static List<string> playerNames = new List<string>();
        public static Dictionary<int, List<string>> playerNamesByRoom = new Dictionary<int, List<string>>();
          

        public static void Connect(IPEndPoint serverEP)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(serverEP);
            recvThread = new Thread(() => readingReturnData());
            recvThread.Start();
        }
        public static void SendMessage(string data)
        {
            string msgstr = datatype + ";" + data;
            byte[] msg = Encoding.UTF8.GetBytes(msgstr);
            clientSocket.Send(msg);
        }

        public static void readingReturnData()
        {
            byte[] buffer = new byte[1024];

            while (clientSocket.Connected)
            {
                if (clientSocket.Available > 0)
                {
                    string msg = "";
                    
                    while (clientSocket.Available > 0)
                    {
                        int bRead = clientSocket.Receive(buffer);
                        msg += Encoding.UTF8.GetString(buffer, 0, bRead);
                    }

                    AnalyzingReturnMessage(msg);
                }
            }
        }
        public static void AnalyzingReturnMessage(string msg)
        {
            string[] arrPayload = msg.Split(';');           
            switch (arrPayload[0])
            {
                case "ERRORNAME":
                    {
                        MessageBox.Show("Tên đăng nhập đã người sử dụng vui lòng nhập tên khác!!!", "Thông báo");
                        ConnectRoom.tbName.Clear();
                        ConnectRoom.EnablebtnConnect();
                    }
                    break;
                case "SORRY":
                    {
                        MessageBox.Show("Đăng nhập thành công nhưng lobby đã đầy!!!", "Thông báo");
                        clientSocket.Shutdown(SocketShutdown.Both);
                        clientSocket.Close();
                        CloseConnectRoomForm();

                    }
                    break;
                case "TABLES":
                    {                                                 
                        string s = arrPayload[1];
                        //If maxPlayingTables is 0, it means checkBoxGameTables has not been created
                        if (ConnectRoom.maxPlayingRooms == 0)
                        {
                            ConnectRoom.InfoIP();
                            ConnectRoom.maxPlayingRooms = s.Length / 2;
                            ThisPlayer.name = new string[s.Length / 2, 2];
                            ConnectRoom.checkBoxGameTables = new CheckBox[ConnectRoom.maxPlayingRooms, 2];
                            ConnectRoom.isReceiveCommand = true;
                            //Add the CheckBox object to the array
                            for (int i = 0; i < ConnectRoom.maxPlayingRooms; i++)
                            {
                                ConnectRoom.AddCheckBoxToPanel(s, i);
                            }
                            ConnectRoom.isReceiveCommand = false;
                        }
                        else
                        {
                            ConnectRoom.isReceiveCommand = true;
                            for (int i = 0; i < ConnectRoom.maxPlayingRooms; i++)
                            {
                                for (int j = 0; j < 2; j++)
                                {
                                    if (s[2 * i + j] == '0')
                                    {
                                        ConnectRoom.UpdateCheckBox(ConnectRoom.checkBoxGameTables[i, j], false);
                                    }
                                    else
                                    {
                                        ConnectRoom.UpdateCheckBox(ConnectRoom.checkBoxGameTables[i, j], true);
                                    }
                                }
                                ConnectRoom.isReceiveCommand = false;
                            }
                        }
                    }
                    break;
                case "SITDOWN":
                    {
                        int table = int.Parse(arrPayload[1]);
                        int chair = int.Parse(arrPayload[2]);
                        ThisPlayer.name[table, chair] = arrPayload[3];
                        ConnectRoom.lobby.Tempdisplay(arrPayload[3] + " đã tham gia vào phòng!", 2);
                        ConnectRoom.lobby.DisplayConnectedPlayer(table);
                    }
                    break;
                case "GETUP":
                    {
                        int table = int.Parse(arrPayload[1]);
                        int chair = int.Parse(arrPayload[2]);
                        ThisPlayer.name[table, chair] = arrPayload[3];
                        ConnectRoom.lobby.Tempdisplay(arrPayload[3] + " đã rời phòng!", 1);
                        if (ConnectRoom.side == int.Parse(arrPayload[2]) && ThisPlayer.name[table, int.Parse(arrPayload[2])] == "...")
                        {
                            ConnectRoom.side = -1;
                            ConnectRoom.lobby.Tempdisplay(arrPayload[3] + " đã rời phòng!", 0);
                        }
                        ConnectRoom.lobby.DisplayConnectedPlayer(table);

                    }
                    break;
                case "TALK":
                    {
                        ConnectRoom.lobby.Tempdisplay(arrPayload[1], 1);
                        if (arrPayload[2] == "b")
                        {
                            GamePlay.ipadress = arrPayload[3];
                            GamePlay.udpPort = int.Parse(arrPayload[4]);
                        }
                    }
                    break;
                case "START":
                    {
                        GamePlay.tableIndex = int.Parse(arrPayload[1]);
                        GamePlay.side = int.Parse(arrPayload[2]);
                        // Mở lớp Gameplay khi nhận được lệnh từ server
                        OpenGamePlay();
                            
                    }
                    break;
              
                default:
                    break;
            }
        }
        public static void OpenGamePlay()
        {
            // Đảm bảo rằng lớp GamePlay không bị xóa ngay sau khi được tạo ra
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mở lớp GamePlay
            GamePlay gameplayForm = new GamePlay();
            Application.Run(gameplayForm);
        }
        public static void CloseConnectRoomForm()
        {
            if (Application.OpenForms["ConnectRoom"] != null)
            {
                Application.OpenForms["ConnectRoom"].Invoke(new MethodInvoker(() =>
                {
                    Application.OpenForms["ConnectRoom"].Close();
                }));
            }
        }
    }
}