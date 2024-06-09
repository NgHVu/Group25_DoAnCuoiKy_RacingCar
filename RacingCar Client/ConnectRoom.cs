using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingCar_Client
{
    public partial class ConnectRoom : Form
    {
        public static TextBox tbName;
        public static TextBox tbLocal;
        private Label label1;
        private Label label3;
        private Button btnRules;
        public static Panel panel1;
        private Label label2;
        public static TextBox tbServer;
        public static Button btnConnect;

        public ConnectRoom()
        {
            InitializeComponent();   
            lobby = new Lobby();
        }
        private void InitializeComponent()
        {
            tbName = new System.Windows.Forms.TextBox();
            tbLocal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRules = new System.Windows.Forms.Button();
            btnConnect = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            tbServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tbName.Location = new System.Drawing.Point(672, 226);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new System.Drawing.Size(181, 38);
            tbName.TabIndex = 0;
            tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLocal
            // 
            tbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tbLocal.Location = new System.Drawing.Point(137, 12);
            tbLocal.Multiline = true;
            tbLocal.Name = "tbLocal";
            tbLocal.Size = new System.Drawing.Size(234, 38);
            tbLocal.TabIndex = 1;
            tbLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(609, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(76, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Local";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRules
            // 
            this.btnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.Location = new System.Drawing.Point(672, 398);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(181, 63);
            this.btnRules.TabIndex = 8;
            this.btnRules.Text = "Hướng Dẫn";
            this.btnRules.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnConnect.Location = new System.Drawing.Point(672, 301);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(181, 63);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Đăng Nhập";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = System.Drawing.Color.FloralWhite;
            panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panel1.Location = new System.Drawing.Point(12, 165);
            panel1.MinimumSize = new System.Drawing.Size(520, 320);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(559, 320);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(520, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Server";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbServer
            // 
            tbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tbServer.Location = new System.Drawing.Point(590, 12);
            tbServer.Multiline = true;
            tbServer.Name = "tbServer";
            tbServer.Size = new System.Drawing.Size(234, 38);
            tbServer.TabIndex = 10;
            tbServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConnectRoom
            // 
            this.BackgroundImage = global::RacingCar_Client.Properties.Resources.Project_Cars_3_Torrent_Download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(tbServer);
            this.Controls.Add(btnConnect);
            this.Controls.Add(panel1);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(tbLocal);
            this.Controls.Add(tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ConnectRoom";
            this.Text = "Welcome to RacingCar Game !";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectRoom_FormClosed);
            this.Load += new System.EventHandler(this.ConnectRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public static int maxPlayingRooms;
        public static CheckBox[,] checkBoxGameTables;
        public static Lobby lobby;
        // whether the command is from the server
        public static bool isReceiveCommand = false;
        //The seat number of the game table you are sitting on, -1 means not seated, 0 means black, 1 means red
        public static int side = -1;

        private void ConnectRoom_Load(object sender, EventArgs e)
        {
            maxPlayingRooms = 0;
            tbLocal.ReadOnly = true;
            tbServer.ReadOnly = true;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Vui lòng điền tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }      
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
            ClientSocket.datatype = "LOGIN";
            ClientSocket.Connect(serverEP);
            ClientSocket.SendMessage(tbName.Text);
            btnConnect.Enabled = false;
        }
        public static void InfoIP()
        {
            tbLocal.Text = ClientSocket.clientSocket.LocalEndPoint.ToString();
            tbServer.Text = ClientSocket.clientSocket.RemoteEndPoint.ToString();   
            
        }
        public static void EnablebtnConnect()
        {
            btnConnect.Enabled = true;
        }
        delegate void Paneldelegate(string s, int i);
        public static void AddCheckBoxToPanel(string s, int i)
        {
            if (panel1.InvokeRequired == true)
            {
                Paneldelegate d = AddCheckBoxToPanel;
                panel1.Invoke(d, s, i);
            }
            else
            {
                Label label = new Label();
                label.Location = new Point(15, 15 + i * 30);
                label.Text = string.Format("Table {0}: ", i + 1);
                label.Width = 70;
                panel1.Controls.Add(label);
                CreateCheckBox(i, 1, s, "Car2");
                CreateCheckBox(i, 0, s, "Car1");

            }
        }
        delegate void CheckBoxDelegate(CheckBox checkbox, bool isChecked);
        //Modify the selection state
        public static void UpdateCheckBox(CheckBox checkbox, bool isChecked)
        {
            if (checkbox.InvokeRequired == true)
            {
                CheckBoxDelegate d = UpdateCheckBox;
                panel1.Invoke(d, checkbox, isChecked);
            }
            else
            {
                if (side == -1)
                {
                    checkbox.Enabled = !isChecked;
                }
                else
                {
                    //Already seated, no other tables are allowed
                    checkbox.Enabled = false;
                }
                checkbox.Checked = isChecked;
            }
        }
        public static void CreateCheckBox(int i, int j, string s, string text)
        {
            int x = j == 0 ? 100 : 200;
            checkBoxGameTables[i, j] = new CheckBox();
            checkBoxGameTables[i, j].Name = string.Format("check{0:0000}{1:0000}", i, j);
            checkBoxGameTables[i, j].Width = 60;
            checkBoxGameTables[i, j].Location = new Point(x, 10 + i * 30);
            checkBoxGameTables[i, j].Text = text;
            checkBoxGameTables[i, j].TextAlign = ContentAlignment.MiddleLeft;
            if (s[2 * i + j] == '1')
            {
                //1 means someone
                checkBoxGameTables[i, j].Enabled = false;
                checkBoxGameTables[i, j].Checked = true;
            }
            else
            {
                //0 means no one
                checkBoxGameTables[i, j].Enabled = true;
                checkBoxGameTables[i, j].Checked = false;
            }
            panel1.Controls.Add(checkBoxGameTables[i, j]);
            checkBoxGameTables[i, j].Click += new EventHandler(checkBox_Click);
        }
     //   public static Form ConnectRoomForm;
        public static void checkBox_Click(object sender, EventArgs e)
        {
            //Whether to update the table status for the server
            if (isReceiveCommand == true)
            {
                return;
            }
            CheckBox checkbox = (CheckBox)sender;
            //If Checked is true, it means that the player sits on the jth table at the ith table
            if (checkbox.Checked == true)
            {
                int i = int.Parse(checkbox.Name.Substring(5, 4));
                int j = int.Parse(checkbox.Name.Substring(9, 4));
                side = j;
                //Format: SitDown, Nickname, Table Number, Seat Number
                ClientSocket.datatype = "SITDOWN";
                ClientSocket.SendMessage(i + ";" + j) ;  
                ThisPlayer.name[i,j] = tbName.Text;
                Lobby.tableIndex = i;
                Lobby.side = j;
                lobby.Show();
            }
        }

        private void ConnectRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClientSocket.datatype = "DISCONNECT";
            ClientSocket.clientSocket.Shutdown(System.Net.Sockets.SocketShutdown.Both);
            ClientSocket.clientSocket.Close();
        }
    }
}
