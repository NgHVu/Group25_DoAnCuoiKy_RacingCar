using RacingCar_Client.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Threading;

namespace RacingCar_Client
{
    public partial class GamePlay : Form
    {
        private System.Windows.Forms.Timer timer1;
        private Player1 player1;
        private Player2 player2;
        private Image carImagePlayer1; // Hình ảnh của xe đua cho người chơi 1
        private Image carImagePlayer2; // Hình ảnh của xe đua cho người chơi 2
        private Image rotatedCarImagePlayer1; // Hình ảnh của xe đua quay theo hướng di chuyển cho người chơi 1
        private Image rotatedCarImagePlayer2; // Hình ảnh của xe đua quay theo hướng di chuyển cho người chơi 2
        private Image backgroundImage;
        private System.ComponentModel.IContainer components;
        private string player1Name;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox pictureBox30;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private PictureBox pictureBox33;
        private PictureBox pictureBox34;
        private PictureBox pictureBox35;
        private PictureBox pictureBox36;
        private PictureBox pictureBox37;
        private PictureBox pictureBox38;
        private PictureBox pictureBox39;
        private PictureBox pictureBox40;
        private PictureBox pictureBox41;
        private PictureBox pictureBox42;
        private PictureBox pictureBox43;
        private PictureBox pictureBox44;
        private PictureBox pictureBox45;
        private PictureBox pictureBox46;
        private PictureBox pictureBox47;
        private PictureBox pictureBox48;
        private PictureBox pictureBox49;
        private PictureBox pictureBox50;
        private PictureBox pictureBox51;
        private PictureBox pictureBox52;
        private PictureBox pictureBox53;
        private PictureBox pictureBox54;
        private PictureBox pictureBox55;
        private PictureBox pictureBox56;
        private PictureBox pictureBox57;
        private PictureBox pictureBox58;
        private PictureBox pictureBox59;
        private PictureBox pictureBox60;
        private PictureBox pictureBox61;
        private PictureBox pictureBox62;
        private PictureBox pictureBox63;
        private PictureBox pictureBox64;
        private PictureBox pictureBox65;
        private PictureBox pictureBox66;
        private PictureBox pictureBox67;
        private PictureBox pictureBox68;
        private PictureBox pictureBox69;
        private PictureBox pictureBox1;
        private string player2Name;
        public static int tableIndex;
        public static int side;
        public static string ipadress;
        public static int udpPort;
        public static string move;
        private UdpClient uc; //The udp object that sends the data
        private UdpClient _uc; //The upd object that receives the data
        private IPEndPoint sendEndPoint; // The endpoint to send data to
        private IPEndPoint receiveEndPoint; // The endpoint to receive data from
        private Thread receiveThread; // Thread for receiving data
        private bool isRunning = true;
        public GamePlay()
        {
            InitializeComponent();
            InitializeGame();
            InitializePlayers();
            InitializeTimer();
            InitializeEventHandlers();
            LoadImage();
            InitializeUDP();

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.pictureBox64 = new System.Windows.Forms.PictureBox();
            this.pictureBox65 = new System.Windows.Forms.PictureBox();
            this.pictureBox66 = new System.Windows.Forms.PictureBox();
            this.pictureBox67 = new System.Windows.Forms.PictureBox();
            this.pictureBox68 = new System.Windows.Forms.PictureBox();
            this.pictureBox69 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox3.Location = new System.Drawing.Point(220, 244);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(713, 10);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox2.Location = new System.Drawing.Point(213, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(883, 10);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox4.Location = new System.Drawing.Point(203, 124);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 125);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox5.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox5.Location = new System.Drawing.Point(1099, 129);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 382);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox6.Location = new System.Drawing.Point(195, 516);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(901, 8);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox7.Location = new System.Drawing.Point(195, 496);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(725, 6);
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox8.Location = new System.Drawing.Point(138, 631);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1016, 9);
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox9.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox9.Location = new System.Drawing.Point(1272, 105);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(10, 434);
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox10.Location = new System.Drawing.Point(168, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(964, 9);
            this.pictureBox10.TabIndex = 12;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox11.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox11.Location = new System.Drawing.Point(28, 95);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(10, 175);
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.White;
            this.pictureBox12.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox12.Location = new System.Drawing.Point(153, 361);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(725, 6);
            this.pictureBox12.TabIndex = 14;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.White;
            this.pictureBox13.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox13.Location = new System.Drawing.Point(153, 384);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(725, 6);
            this.pictureBox13.TabIndex = 15;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox14.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox14.Location = new System.Drawing.Point(11, 478);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(10, 76);
            this.pictureBox14.TabIndex = 16;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox15.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox15.Location = new System.Drawing.Point(28, 560);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(10, 10);
            this.pictureBox15.TabIndex = 17;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox16.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox16.Location = new System.Drawing.Point(38, 576);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(10, 10);
            this.pictureBox16.TabIndex = 18;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox17.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox17.Location = new System.Drawing.Point(50, 587);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(10, 10);
            this.pictureBox17.TabIndex = 19;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox18.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox18.Location = new System.Drawing.Point(125, 623);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(10, 10);
            this.pictureBox18.TabIndex = 20;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox19.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox19.Location = new System.Drawing.Point(109, 617);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(10, 10);
            this.pictureBox19.TabIndex = 21;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox20.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox20.Location = new System.Drawing.Point(66, 597);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(10, 10);
            this.pictureBox20.TabIndex = 22;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox21.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox21.Location = new System.Drawing.Point(82, 607);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(10, 10);
            this.pictureBox21.TabIndex = 23;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox22.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox22.Location = new System.Drawing.Point(93, 612);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(10, 10);
            this.pictureBox22.TabIndex = 24;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox23.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox23.Location = new System.Drawing.Point(125, 387);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(10, 10);
            this.pictureBox23.TabIndex = 25;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox24.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox24.Location = new System.Drawing.Point(93, 397);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(10, 10);
            this.pictureBox24.TabIndex = 26;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox25.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox25.Location = new System.Drawing.Point(50, 422);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(10, 10);
            this.pictureBox25.TabIndex = 27;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox26.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox26.Location = new System.Drawing.Point(66, 411);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(10, 10);
            this.pictureBox26.TabIndex = 28;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox27.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox27.Location = new System.Drawing.Point(28, 447);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(10, 10);
            this.pictureBox27.TabIndex = 29;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox28.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox28.Location = new System.Drawing.Point(38, 433);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(10, 10);
            this.pictureBox28.TabIndex = 30;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox29.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox29.Location = new System.Drawing.Point(103, 339);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(10, 10);
            this.pictureBox29.TabIndex = 38;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox30.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox30.Location = new System.Drawing.Point(92, 334);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(10, 10);
            this.pictureBox30.TabIndex = 37;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox31.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox31.Location = new System.Drawing.Point(76, 324);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(10, 10);
            this.pictureBox31.TabIndex = 36;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox32.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox32.Location = new System.Drawing.Point(119, 347);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(10, 10);
            this.pictureBox32.TabIndex = 35;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox33.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox33.Location = new System.Drawing.Point(135, 353);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(10, 10);
            this.pictureBox33.TabIndex = 34;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox34.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox34.Location = new System.Drawing.Point(60, 314);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(10, 10);
            this.pictureBox34.TabIndex = 33;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox35.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox35.Location = new System.Drawing.Point(48, 303);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(10, 10);
            this.pictureBox35.TabIndex = 32;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox36.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox36.Location = new System.Drawing.Point(38, 287);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(10, 10);
            this.pictureBox36.TabIndex = 31;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox37.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox37.Location = new System.Drawing.Point(54, 57);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(10, 10);
            this.pictureBox37.TabIndex = 44;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox38.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox38.Location = new System.Drawing.Point(44, 71);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(10, 10);
            this.pictureBox38.TabIndex = 43;
            this.pictureBox38.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox39.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox39.Location = new System.Drawing.Point(82, 35);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(10, 10);
            this.pictureBox39.TabIndex = 42;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox40.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox40.Location = new System.Drawing.Point(66, 46);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(10, 10);
            this.pictureBox40.TabIndex = 41;
            this.pictureBox40.TabStop = false;
            // 
            // pictureBox41
            // 
            this.pictureBox41.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox41.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox41.Location = new System.Drawing.Point(109, 21);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(10, 10);
            this.pictureBox41.TabIndex = 40;
            this.pictureBox41.TabStop = false;
            // 
            // pictureBox42
            // 
            this.pictureBox42.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox42.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox42.Location = new System.Drawing.Point(141, 11);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(10, 10);
            this.pictureBox42.TabIndex = 39;
            this.pictureBox42.TabStop = false;
            // 
            // pictureBox43
            // 
            this.pictureBox43.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox43.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox43.Location = new System.Drawing.Point(935, 492);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(10, 10);
            this.pictureBox43.TabIndex = 45;
            this.pictureBox43.TabStop = false;
            // 
            // pictureBox44
            // 
            this.pictureBox44.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox44.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox44.Location = new System.Drawing.Point(1057, 339);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(10, 68);
            this.pictureBox44.TabIndex = 46;
            this.pictureBox44.TabStop = false;
            // 
            // pictureBox45
            // 
            this.pictureBox45.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox45.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox45.Location = new System.Drawing.Point(1045, 422);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(10, 10);
            this.pictureBox45.TabIndex = 47;
            this.pictureBox45.TabStop = false;
            // 
            // pictureBox46
            // 
            this.pictureBox46.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox46.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox46.Location = new System.Drawing.Point(1035, 438);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(10, 10);
            this.pictureBox46.TabIndex = 48;
            this.pictureBox46.TabStop = false;
            // 
            // pictureBox47
            // 
            this.pictureBox47.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox47.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox47.Location = new System.Drawing.Point(1018, 456);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(10, 10);
            this.pictureBox47.TabIndex = 49;
            this.pictureBox47.TabStop = false;
            // 
            // pictureBox48
            // 
            this.pictureBox48.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox48.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox48.Location = new System.Drawing.Point(1002, 466);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(10, 10);
            this.pictureBox48.TabIndex = 50;
            this.pictureBox48.TabStop = false;
            // 
            // pictureBox49
            // 
            this.pictureBox49.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox49.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox49.Location = new System.Drawing.Point(977, 478);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(10, 10);
            this.pictureBox49.TabIndex = 51;
            this.pictureBox49.TabStop = false;
            // 
            // pictureBox50
            // 
            this.pictureBox50.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox50.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox50.Location = new System.Drawing.Point(952, 486);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(10, 10);
            this.pictureBox50.TabIndex = 52;
            this.pictureBox50.TabStop = false;
            // 
            // pictureBox51
            // 
            this.pictureBox51.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox51.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox51.Location = new System.Drawing.Point(1045, 314);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(10, 10);
            this.pictureBox51.TabIndex = 53;
            this.pictureBox51.TabStop = false;
            // 
            // pictureBox52
            // 
            this.pictureBox52.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox52.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox52.Location = new System.Drawing.Point(1035, 303);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(10, 10);
            this.pictureBox52.TabIndex = 54;
            this.pictureBox52.TabStop = false;
            // 
            // pictureBox53
            // 
            this.pictureBox53.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox53.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox53.Location = new System.Drawing.Point(1018, 287);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(10, 10);
            this.pictureBox53.TabIndex = 55;
            this.pictureBox53.TabStop = false;
            // 
            // pictureBox54
            // 
            this.pictureBox54.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox54.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox54.Location = new System.Drawing.Point(1002, 277);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(10, 10);
            this.pictureBox54.TabIndex = 56;
            this.pictureBox54.TabStop = false;
            // 
            // pictureBox55
            // 
            this.pictureBox55.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox55.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox55.Location = new System.Drawing.Point(977, 264);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(10, 10);
            this.pictureBox55.TabIndex = 57;
            this.pictureBox55.TabStop = false;
            // 
            // pictureBox56
            // 
            this.pictureBox56.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox56.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox56.Location = new System.Drawing.Point(952, 254);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(10, 10);
            this.pictureBox56.TabIndex = 58;
            this.pictureBox56.TabStop = false;
            // 
            // pictureBox57
            // 
            this.pictureBox57.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox57.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox57.Location = new System.Drawing.Point(1173, 618);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(10, 10);
            this.pictureBox57.TabIndex = 65;
            this.pictureBox57.TabStop = false;
            // 
            // pictureBox58
            // 
            this.pictureBox58.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox58.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox58.Location = new System.Drawing.Point(1198, 609);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(10, 10);
            this.pictureBox58.TabIndex = 64;
            this.pictureBox58.TabStop = false;
            // 
            // pictureBox59
            // 
            this.pictureBox59.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox59.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox59.Location = new System.Drawing.Point(1223, 595);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(10, 10);
            this.pictureBox59.TabIndex = 63;
            this.pictureBox59.TabStop = false;
            // 
            // pictureBox60
            // 
            this.pictureBox60.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox60.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox60.Location = new System.Drawing.Point(1239, 580);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(10, 10);
            this.pictureBox60.TabIndex = 62;
            this.pictureBox60.TabStop = false;
            // 
            // pictureBox61
            // 
            this.pictureBox61.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox61.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox61.Location = new System.Drawing.Point(1256, 562);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(10, 10);
            this.pictureBox61.TabIndex = 61;
            this.pictureBox61.TabStop = false;
            // 
            // pictureBox62
            // 
            this.pictureBox62.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox62.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox62.Location = new System.Drawing.Point(1266, 544);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(10, 10);
            this.pictureBox62.TabIndex = 60;
            this.pictureBox62.TabStop = false;
            // 
            // pictureBox63
            // 
            this.pictureBox63.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox63.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox63.Location = new System.Drawing.Point(1156, 624);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(10, 10);
            this.pictureBox63.TabIndex = 59;
            this.pictureBox63.TabStop = false;
            // 
            // pictureBox64
            // 
            this.pictureBox64.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox64.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox64.Location = new System.Drawing.Point(1164, 12);
            this.pictureBox64.Name = "pictureBox64";
            this.pictureBox64.Size = new System.Drawing.Size(10, 10);
            this.pictureBox64.TabIndex = 71;
            this.pictureBox64.TabStop = false;
            // 
            // pictureBox65
            // 
            this.pictureBox65.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox65.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox65.Location = new System.Drawing.Point(1189, 22);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(10, 10);
            this.pictureBox65.TabIndex = 70;
            this.pictureBox65.TabStop = false;
            // 
            // pictureBox66
            // 
            this.pictureBox66.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox66.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox66.Location = new System.Drawing.Point(1214, 35);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(10, 10);
            this.pictureBox66.TabIndex = 69;
            this.pictureBox66.TabStop = false;
            // 
            // pictureBox67
            // 
            this.pictureBox67.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox67.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox67.Location = new System.Drawing.Point(1230, 45);
            this.pictureBox67.Name = "pictureBox67";
            this.pictureBox67.Size = new System.Drawing.Size(10, 10);
            this.pictureBox67.TabIndex = 68;
            this.pictureBox67.TabStop = false;
            // 
            // pictureBox68
            // 
            this.pictureBox68.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox68.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox68.Location = new System.Drawing.Point(1247, 61);
            this.pictureBox68.Name = "pictureBox68";
            this.pictureBox68.Size = new System.Drawing.Size(10, 10);
            this.pictureBox68.TabIndex = 67;
            this.pictureBox68.TabStop = false;
            // 
            // pictureBox69
            // 
            this.pictureBox69.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox69.BackgroundImage = global::RacingCar_Client.Properties.Resources._1__2_1;
            this.pictureBox69.Location = new System.Drawing.Point(1257, 72);
            this.pictureBox69.Name = "pictureBox69";
            this.pictureBox69.Size = new System.Drawing.Size(10, 10);
            this.pictureBox69.TabIndex = 66;
            this.pictureBox69.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RacingCar_Client.Properties.Resources.Map1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1311, 649);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePlay_Paint);
            // 
            // GamePlay
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1311, 649);
            this.Controls.Add(this.pictureBox64);
            this.Controls.Add(this.pictureBox65);
            this.Controls.Add(this.pictureBox66);
            this.Controls.Add(this.pictureBox67);
            this.Controls.Add(this.pictureBox68);
            this.Controls.Add(this.pictureBox69);
            this.Controls.Add(this.pictureBox57);
            this.Controls.Add(this.pictureBox58);
            this.Controls.Add(this.pictureBox59);
            this.Controls.Add(this.pictureBox60);
            this.Controls.Add(this.pictureBox61);
            this.Controls.Add(this.pictureBox62);
            this.Controls.Add(this.pictureBox63);
            this.Controls.Add(this.pictureBox56);
            this.Controls.Add(this.pictureBox55);
            this.Controls.Add(this.pictureBox54);
            this.Controls.Add(this.pictureBox53);
            this.Controls.Add(this.pictureBox52);
            this.Controls.Add(this.pictureBox51);
            this.Controls.Add(this.pictureBox50);
            this.Controls.Add(this.pictureBox49);
            this.Controls.Add(this.pictureBox48);
            this.Controls.Add(this.pictureBox47);
            this.Controls.Add(this.pictureBox46);
            this.Controls.Add(this.pictureBox45);
            this.Controls.Add(this.pictureBox44);
            this.Controls.Add(this.pictureBox43);
            this.Controls.Add(this.pictureBox37);
            this.Controls.Add(this.pictureBox38);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.pictureBox40);
            this.Controls.Add(this.pictureBox41);
            this.Controls.Add(this.pictureBox42);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox33);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "GamePlay";
            this.Text = "GAME PLAY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GamePlay_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePlay_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GamePlay_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private void InitializeUDP()
        {
            try
            {
                // Kiểm tra xem ConnectRoom.tbLocal có null không
                if (ConnectRoom.tbLocal == null)
                {
                    MessageBox.Show("ConnectRoom.tbLocal is null.");
                    return;
                }

                // Kiểm tra xem ConnectRoom.tbLocal.Text có null hoặc rỗng không
                if (string.IsNullOrEmpty(ConnectRoom.tbLocal.Text))
                {
                    MessageBox.Show("ConnectRoom.tbLocal.Text is null or empty.");
                    return;
                }

                string[] parts = ConnectRoom.tbLocal.Text.Split(':');
                if (parts.Length != 2)
                {
                    MessageBox.Show("Invalid IP address or port format.");
                    return;
                }

                string ipAddress_ = parts[0];
                int udpPort_;
                if (!int.TryParse(parts[1], out udpPort_))
                {
                    MessageBox.Show("Invalid port number.");
                    return;
                }

                // Kiểm tra xem địa chỉ IP có hợp lệ không
                IPAddress ip;
                if (!IPAddress.TryParse(ipAddress_, out ip))
                {
                    MessageBox.Show("Invalid IP address.");
                    return;
                }

                // Initialize the send endpoint
                sendEndPoint = new IPEndPoint(ip, udpPort_);

                // Initialize the receive endpoint
                receiveEndPoint = new IPEndPoint(IPAddress.Any, udpPort_);

                // Create the UdpClient for sending
                uc = new UdpClient();
                if (uc == null)
                {
                    MessageBox.Show("Failed to create UdpClient for sending.");
                    return;
                }

                // Create the UdpClient for receiving
                _uc = new UdpClient(receiveEndPoint);
                if (_uc == null)
                {
                    MessageBox.Show("Failed to create UdpClient for receiving.");
                    return;
                }

                // Start the receive thread
                receiveThread = new Thread(new ThreadStart(ReceiveData));
                if (receiveThread == null)
                {
                    MessageBox.Show("Failed to create receive thread.");
                    return;
                }

                receiveThread.IsBackground = true;
                receiveThread.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("UDP initialization error: " + ex.Message);
            }
        }

        private void ReceiveData()
        {
            while (isRunning)
            {
                try
                {
                    byte[] receivedBytes = _uc.Receive(ref receiveEndPoint);
                    string receivedMessage = Encoding.UTF8.GetString(receivedBytes);
                    HandleMoveData(receivedMessage);
                }
                catch (Exception ex)
                {
                    if (isRunning) // Kiểm tra nếu chương trình vẫn đang chạy
                    {
                        MessageBox.Show("Receive error: " + ex.Message);
                    }
                }
            }
        }
        private void HandleMoveData(string moveData)
        {
            Keys keyPressed = Keys.None;

            switch (moveData.ToUpper())
            {
                case "W":
                    keyPressed = Keys.W;
                    break;
                case "A":
                    keyPressed = Keys.A;
                    break;
                case "S":
                    keyPressed = Keys.S;
                    break;
                case "D":
                    keyPressed = Keys.D;
                    break;
                case "UP":
                    keyPressed = Keys.Up;
                    break;
                case "DOWN":
                    keyPressed = Keys.Down;
                    break;
                case "LEFT":
                    keyPressed = Keys.Left;
                    break;
                case "RIGHT":
                    keyPressed = Keys.Right;
                    break;
                default:
                    break;
            }   
            player1.SetKeyDown(keyPressed);
            player2.SetKeyDown(keyPressed);
        }
        private void InitializeEventHandlers()
        {
            // Liên kết sự kiện KeyDown và KeyUp của Form với các phương thức của Player1 và Player2
            this.KeyDown += GamePlay_KeyDown;
            this.KeyUp += GamePlay_KeyUp;
        }
        private void GamePlay_KeyDown(object sender, KeyEventArgs e)
        {
            // Gọi SetKeyDown của Player1 hoặc Player2 tùy thuộc vào phím được nhấn
            player1.SetKeyDown(e.KeyCode);
            player2.SetKeyDown(e.KeyCode);
            SendData(e.KeyCode.ToString());
        }


        private void GamePlay_KeyUp(object sender, KeyEventArgs e)
        {
            // Gọi SetKeyUp của Player1 hoặc Player2 tùy thuộc vào phím được nhấn
            player1.SetKeyUp(e.KeyCode);
            player2.SetKeyUp(e.KeyCode);

        }

        private void SendData(string message)
        {
            try
            {
                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                uc.Send(messageBytes, messageBytes.Length, sendEndPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Send error: " + ex.Message);
            }
        }
        private void DisconnectUDP()
        {
            try
            {
                // Dừng vòng lặp nhận dữ liệu
                isRunning = false;
                receiveThread.Join();
                // Đóng đối tượng UdpClient
                if (uc != null)
                {
                    uc.Close();
                    uc = null;
                }

                if (_uc != null)
                {
                    _uc.Close();
                    _uc = null;
                }

                // Giai phóng luồng nhận dữ liệu
                if (receiveThread != null)
                {
                    receiveThread.Join();
                    receiveThread = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Disconnect error: " + ex.Message);
            }
        }

        // Sự kiện khi form đóng
        private void GamePlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectUDP(); // Ngắt kết nối UDP khi form đóng
        }
        private void InitializeGame()
        {
            // Khởi tạo số lượng người chơi và các biến liên quan
            //  int playerCount = 2;
            //   cameras = new Camera[playerCount];

        }
        private void InitializePlayers()
        {
            player1 = new Player1();
            player1.Position = new PointF(594, 540); // Tọa độ ban đầu cho người chơi 1
            player1.Size = new Size(37, 37); // Kích thước của xe đua cho người chơi 1
            player2 = new Player2();
            player2.Position = new PointF(594, 577); // Tọa độ ban đầu cho người chơi 2
            player2.Size = new Size(37, 37); // Kích thước của xe đua cho người chơi 2
            // Gắn sự kiện KeyDown và KeyUp của Form với các phương thức của Player1 và Player2
            player1.AttachInputEvents(this);
            player2.AttachInputEvents(this);
        }
        private void LoadImage()
        {
            // Tải hình ảnh của xe đua từ tập tin cho mỗi người chơi
            carImagePlayer1 = Properties.Resources.YellowCar;
            carImagePlayer2 = Properties.Resources.RedCar;
            // Xác định hình ảnh quay cho hình ảnh xe đua của người chơi 1 và 2
            rotatedCarImagePlayer1 = RotateImage(carImagePlayer1, 0); // 0 là góc ban đầu
            rotatedCarImagePlayer2 = RotateImage(carImagePlayer2, 0); // 0 là góc ban đầu
        }

        private void GamePlay_Paint(object sender, PaintEventArgs e)
        {
            // Vẽ hình ảnh xe đua cho mỗi người chơi
            e.Graphics.DrawImage(rotatedCarImagePlayer1, player1.Position.X, player1.Position.Y, player1.Size.Width, player1.Size.Height);
            e.Graphics.DrawImage(rotatedCarImagePlayer2, player2.Position.X, player2.Position.Y, player2.Size.Width, player2.Size.Height);
        }

        private Image RotateImage(Image image, float angle)
        {
            // Tính toán kích thước mới của hình ảnh sau khi quay
            double radians = angle * Math.PI / 180;
            double sin = Math.Abs(Math.Sin(radians));
            double cos = Math.Abs(Math.Cos(radians));

            int newWidth = (int)(image.Width * cos + image.Height * sin);
            int newHeight = (int)(image.Width * sin + image.Height * cos);

            Bitmap rotatedImage = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Dịch chuyển tâm của hình ảnh tới tâm của hình
                g.TranslateTransform(newWidth / 2, newHeight / 2);
                g.RotateTransform(angle); // Xoay hình ảnh
                g.TranslateTransform(-image.Width / 2, -image.Height / 2); // Dịch chuyển trở lại vị trí ban đầu
                g.DrawImage(image, 0, 0); // Vẽ hình ảnh đã xoay
            }

            return rotatedImage;
        }
        private void InitializeTimer()
        {
            // Khởi tạo timer
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 16; // Khoảng thời gian mỗi frame
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
    
        
        private void timer1_Tick(object sender, EventArgs e)
        {// Xử lý phím di chuyển từ người chơi và gửi tín hiệu cho server
            player1.ProcessInput(0.016f);
            player2.ProcessInput(0.016f);           
            // Di chuyển các xe đua
            player1.Move(0.016f, PointF.Empty); // Đặt dt thành một giá trị cố định (ví dụ: 0.016) cho mỗi frame
            player2.Move(0.016f, PointF.Empty);
            CheckCollisions();
            // Cập nhật hình ảnh quay của xe đua dựa trên hướng di chuyển
            rotatedCarImagePlayer1 = RotateImage(carImagePlayer1, player1.Angle * (180 / (float)Math.PI)); // Chuyển đổi góc quay từ radian sang độ
            rotatedCarImagePlayer2 = RotateImage(carImagePlayer2, player2.Angle * (180 / (float)Math.PI)); // Chuyển đổi góc quay từ radian sang độ            
            pictureBox1.Invalidate();
        }
        private void CheckCollisions()
        {
            // Kiểm tra va chạm cho xe đua của người chơi 1
            if (IsCollidingWithBoundary(player1))
            {
                // Xử lí va chạm logic cho xe đua của người chơi 1: dừng xe
                player1.Stop(100f);
            }
            // Kiểm tra va chạm cho xe đua của người chơi 2
            if (IsCollidingWithBoundary(player2))
            {
                // Xử lí va chạm logic cho xe đua của người chơi 2: dừng xe
                player2.Stop(100f);
            }
        }
        private bool IsCollidingWithBoundary(RaceCar car)
        {
            // Duyệt qua các PictureBox từ 2 đến 69
            for (int i = 2; i <= 69; i++)
            {
                // Tạo tên của PictureBox dựa trên số thứ tự
                string pictureBoxName = "pictureBox" + i;

                // Tìm PictureBox trong Controls của Form bằng tên
                PictureBox pictureBox = Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;

                if (pictureBox != null)
                {
                    // Lấy các giới hạn của xe đua và ranh giới
                    RectangleF carBounds = new RectangleF(car.Position, car.Size);
                    //  RectangleF pictureBoxBounds = new RectangleF(pictureBox.Location, pictureBox.Size);

                    // Kiểm tra va chạm giữa xe đua và ranh giới
                    if (carBounds.IntersectsWith(pictureBox.Bounds))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}   