using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace RacingCar_Client
{
    public partial class Lobby : Form
    {
        private RichTextBox richTextBox1;
        private Button btnLeave;
        private GroupBox groupBoxP2;
        private PictureBox pictureBoxP2;
        private GroupBox groupBoxP1;
        private PictureBox pictureBoxP1;
        private Button btnStart;
        public Lobby lobby;
        public int connectedPlayer = 0;
        public static int tableIndex;
        private TextBox tbsendmsg;
        private Button btSend;
        private Label labelP2;
        private Label labelP1;
        public static int side;
        public Lobby()
        {
            InitializeComponent();          
            CheckForIllegalCrossThreadCalls = false;
            lobby = this;
            this.Load += new EventHandler(Lobby_Load); // Đăng ký sự kiện Load

        }
        private void Lobby_Load(object sender, EventArgs e)
        {
            if (side == 1)
            {
                btnStart.Text = "Ready";
            }
        }
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLeave = new System.Windows.Forms.Button();
            this.groupBoxP2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxP2 = new System.Windows.Forms.PictureBox();
            this.groupBoxP1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxP1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbsendmsg = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.groupBoxP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP2)).BeginInit();
            this.groupBoxP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(478, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(309, 308);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // btnLeave
            // 
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.Location = new System.Drawing.Point(247, 391);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(190, 66);
            this.btnLeave.TabIndex = 11;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // groupBoxP2
            // 
            this.groupBoxP2.Controls.Add(this.labelP2);
            this.groupBoxP2.Controls.Add(this.pictureBoxP2);
            this.groupBoxP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxP2.Location = new System.Drawing.Point(234, 44);
            this.groupBoxP2.Name = "groupBoxP2";
            this.groupBoxP2.Size = new System.Drawing.Size(216, 308);
            this.groupBoxP2.TabIndex = 9;
            this.groupBoxP2.TabStop = false;
            this.groupBoxP2.Text = "PLAYER 2";
            // 
            // pictureBoxP2
            // 
            this.pictureBoxP2.Location = new System.Drawing.Point(13, 59);
            this.pictureBoxP2.Name = "pictureBoxP2";
            this.pictureBoxP2.Size = new System.Drawing.Size(190, 190);
            this.pictureBoxP2.TabIndex = 2;
            this.pictureBoxP2.TabStop = false;
            // 
            // groupBoxP1
            // 
            this.groupBoxP1.Controls.Add(this.pictureBoxP1);
            this.groupBoxP1.Controls.Add(this.labelP1);
            this.groupBoxP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxP1.Location = new System.Drawing.Point(12, 44);
            this.groupBoxP1.Name = "groupBoxP1";
            this.groupBoxP1.Size = new System.Drawing.Size(216, 308);
            this.groupBoxP1.TabIndex = 7;
            this.groupBoxP1.TabStop = false;
            this.groupBoxP1.Text = "PLAYER 1";
            // 
            // pictureBoxP1
            // 
            this.pictureBoxP1.Location = new System.Drawing.Point(13, 59);
            this.pictureBoxP1.Name = "pictureBoxP1";
            this.pictureBoxP1.Size = new System.Drawing.Size(190, 190);
            this.pictureBoxP1.TabIndex = 1;
            this.pictureBoxP1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(25, 391);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(190, 66);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbsendmsg
            // 
            this.tbsendmsg.Location = new System.Drawing.Point(478, 391);
            this.tbsendmsg.Multiline = true;
            this.tbsendmsg.Name = "tbsendmsg";
            this.tbsendmsg.Size = new System.Drawing.Size(228, 64);
            this.tbsendmsg.TabIndex = 13;
            // 
            // btSend
            // 
            this.btSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.Location = new System.Drawing.Point(712, 391);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 64);
            this.btSend.TabIndex = 14;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2.Location = new System.Drawing.Point(96, 273);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(25, 22);
            this.labelP2.TabIndex = 3;
            this.labelP2.Text = "...";
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1.Location = new System.Drawing.Point(96, 273);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(25, 22);
            this.labelP1.TabIndex = 0;
            this.labelP1.Text = "...";
            // 
            // Lobby
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::RacingCar_Client.Properties.Resources.BackroundLobby;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 469);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbsendmsg);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.groupBoxP2);
            this.Controls.Add(this.groupBoxP1);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Lobby";
            this.Text = "Game Lobby";
            this.groupBoxP2.ResumeLayout(false);
            this.groupBoxP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP2)).EndInit();
            this.groupBoxP1.ResumeLayout(false);
            this.groupBoxP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
     

        public void Tempdisplay(string msg, int i)
        {
            if (i == 2)
                richTextBox1.Clear();
            richTextBox1.Text += msg + '\n';
            if (i == 0)
                richTextBox1.Clear();
        }
        public void DisplayConnectedPlayer(int i)
        {
            labelP1.Text = ThisPlayer.name[i, 0];
            labelP2.Text = ThisPlayer.name[i, 1];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string[] parts = ConnectRoom.tbLocal.Text.Split(':');
            string ipAddress = parts[0];
            int udpPort = int.Parse(parts[1]);
            ClientSocket.datatype = "START";
            ClientSocket.SendMessage(ThisPlayer.name[tableIndex,side] + ": " + " tôi đã sẵn sàng" + ";" + tableIndex + ";" + side + ";" + ipAddress + ";" + udpPort) ;
           
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            ClientSocket.datatype = "GETUP";
            ThisPlayer.name[tableIndex, side] = "...";
            ClientSocket.SendMessage(tableIndex + ";" + side + ";" + ThisPlayer.name[tableIndex, side]);
            this.Hide();         
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            ClientSocket.datatype = "TALK";
            ClientSocket.SendMessage(ThisPlayer.name[tableIndex,side] + ": " + tbsendmsg.Text + ";" + tableIndex + ";" + side);
            Tempdisplay("Me:" + tbsendmsg.Text, 1);
        } 
    }
}
