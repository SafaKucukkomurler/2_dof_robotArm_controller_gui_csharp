
namespace robotArmControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_comPort = new System.Windows.Forms.ComboBox();
            this.bt_comPortConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_arm2_left = new System.Windows.Forms.Button();
            this.bt_arm2_right = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_gripperDown = new System.Windows.Forms.Button();
            this.bt_gripperUp = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_arm1_left = new System.Windows.Forms.Button();
            this.bt_arm1_right = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_distance = new System.Windows.Forms.TextBox();
            this.bt_gripper_setZero = new System.Windows.Forms.Button();
            this.rb_distanceManual = new System.Windows.Forms.RadioButton();
            this.rb_distanceHundered = new System.Windows.Forms.RadioButton();
            this.rb_distanceFifty = new System.Windows.Forms.RadioButton();
            this.rb_distanceTen = new System.Windows.Forms.RadioButton();
            this.rb_distanceOne = new System.Windows.Forms.RadioButton();
            this.ComPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bt_servoPitch_down = new System.Windows.Forms.Button();
            this.bt_servoPitch_up = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.bt_servoRoll_left = new System.Windows.Forms.Button();
            this.bt_servoRoll_right = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_Z = new System.Windows.Forms.Label();
            this.label_teta1 = new System.Windows.Forms.Label();
            this.label_teta0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_fileOpen = new System.Windows.Forms.Button();
            this.bt_send_work = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_comPort);
            this.groupBox1.Controls.Add(this.bt_comPortConnect);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seri Haberleşme";
            // 
            // cb_comPort
            // 
            this.cb_comPort.FormattingEnabled = true;
            this.cb_comPort.ItemHeight = 15;
            this.cb_comPort.Location = new System.Drawing.Point(17, 30);
            this.cb_comPort.Name = "cb_comPort";
            this.cb_comPort.Size = new System.Drawing.Size(121, 23);
            this.cb_comPort.TabIndex = 1;
            this.cb_comPort.Click += new System.EventHandler(this.cb_comPort_Click);
            // 
            // bt_comPortConnect
            // 
            this.bt_comPortConnect.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_comPortConnect.Location = new System.Drawing.Point(147, 26);
            this.bt_comPortConnect.Name = "bt_comPortConnect";
            this.bt_comPortConnect.Size = new System.Drawing.Size(86, 30);
            this.bt_comPortConnect.TabIndex = 0;
            this.bt_comPortConnect.Text = "Bağlan";
            this.bt_comPortConnect.UseVisualStyleBackColor = true;
            this.bt_comPortConnect.Click += new System.EventHandler(this.bt_comPortConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_arm2_left);
            this.groupBox2.Controls.Add(this.bt_arm2_right);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(371, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kol Motor 2";
            // 
            // bt_arm2_left
            // 
            this.bt_arm2_left.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_arm2_left.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_arm2_left.Location = new System.Drawing.Point(11, 103);
            this.bt_arm2_left.Name = "bt_arm2_left";
            this.bt_arm2_left.Size = new System.Drawing.Size(69, 47);
            this.bt_arm2_left.TabIndex = 0;
            this.bt_arm2_left.Text = "Sola Dönüş";
            this.bt_arm2_left.UseVisualStyleBackColor = false;
            this.bt_arm2_left.Click += new System.EventHandler(this.bt_arm2_left_Click);
            // 
            // bt_arm2_right
            // 
            this.bt_arm2_right.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_arm2_right.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_arm2_right.Location = new System.Drawing.Point(11, 29);
            this.bt_arm2_right.Name = "bt_arm2_right";
            this.bt_arm2_right.Size = new System.Drawing.Size(69, 47);
            this.bt_arm2_right.TabIndex = 0;
            this.bt_arm2_right.Text = "Sağa Dönüş";
            this.bt_arm2_right.UseVisualStyleBackColor = false;
            this.bt_arm2_right.Click += new System.EventHandler(this.bt_arm2_right_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_gripperDown);
            this.groupBox3.Controls.Add(this.bt_gripperUp);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(275, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 167);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Z Motor";
            // 
            // bt_gripperDown
            // 
            this.bt_gripperDown.BackColor = System.Drawing.Color.Sienna;
            this.bt_gripperDown.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_gripperDown.Location = new System.Drawing.Point(12, 103);
            this.bt_gripperDown.Name = "bt_gripperDown";
            this.bt_gripperDown.Size = new System.Drawing.Size(69, 47);
            this.bt_gripperDown.TabIndex = 0;
            this.bt_gripperDown.Text = "Aşağı";
            this.bt_gripperDown.UseVisualStyleBackColor = false;
            this.bt_gripperDown.Click += new System.EventHandler(this.bt_gripperDown_Click);
            // 
            // bt_gripperUp
            // 
            this.bt_gripperUp.BackColor = System.Drawing.Color.Sienna;
            this.bt_gripperUp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_gripperUp.Location = new System.Drawing.Point(12, 29);
            this.bt_gripperUp.Name = "bt_gripperUp";
            this.bt_gripperUp.Size = new System.Drawing.Size(69, 47);
            this.bt_gripperUp.TabIndex = 0;
            this.bt_gripperUp.Text = "Yukarı";
            this.bt_gripperUp.UseVisualStyleBackColor = false;
            this.bt_gripperUp.Click += new System.EventHandler(this.bt_gripperUp_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_arm1_left);
            this.groupBox4.Controls.Add(this.bt_arm1_right);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(467, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(90, 167);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kol Motor 1";
            // 
            // bt_arm1_left
            // 
            this.bt_arm1_left.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_arm1_left.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_arm1_left.Location = new System.Drawing.Point(11, 103);
            this.bt_arm1_left.Name = "bt_arm1_left";
            this.bt_arm1_left.Size = new System.Drawing.Size(69, 47);
            this.bt_arm1_left.TabIndex = 0;
            this.bt_arm1_left.Text = "Sola Dönüş";
            this.bt_arm1_left.UseVisualStyleBackColor = false;
            this.bt_arm1_left.Click += new System.EventHandler(this.bt_arm1_left_Click);
            // 
            // bt_arm1_right
            // 
            this.bt_arm1_right.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_arm1_right.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_arm1_right.Location = new System.Drawing.Point(11, 29);
            this.bt_arm1_right.Name = "bt_arm1_right";
            this.bt_arm1_right.Size = new System.Drawing.Size(69, 47);
            this.bt_arm1_right.TabIndex = 0;
            this.bt_arm1_right.Text = "Sağa Dönüş";
            this.bt_arm1_right.UseVisualStyleBackColor = false;
            this.bt_arm1_right.Click += new System.EventHandler(this.bt_arm1_right_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_distance);
            this.groupBox5.Controls.Add(this.bt_gripper_setZero);
            this.groupBox5.Controls.Add(this.rb_distanceManual);
            this.groupBox5.Controls.Add(this.rb_distanceHundered);
            this.groupBox5.Controls.Add(this.rb_distanceFifty);
            this.groupBox5.Controls.Add(this.rb_distanceTen);
            this.groupBox5.Controls.Add(this.rb_distanceOne);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(12, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 137);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mesafe";
            // 
            // tb_distance
            // 
            this.tb_distance.Location = new System.Drawing.Point(38, 47);
            this.tb_distance.Name = "tb_distance";
            this.tb_distance.Size = new System.Drawing.Size(100, 21);
            this.tb_distance.TabIndex = 3;
            // 
            // bt_gripper_setZero
            // 
            this.bt_gripper_setZero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_gripper_setZero.Location = new System.Drawing.Point(17, 78);
            this.bt_gripper_setZero.Name = "bt_gripper_setZero";
            this.bt_gripper_setZero.Size = new System.Drawing.Size(205, 49);
            this.bt_gripper_setZero.TabIndex = 0;
            this.bt_gripper_setZero.Text = "Gripper Referans Noktası Belirle";
            this.bt_gripper_setZero.UseVisualStyleBackColor = true;
            this.bt_gripper_setZero.Click += new System.EventHandler(this.bt_gripper_setZero_Click);
            // 
            // rb_distanceManual
            // 
            this.rb_distanceManual.AutoSize = true;
            this.rb_distanceManual.Location = new System.Drawing.Point(147, 49);
            this.rb_distanceManual.Name = "rb_distanceManual";
            this.rb_distanceManual.Size = new System.Drawing.Size(46, 19);
            this.rb_distanceManual.TabIndex = 2;
            this.rb_distanceManual.TabStop = true;
            this.rb_distanceManual.Text = "Elle";
            this.rb_distanceManual.UseVisualStyleBackColor = true;
            // 
            // rb_distanceHundered
            // 
            this.rb_distanceHundered.AutoSize = true;
            this.rb_distanceHundered.Location = new System.Drawing.Point(187, 20);
            this.rb_distanceHundered.Name = "rb_distanceHundered";
            this.rb_distanceHundered.Size = new System.Drawing.Size(46, 19);
            this.rb_distanceHundered.TabIndex = 2;
            this.rb_distanceHundered.TabStop = true;
            this.rb_distanceHundered.Text = "100";
            this.rb_distanceHundered.UseVisualStyleBackColor = true;
            // 
            // rb_distanceFifty
            // 
            this.rb_distanceFifty.AutoSize = true;
            this.rb_distanceFifty.Location = new System.Drawing.Point(136, 20);
            this.rb_distanceFifty.Name = "rb_distanceFifty";
            this.rb_distanceFifty.Size = new System.Drawing.Size(39, 19);
            this.rb_distanceFifty.TabIndex = 1;
            this.rb_distanceFifty.TabStop = true;
            this.rb_distanceFifty.Text = "50";
            this.rb_distanceFifty.UseVisualStyleBackColor = true;
            // 
            // rb_distanceTen
            // 
            this.rb_distanceTen.AutoSize = true;
            this.rb_distanceTen.Location = new System.Drawing.Point(71, 21);
            this.rb_distanceTen.Name = "rb_distanceTen";
            this.rb_distanceTen.Size = new System.Drawing.Size(39, 19);
            this.rb_distanceTen.TabIndex = 1;
            this.rb_distanceTen.TabStop = true;
            this.rb_distanceTen.Text = "10";
            this.rb_distanceTen.UseVisualStyleBackColor = true;
            // 
            // rb_distanceOne
            // 
            this.rb_distanceOne.AutoSize = true;
            this.rb_distanceOne.Location = new System.Drawing.Point(17, 21);
            this.rb_distanceOne.Name = "rb_distanceOne";
            this.rb_distanceOne.Size = new System.Drawing.Size(32, 19);
            this.rb_distanceOne.TabIndex = 0;
            this.rb_distanceOne.Text = "1";
            this.rb_distanceOne.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bt_servoPitch_down);
            this.groupBox6.Controls.Add(this.bt_servoPitch_up);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(563, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(90, 167);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Servo Dikilme";
            // 
            // bt_servoPitch_down
            // 
            this.bt_servoPitch_down.BackColor = System.Drawing.Color.DarkKhaki;
            this.bt_servoPitch_down.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_servoPitch_down.Location = new System.Drawing.Point(11, 103);
            this.bt_servoPitch_down.Name = "bt_servoPitch_down";
            this.bt_servoPitch_down.Size = new System.Drawing.Size(69, 47);
            this.bt_servoPitch_down.TabIndex = 0;
            this.bt_servoPitch_down.Text = "Aşağı";
            this.bt_servoPitch_down.UseVisualStyleBackColor = false;
            // 
            // bt_servoPitch_up
            // 
            this.bt_servoPitch_up.BackColor = System.Drawing.Color.DarkKhaki;
            this.bt_servoPitch_up.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_servoPitch_up.Location = new System.Drawing.Point(11, 29);
            this.bt_servoPitch_up.Name = "bt_servoPitch_up";
            this.bt_servoPitch_up.Size = new System.Drawing.Size(69, 47);
            this.bt_servoPitch_up.TabIndex = 0;
            this.bt_servoPitch_up.Text = "Yukarı";
            this.bt_servoPitch_up.UseVisualStyleBackColor = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.bt_servoRoll_left);
            this.groupBox7.Controls.Add(this.bt_servoRoll_right);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.Location = new System.Drawing.Point(659, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(90, 167);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Servo Yatış";
            // 
            // bt_servoRoll_left
            // 
            this.bt_servoRoll_left.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_servoRoll_left.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_servoRoll_left.Location = new System.Drawing.Point(11, 103);
            this.bt_servoRoll_left.Name = "bt_servoRoll_left";
            this.bt_servoRoll_left.Size = new System.Drawing.Size(69, 47);
            this.bt_servoRoll_left.TabIndex = 0;
            this.bt_servoRoll_left.Text = "Sola Dönüş";
            this.bt_servoRoll_left.UseVisualStyleBackColor = false;
            // 
            // bt_servoRoll_right
            // 
            this.bt_servoRoll_right.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_servoRoll_right.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_servoRoll_right.Location = new System.Drawing.Point(11, 29);
            this.bt_servoRoll_right.Name = "bt_servoRoll_right";
            this.bt_servoRoll_right.Size = new System.Drawing.Size(69, 47);
            this.bt_servoRoll_right.TabIndex = 0;
            this.bt_servoRoll_right.Text = "Sağa Dönüş";
            this.bt_servoRoll_right.UseVisualStyleBackColor = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label_X);
            this.groupBox8.Controls.Add(this.label_Y);
            this.groupBox8.Controls.Add(this.label_Z);
            this.groupBox8.Controls.Add(this.label_teta1);
            this.groupBox8.Controls.Add(this.label_teta0);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.Location = new System.Drawing.Point(275, 200);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(474, 103);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kinematik Bilgisi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(360, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Servo Roll :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(261, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Servo D :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(294, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Z :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(201, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Y :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(135, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teta 1 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(109, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "X :";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_X.ForeColor = System.Drawing.Color.Red;
            this.label_X.Location = new System.Drawing.Point(135, 66);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(43, 16);
            this.label_X.TabIndex = 0;
            this.label_X.Text = "0 mm";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Y.ForeColor = System.Drawing.Color.Red;
            this.label_Y.Location = new System.Drawing.Point(229, 66);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(43, 16);
            this.label_Y.TabIndex = 0;
            this.label_Y.Text = "0 mm";
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Z.ForeColor = System.Drawing.Color.Red;
            this.label_Z.Location = new System.Drawing.Point(315, 66);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(43, 16);
            this.label_Z.TabIndex = 0;
            this.label_Z.Text = "0 mm";
            // 
            // label_teta1
            // 
            this.label_teta1.AutoSize = true;
            this.label_teta1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_teta1.ForeColor = System.Drawing.Color.Red;
            this.label_teta1.Location = new System.Drawing.Point(188, 25);
            this.label_teta1.Name = "label_teta1";
            this.label_teta1.Size = new System.Drawing.Size(40, 16);
            this.label_teta1.TabIndex = 0;
            this.label_teta1.Text = "0 der";
            // 
            // label_teta0
            // 
            this.label_teta0.AutoSize = true;
            this.label_teta0.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_teta0.ForeColor = System.Drawing.Color.Red;
            this.label_teta0.Location = new System.Drawing.Point(66, 25);
            this.label_teta0.Name = "label_teta0";
            this.label_teta0.Size = new System.Drawing.Size(40, 16);
            this.label_teta0.TabIndex = 0;
            this.label_teta0.Text = "0 der";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teta 0 :";
            // 
            // bt_fileOpen
            // 
            this.bt_fileOpen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_fileOpen.Location = new System.Drawing.Point(23, 36);
            this.bt_fileOpen.Name = "bt_fileOpen";
            this.bt_fileOpen.Size = new System.Drawing.Size(86, 30);
            this.bt_fileOpen.TabIndex = 0;
            this.bt_fileOpen.Text = "Dosya Aç";
            this.bt_fileOpen.UseVisualStyleBackColor = true;
            this.bt_fileOpen.Click += new System.EventHandler(this.bt_fileOpen_Click);
            // 
            // bt_send_work
            // 
            this.bt_send_work.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_send_work.Location = new System.Drawing.Point(136, 36);
            this.bt_send_work.Name = "bt_send_work";
            this.bt_send_work.Size = new System.Drawing.Size(86, 30);
            this.bt_send_work.TabIndex = 0;
            this.bt_send_work.Text = "Gönder";
            this.bt_send_work.UseVisualStyleBackColor = true;
            this.bt_send_work.Click += new System.EventHandler(this.bt_send_work_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.bt_fileOpen);
            this.groupBox10.Controls.Add(this.bt_send_work);
            this.groupBox10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox10.Location = new System.Drawing.Point(12, 234);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(245, 83);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Koordinat Dosyası Gönder";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(757, 324);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ameliyat Yardımcı Kol Kontrol Yazılımı Ver 1.0 ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_comPort;
        private System.Windows.Forms.Button bt_comPortConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_arm2_left;
        private System.Windows.Forms.Button bt_arm2_right;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_gripperDown;
        private System.Windows.Forms.Button bt_gripperUp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_arm1_left;
        private System.Windows.Forms.Button bt_arm1_right;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_distanceHundered;
        private System.Windows.Forms.RadioButton rb_distanceTen;
        private System.Windows.Forms.RadioButton rb_distanceOne;
        private System.IO.Ports.SerialPort ComPort;
        private System.Windows.Forms.TextBox tb_distance;
        private System.Windows.Forms.RadioButton rb_distanceManual;
        private System.Windows.Forms.RadioButton rb_distanceFifty;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button bt_servoPitch_down;
        private System.Windows.Forms.Button bt_servoPitch_up;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button bt_servoRoll_left;
        private System.Windows.Forms.Button bt_servoRoll_right;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_fileOpen;
        private System.Windows.Forms.Button bt_send_work;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label_Z;
        private System.Windows.Forms.Label label_teta1;
        private System.Windows.Forms.Label label_teta0;
        private System.Windows.Forms.Button bt_gripper_setZero;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Timer timer1;
    }
}

