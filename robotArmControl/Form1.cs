using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robotArmControl
{

    public partial class Form1 : Form
    {
        string[] myComPorts;
        float teta0 = 0;
        float teta1 = 0;
        float zDepth = 0;

        float t_teta0 = 0;
        float t_teta1 = 0;
        //float t_zDepth = 0;

        double[] t_pos = new double[2];
        float[] pos = new float[2];
		
		float[] gripper_refPos = new float[2];
		float[] gripper_refAngles = new float[2];

        byte dir_teta1 = 1;
        byte dir_teta0 = 1;

        double arm1_length = 210;
        double arm2_length = 235;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_comPortConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComPort.IsOpen == false)
                {
                    ComPort.PortName = cb_comPort.Text;
                    ComPort.BaudRate = 115200;
                    ComPort.DataBits = 8;
                    ComPort.StopBits = StopBits.One;
                    ComPort.Parity = Parity.None;
                    ComPort.Open();
                    bt_comPortConnect.Text = "Kapat";
                    cb_comPort.Enabled =     false;
                    bt_arm1_left.Enabled =   true;
                    bt_arm1_right.Enabled =  true;
                    bt_arm2_left.Enabled =   true;
                    bt_arm2_right.Enabled =  true;
                    bt_gripperDown.Enabled = true;
                    bt_gripperUp.Enabled =   true;
                    bt_servoPitch_down.Enabled = true;
                    bt_servoPitch_up.Enabled = true;
                    bt_servoRoll_left.Enabled = true;
                    bt_servoRoll_right.Enabled = true;
                    bt_send_work.Enabled = true;
                    bt_fileOpen.Enabled = true;
                    bt_gripper_setZero.Enabled = true;
                }
                else
                {
                    ComPort.Close();
                    bt_comPortConnect.Text = "Bağlan";
                    cb_comPort.Enabled = true;
                    bt_arm1_left.Enabled = false;
                    bt_arm1_right.Enabled = false;
                    bt_arm2_left.Enabled = false;
                    bt_arm2_right.Enabled = false;
                    bt_gripperDown.Enabled = false;
                    bt_gripperUp.Enabled = false;
                    bt_servoPitch_down.Enabled = false;
                    bt_servoPitch_up.Enabled = false;
                    bt_servoRoll_left.Enabled = false;
                    bt_servoRoll_right.Enabled = false;
                    bt_send_work.Enabled = false;
                    bt_fileOpen.Enabled = false;
                    bt_gripper_setZero.Enabled = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void comPorts_listing() 
        {
            myComPorts = SerialPort.GetPortNames();
            cb_comPort.Items.Clear();
            cb_comPort.Items.AddRange(myComPorts);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comPorts_listing();
            rb_distanceOne.Checked = true;
            bt_arm1_left.Enabled = false;
            bt_arm1_right.Enabled = false;
            bt_arm2_left.Enabled = false;
            bt_arm2_right.Enabled = false;
            bt_gripperDown.Enabled = false;
            bt_gripperUp.Enabled = false;
            bt_servoPitch_down.Enabled = false;
            bt_servoPitch_up.Enabled = false;
            bt_servoRoll_left.Enabled = false;
            bt_servoRoll_right.Enabled = false;
            bt_send_work.Enabled = false;
            bt_fileOpen.Enabled = false;
            bt_gripper_setZero.Enabled = false;
			gripper_refAngles[0] = 0;
			gripper_refAngles[1] = 0;
			gripper_refPos[0] = 0;
			gripper_refPos[1] = 0;
			pos[0] = Convert.ToSingle(arm1_length) + Convert.ToSingle(arm2_length);
			pos[1] = 0;
			t_pos[0] = 0;
			t_pos[1] = 0;
            label_X.Text = Convert.ToString(pos[0]) + " mm";
			label_Y.Text = Convert.ToString(pos[1]) + " mm";
        }

        private void cb_comPort_Click(object sender, EventArgs e)
        {
            comPorts_listing();
        }

        private UInt16 motor_step_calc(float command, byte motorNumber) 
        {
            UInt16 stepSize=0;

            if (motorNumber == ((byte)2))
            {
                stepSize = Convert.ToUInt16((command / ((float)0.45)));
            }
            else if (motorNumber == ((byte)3))
            {
                stepSize = Convert.ToUInt16(15*(command / ((float)0.45)));
            }
            else if (motorNumber == ((byte)1)) 
            {
                stepSize = Convert.ToUInt16((command / ((float)0.45)));
            }
            return stepSize;
        }
		
		private void update_kinematic_labels(float angle, byte motorNumber, byte direction)
		{
            if (motorNumber == ((byte)2))
            {
                if (direction == ((byte)1)) 
                {
                    teta1 += angle;
                }
                else if (direction == ((byte)0))
                {
                    teta1 -= angle;
                }
            }
            else if (motorNumber == ((byte)3))
            {
                if (direction == ((byte)1))
                {
                    teta0 += angle;
                }
                else if (direction == ((byte)0))
                {
                    teta0 -= angle;
                }
            }
            else if (motorNumber == ((byte)1)) 
            {
                if (direction == ((byte)1))
                {
                    zDepth -= angle;
                }
                else if (direction == ((byte)0))
                {
                    zDepth += angle;
                }
            }
            label_teta0.Text = Convert.ToString(teta0) + " der";
            label_teta1.Text = Convert.ToString(teta1) + " der";
            label_Z.Text = Convert.ToString(zDepth) + " mm";
			
            forward_kinematic_calc();						
			
			label_X.Text = Convert.ToString(pos[0]);
            label_Y.Text = Convert.ToString(pos[1]);
        }
		
		private UInt16 commandSelector(byte motorNumber, byte direction)
		{
			UInt16 distance = 0;
			float command = 0;

            if (rb_distanceOne.Checked==true)
            {
                command = 1;
            }
            if (rb_distanceTen.Checked==true)
            {
                command = 10;
            }
            if (rb_distanceHundered.Checked==true)
            {
                command = 100;
            }
            if (rb_distanceFifty.Checked == true)
            {
                command = 50;
            }
            if (rb_distanceManual.Checked==true)
            {
                command = Convert.ToSingle(tb_distance.Text);
				if (command < 0)
					command *= (-1);
            }			
			
			update_kinematic_labels(command, motorNumber, direction);
			
			return distance = motor_step_calc(command, motorNumber);
		}

        private void motor_command_send_Step(UInt16 targetDist, byte motorNumber, byte direction)
        {
            if (targetDist > 0)
			{
				byte[] step = new byte[2];
				step[0] = (byte)(targetDist);
				step[1] = (byte)(targetDist >> 8);
	
				try
				{
					byte[] sendBuffer = new byte[5];
					sendBuffer[0] = (byte)'@';
					sendBuffer[1] = motorNumber;
					sendBuffer[2] = direction;
					sendBuffer[3] = step[0];
					sendBuffer[4] = step[1];
					ComPort.Write(sendBuffer, 0, 5);				
				}
				catch (Exception err)
				{
					MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
        }

        private void forward_kinematic_calc() 
        {        
            double teta0_radian = teta0 * Math.PI / 180;   // degrees to radians
            double teta1_radian = teta1 * Math.PI / 180;

            pos[0] = Convert.ToSingle(arm1_length * Math.Cos(teta0_radian) + arm2_length * Math.Cos(teta0_radian + teta1_radian));
            pos[1] = Convert.ToSingle(arm1_length * Math.Sin(teta0_radian) + arm2_length * Math.Sin(teta0_radian + teta1_radian));
        }

        private void inverse_kinematic_calc(double X, double Y) 
        {
            double target_teta1 = Math.Acos((Math.Pow(X, 2) + Math.Pow(Y, 2) - Math.Pow(arm1_length, 2) - Math.Pow(arm2_length, 2)) / (2 * arm1_length * arm2_length));
            
            /*
            if (X < 0 & Y < 0)
            {
                target_teta1 = (-1) * target_teta1;
            }
            */

            double target_teta0 = Math.Atan(Y / X) - Math.Atan((arm2_length * Math.Sin(target_teta1)) / (arm1_length + arm2_length * Math.Cos(target_teta1)));

            target_teta1 = target_teta1 * 180 / Math.PI; // (-1) *
            target_teta0 = target_teta0 * 180 / Math.PI;

            t_teta1 = Convert.ToSingle(target_teta1) - teta1;
            t_teta0 = Convert.ToSingle(target_teta0) - teta0;

            if (t_teta1 < 0)
			{
                dir_teta1 = 0;
				t_teta1 *= (-1);
			}
			
            if (t_teta0 < 0)
			{
                dir_teta0 = 0;
                t_teta0 *= (-1);
			}
        }

        private void bt_gripperUp_Click(object sender, EventArgs e)
        {
            UInt16 command = commandSelector((byte)1, (byte)0);
			motor_command_send_Step(command, (byte)1, (byte)0);
        }

        private void bt_gripperDown_Click(object sender, EventArgs e)
        {
            UInt16 command = commandSelector((byte)1, (byte)1);
			motor_command_send_Step(command, (byte)1, (byte)1);
        }

        private void bt_arm2_right_Click(object sender, EventArgs e)
        {
            UInt16 command = commandSelector((byte)2, (byte)0);
			motor_command_send_Step(command, (byte)2, (byte)0);
        }

        private void bt_arm2_left_Click(object sender, EventArgs e)
        {
            UInt16 command = commandSelector((byte)2, (byte)1);
			motor_command_send_Step(command, (byte)2, (byte)1);
        }

        private void bt_arm1_right_Click(object sender, EventArgs e)
        {
            UInt16 command = commandSelector((byte)3, (byte)0);
			motor_command_send_Step(command, (byte)3, (byte)0);
        }

        private void bt_arm1_left_Click(object sender, EventArgs e)
        {
            UInt16 command = commandSelector((byte)3, (byte)1);
			motor_command_send_Step(command, (byte)3, (byte)1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ComPort.IsOpen == true) ComPort.Close();
        }

        private void bt_fileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            String filePath = null;
            string Command_text = null;

            try
            {
                openFileDialog1.DefaultExt = ".txt";
                openFileDialog1.Filter = "Text Files(*.txt)|*.txt";
                openFileDialog1.ShowDialog();
                filePath = openFileDialog1.FileName;

                FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    Command_text = reader.ReadLine();
                    reader.Close();
                }
                fileStream.Close();
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           

            if (Command_text != null)
            {
                try
                {
                    string[] result = Command_text.Split(';');
                    for (int i = 0; i < 2; i++)
                    {
                        t_pos[i] = Convert.ToDouble(result[i]);
                    }
                    MessageBox.Show("Dosya Okuma Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Dosya Okunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Dosya Boş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_send_work_Click(object sender, EventArgs e)
        {
            double target_coord_X = Convert.ToDouble(gripper_refPos[0]) + t_pos[0];
            double target_coord_Y = Convert.ToDouble(gripper_refPos[1]) + t_pos[1];
            double kinematicLimit = Math.Sqrt(Math.Pow(target_coord_X, 2) + Math.Pow(target_coord_Y, 2));            

            if ((kinematicLimit > 180) && (kinematicLimit < (arm1_length + arm2_length)))
            {
                inverse_kinematic_calc(target_coord_X, target_coord_Y);

                if (t_teta1 == float.NaN)
                    MessageBox.Show("Teta 1 açısı kinematik hatası", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (t_teta0 == float.NaN)
                    MessageBox.Show("Teta 0 açısı kinematik hatası", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if ((t_teta1 != float.NaN) && (t_teta0 != float.NaN) && (t_teta1 > 0) && (t_teta0 > 0))
                {					
					update_kinematic_labels(t_teta1, (byte)2, dir_teta1);
					update_kinematic_labels(t_teta0, (byte)3, dir_teta0);
					                
					UInt16 command;
					
					command = motor_step_calc(t_teta1, (byte)2);
					
					motor_command_send_Step(command, (byte)2, dir_teta1);

                    command = motor_step_calc(t_teta0, (byte)3);
					
					motor_command_send_Step(command, (byte)3, dir_teta0);
                }                
            }
            else
            {
                MessageBox.Show("Hedef koordinatlar robot kinematik limitlerini aşıyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }        

        private void bt_gripper_setZero_Click(object sender, EventArgs e)
        {
			gripper_refAngles[0] = teta0;
			gripper_refAngles[1] = teta1;
			
			gripper_refPos[0] = pos[0];
			gripper_refPos[1] = pos[1];
        }
    }
}
