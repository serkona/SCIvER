using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{

    public partial class Exam : MaterialForm
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Questions.mdb;";
        private OleDbConnection myConnection;
        public Exam()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            Timer_Exam.Start();
        }
        int k, i, i_login;
        public void GiveTask(int type)
        {
            if (conf[type] != null)
            {
                pictureBox_Confirm.Image = conf[type];
            }
            else
                pictureBox_Confirm.Image = null;

            textBox_Checking.Visible = true;
            i_login = type;
            i = type + 1;
            string i_s = Convert.ToString(i);
            Answer_TextBox.Visible = true;
            Enter_Button.Visible = true;
            if (flag[type] == false)
            {
                Req = "SELECT Count(*) FROM Task" + i_s;
                OleDbCommand command2 = new OleDbCommand(Req, myConnection);
                quan = command2.ExecuteScalar().ToString();
                Quantity[type] = Convert.ToInt32(quan);

                Random rnd = new Random();
                Req = "SELECT Task_Text FROM Task" + i_s + " WHERE Number = ";
                Num = rnd.Next(1, Quantity[type]);
                q_s = Convert.ToString(Num);
                Req = Req + q_s;
                OleDbCommand command = new OleDbCommand(Req, myConnection);
                Texts[type] = command.ExecuteScalar().ToString();

                if (Texts[type] != "")
                {
                    Task_Picture.Visible = false;
                    TextBox_Task.Visible = true;
                    TextBox_Task.Text = Texts[type];
                }
                else
                {
                    Task_Picture.Visible = true;
                    TextBox_Task.Visible = false;
                    Im = "Images//Task_" + i_s + "//Task_" + i_s + "_";
                    Im = Im + q_s + ".png";
                    System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                    fs.Close();
                    Task_Picture.Image = img;
                    imgs[type] = img;
                }
                Req_answ = "SELECT Answer FROM Task" + i_s + " WHERE Number = " + q_s;
                OleDbCommand command1 = new OleDbCommand(Req_answ, myConnection);
                answer = command1.ExecuteScalar().ToString();
                TrueAnswers[type] = answer;
                Answer_TextBox.Text = UserAnswers[type];
                textBox_Checking.Text = answer;
                flag[type] = true;
            }
            else
            {
                if (Texts[type] != "")
                {
                    TextBox_Task.Visible = true;
                    Task_Picture.Visible = false;
                    TextBox_Task.Text = Texts[type];
                }
                else
                {
                    TextBox_Task.Visible = false;
                    Task_Picture.Visible = true;
                    Task_Picture.Image = imgs[type];
                }
                answer = TrueAnswers[type];
                Answer_TextBox.Text = UserAnswers[type];
                textBox_Checking.Text = TrueAnswers[type];
            }
        }


        int h = 3, m = 55, s = 0;
        private void Timer_Exam_Tick(object sender, EventArgs e)
        {
            s--;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }
            if (h == 0 && m == 0 && s == 0)
            {
                Timer_Exam.Stop();
                EndTest_Button.PerformClick();
            }
            label_Hours.Text = Convert.ToString(h);
            label_Minutes.Text = Convert.ToString(m);
            label_Seconds.Text = Convert.ToString(s);
        }




        int Num, Num24, Num25, Num26, Num27;
        int Sum_Score = 0, Sum_Score_C = 0, Sum, EGE_Score;
        bool[] flag = new bool[27] { false, false, false, false, false, false, false, false, false, false,
                                     false, false, false, false, false, false,
                                     false, false, false, false, false,
                                     false, false, false, false, false, false};

        bool flagEnd = false;

        bool flagD24 = false, flagD25 = false, flagD26 = false, flagD27 = false;
        Image imgD24, imgD25, imgD26, imgD27;


        string[] Texts = new string[27] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

        string Req, Req_answ, q_s;


        string Im;


        int[,] Transfer = new int[36, 2] { { 0, 0 }, { 1, 7 }, { 2, 14 }, { 3, 20 }, { 4, 27 }, { 5, 34 }, { 6, 40 }, { 7, 42 }, { 8, 44 },
        { 9, 46 }, { 10, 48 }, { 11, 50 }, { 12, 51 }, { 13, 53 }, { 14, 55 }, { 15, 57 }, { 16, 59 }, { 17, 61 }, { 18, 62 }, { 19, 64 }, { 20, 66 },
        { 21, 68 }, {22, 70}, { 23 , 72 }, { 24, 73  }, {25 , 75 }, { 26, 77 }, { 27 , 79 }, { 28, 81 }, { 29, 83 }, { 30, 84 }, { 31 , 88 },
        { 32, 91 }, { 33 , 94 }, { 34, 97 }, { 35 , 100} };



        string[] TrueAnswers = new string[23] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        string[] UserAnswers = new string[23] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        int[] Quantity = new int[27] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] MaxScoreC = new int[4] { 3, 2, 3, 4 };
        int[] UserScoreC = new int[4] { 0, 0, 0, 0 };

        string answer;
        string quan;

        private void radioButton24_0_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[0] = 0;
        }
        private void radioButton24_1_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[0] = 1;
        }
        private void radioButton24_2_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[0] = 2;
        }
        private void radioButton24_3_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[0] = 3;
        }
        private void radioButton25_0_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[1] = 0;
        }
        private void radioButton25_1_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[1] = 1;
        }
        private void radioButton25_2_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[1] = 2;
        }
        private void radioButton26_0_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[2] = 0;
        }
        private void radioButton26_1_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[2] = 1;
        }
        private void radioButton26_2_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[2] = 2;
        }
        private void radioButton26_3_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[2] = 3;
        }
        private void radioButton27_0_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[3] = 0;
        }
        private void radioButton27_1_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[3] = 1;
        }
        private void radioButton27_2_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[3] = 2;
        }
        private void radioButton27_3_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[3] = 3;
        }
        private void radioButton27_4_CheckedChanged(object sender, EventArgs e)
        {
            UserScoreC[3] = 4;
        }







        Image[] imgs = new Image[27];
        Image[] conf = new Image[23];

        private void Exam_Load(object sender, EventArgs e)
        {
            GiveTask(0);
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            UserAnswers[i_login] = Answer_TextBox.Text;

            if (UserAnswers[i_login] != "")
            {
                Im = "Images//Confirm.png";
                System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                conf[i_login] = img;
                pictureBox_Confirm.Image = img;
            }
        }

        int BeginTime, EndMinutes, EndTime, ShowTime;

        private void EndTest_Button_Click(object sender, EventArgs e)
        {
            Timer_Exam.Stop();
            Task24_Button.PerformClick();
            Task25_Button.PerformClick();
            Task26_Button.PerformClick();
            Task27_Button.PerformClick();

            /*  GiveTask(0);
              GiveTask(1);
              GiveTask(2);
              GiveTask(3);
              GiveTask(4);
              GiveTask(5);
              GiveTask(6);
              GiveTask(7);
              GiveTask(8);
              GiveTask(9);
              GiveTask(10);
              GiveTask(11);
              GiveTask(12);
              GiveTask(13);
              GiveTask(14);
              GiveTask(15);
              GiveTask(16);
              GiveTask(17);
              GiveTask(18);
              GiveTask(19);
              GiveTask(20);
              GiveTask(21);
              GiveTask(22);   Добавляет ответы на изначально непрогруженные задачи 
              */
            textBox_Checking.Visible = false;
            Exam_Panel.Visible = false;
            Enter_Button.Visible = false;
            Answer_TextBox.Visible = false;
            TextBox_Task.Visible = false;
            panel_Taimer.Visible = false;


            pictureBox_Confirm.Visible = false;

            
            if (flagEnd == false)
            {
                textBox_Checking.Visible = false;

                PanelC.Visible = true;

                Task_Picture.Location = new Point(100, 100);
                Task_Picture.Left = 10;
                Task_Picture.Top = 70;
                Task_Picture.Image = null;


                flagEnd = true;
            }

            else

            {
                this.Text = "                                                                                          Result";
                PanelC.Visible = false;
                Answers_dataGridView.RowCount = 23;
                AnswersС_dataGridView.RowCount = 4;
                Task_Picture.Visible = false;
                this.Width = 300;
                this.Height = 500;
                int j, j_real;
                string j_s;


                for (j = 0; j < 23; j++)
                {
                    j_real = j + 1;
                    j_s = Convert.ToString(j_real);
                    Answers_dataGridView.Rows[j].Cells[0].Value = j_s;
                }
                for (j = 0; j < 23; j++)
                {
                    Answers_dataGridView.Rows[j].Cells[1].Value = UserAnswers[j];
                }
                for (j = 0; j < 23; j++)
                {
                    Answers_dataGridView.Rows[j].Cells[2].Value = TrueAnswers[j];
                }




                for (j = 0; j < 23; j++)
                {
                    if (UserAnswers[j] != "")
                    {
                        if (UserAnswers[j] == TrueAnswers[j])
                        {
                            Answers_dataGridView.Rows[j].Cells[3].Value = "1";
                            Answers_dataGridView.Rows[j].Cells[3].Style.BackColor = System.Drawing.Color.LightGreen;
                            Sum_Score++;
                        }
                        else
                        {
                            Answers_dataGridView.Rows[j].Cells[3].Value = "0";
                            Answers_dataGridView.Rows[j].Cells[3].Style.BackColor = System.Drawing.Color.LightCoral;
                        }

                    }
                    else
                    {
                        Answers_dataGridView.Rows[j].Cells[3].Value = "0";
                        Answers_dataGridView.Rows[j].Cells[3].Style.BackColor = System.Drawing.Color.LightCoral;
                    }


                }




                for (j = 0; j < 4; j++)
                {
                    j_real = j + 24;
                    j_s = Convert.ToString(j_real);
                    AnswersС_dataGridView.Rows[j].Cells[0].Value = j_s;
                }

                for (j = 0; j < 4; j++)
                {
                    AnswersС_dataGridView.Rows[j].Cells[1].Value = UserScoreC[j];
                }
                for (j = 0; j < 4; j++)
                {
                    AnswersС_dataGridView.Rows[j].Cells[2].Value = MaxScoreC[j];
                }


                for (j = 0; j < 4; j++)
                {
                    if (UserScoreC[j] < MaxScoreC[j] && UserScoreC[j] != 0)
                    {
                        AnswersС_dataGridView.Rows[j].Cells[1].Style.BackColor = System.Drawing.Color.LightYellow;
                        AnswersС_dataGridView.Rows[j].Cells[2].Style.BackColor = System.Drawing.Color.LightYellow;
                    }

                    if (UserScoreC[j] == MaxScoreC[j])
                    {
                        AnswersС_dataGridView.Rows[j].Cells[1].Style.BackColor = System.Drawing.Color.LightGreen;
                        AnswersС_dataGridView.Rows[j].Cells[2].Style.BackColor = System.Drawing.Color.LightGreen;
                    }
                    if (UserScoreC[j] == 0)
                    {
                        AnswersС_dataGridView.Rows[j].Cells[1].Style.BackColor = System.Drawing.Color.LightCoral;
                        AnswersС_dataGridView.Rows[j].Cells[2].Style.BackColor = System.Drawing.Color.LightCoral;
                    }

                    Sum_Score_C = Sum_Score_C + UserScoreC[j];
                }


                Sum = Sum_Score + Sum_Score_C;

                for (j = 0; j < 36; j++)
                {
                    if (Sum == Transfer[j, 0])
                    {
                        EGE_Score = Transfer[j, 1];
                        break;
                    }
                }




                Answers_dataGridView.Visible = true;
                AnswersС_dataGridView.Enabled = false;
                AnswersС_dataGridView.Visible = true;

                BeginTime = 14100;
                EndMinutes = h * 60 + m;
                EndTime = EndMinutes * 60 + s;

                ShowTime = BeginTime - EndTime;
                h = (ShowTime / 60) / 60;
                m = (ShowTime / 60) % 60;
                s = ShowTime % 60;
                label_Hours.Text = Convert.ToString(h);
                label_Minutes.Text = Convert.ToString(m);
                label_Seconds.Text = Convert.ToString(s);

                panel_Taimer.Location = new Point(100, 100);
                panel_Taimer.Left = 515;
                panel_Taimer.Top = 355;
                panel_Taimer.Visible = true;


                label_TimeDo.Location = new Point(100, 100);
                label_TimeDo.Left = 480;
                label_TimeDo.Top = 340;
                label_TimeDo.Visible = true;


                Back_button.Location = new Point(100, 100);
                Back_button.Left = 500;
                Back_button.Top = 450;


                label_ResultB.Location = new Point(100, 100);
                label_ResultB.Left = 480;
                label_ResultB.Top = 220;

                label_Result.Location = new Point(100, 100);
                label_Result.Left = 505;
                label_Result.Top = 263;



                Answers_dataGridView.Location = new Point(100, 100);
                Answers_dataGridView.Left = 6;
                Answers_dataGridView.Top = 70;

                AnswersС_dataGridView.Location = new Point(100, 100);
                AnswersС_dataGridView.Left = 451;
                AnswersС_dataGridView.Top = 70;

                string EGE = Convert.ToString(EGE_Score);
                string EGEB = Convert.ToString(Sum);
                label_Result.Text += EGE;
                label_ResultB.Text += EGEB;
                label_Result.Visible = true;
                label_ResultB.Visible = true;

                EndTest_Button.Enabled = false;
                EndTest_Button.Visible = false;
                Back_button.Visible = true;
            }

        }

        private void PanelC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Task1_Button_Click(object sender, EventArgs e)
        {
            GiveTask(0);
        }


        private void Task2_Button_Click(object sender, EventArgs e)
        {
            GiveTask(1);
        }

        private void Task3_Button_Click(object sender, EventArgs e)
        {
            GiveTask(2);
        }

        private void Task4_Button_Click(object sender, EventArgs e)
        {
            GiveTask(3);
        }

        private void Task5_Button_Click_1(object sender, EventArgs e)
        {
            GiveTask(4);
        }


        private void Task6_Button_Click(object sender, EventArgs e)
        {
            GiveTask(5);
        }


        private void Task7_Button_Click(object sender, EventArgs e)
        {
            GiveTask(6);
        }

        private void Task8_Button_Click(object sender, EventArgs e)
        {
            GiveTask(7);
        }

        private void Task9_Button_Click(object sender, EventArgs e)
        {
            GiveTask(8);
        }

        private void Task10_Button_Click(object sender, EventArgs e)
        {
            GiveTask(9);
        }


        private void Task11_Button_Click(object sender, EventArgs e)
        {
            GiveTask(10);
        }

        private void Task12_Button_Click(object sender, EventArgs e)
        {
            GiveTask(11);
        }


        private void Task13_Button_Click(object sender, EventArgs e)
        {
            GiveTask(12);
        }


        private void Task14_Button_Click(object sender, EventArgs e)
        {
            GiveTask(13);
        }

        private void Task15_Button_Click(object sender, EventArgs e)
        {
            GiveTask(14);
        }

        private void Task16_Button_Click(object sender, EventArgs e)
        {
            GiveTask(15);
        }

        private void Task17_Button_Click(object sender, EventArgs e)
        {
            GiveTask(16);
        }


        private void Task18_Button_Click(object sender, EventArgs e)
        {
            GiveTask(17);
        }


        private void Task19_Button_Click(object sender, EventArgs e)
        {
            GiveTask(18);
        }


        private void Task20_Button_Click(object sender, EventArgs e)
        {
            GiveTask(19);
        }


        private void Task21_Button_Click(object sender, EventArgs e)
        {
            GiveTask(20);
        }
        private void Task22_Button_Click(object sender, EventArgs e)
        {
            GiveTask(21);
        }

        private void Task23_Button_Click(object sender, EventArgs e)
        {
            GiveTask(22);
        }



        private void Task24_Button_Click(object sender, EventArgs e)
        {
            TextBox_Task.Visible = false;
            Task_Picture.Visible = true;
            k = 23;
            Answer_TextBox.Visible = false;
            Enter_Button.Visible = false;
            textBox_Checking.Visible = false;

            if (flag[k] == false)
            {
                Im = "Images//Task_24//Task//Task_24_";
                Random rnd = new Random();
                Num24 = rnd.Next(1, 20);
                q_s = Convert.ToString(Num24);
                Im = Im + q_s + ".png";
                System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                Task_Picture.Image = img;
                imgs[k] = img;
                flag[k] = true;
            }
            else
            {
                Task_Picture.Image = imgs[k];
            }
        }

        private void TaskDecision24_Button_Click(object sender, EventArgs e)
        {
            TextBox_Task.Visible = false;
            Task_Picture.Visible = true;

            if (flagD24 == false)
            {
                Im = "Images//Task_24//Answers//Answer_24_";
                q_s = Convert.ToString(Num24);
                Im = Im + q_s + ".png";
                System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                Task_Picture.Image = img;
                imgD24 = img;
                flagD24 = true;
            }
            else
            {
                Task_Picture.Image = imgD24;
            }
        }


        private void Task25_Button_Click(object sender, EventArgs e)
        {
            TextBox_Task.Visible = false;
            Task_Picture.Visible = true;
            k = 24;
            Answer_TextBox.Visible = false;
            Enter_Button.Visible = false;
            textBox_Checking.Visible = false;

            if (flag[24] == false)
            {
                Im = "Images//Task_25//Task//Task_25_";
                Random rnd = new Random();
                Num25 = rnd.Next(1, 20);
                q_s = Convert.ToString(Num25);
                Im = Im + q_s + ".png";
                System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                Task_Picture.Image = img;
                imgs[k] = img;
                flag[k] = true;
            }
            else
            {
                Task_Picture.Image = imgs[k];
            }
        }

        private void TaskDecision25_Button_Click(object sender, EventArgs e)
        {
            TextBox_Task.Visible = false;
            Task_Picture.Visible = true;

            if (flagD25 == false)
            {
                Im = "Images//Task_25//Answers//Answer_25_";
                q_s = Convert.ToString(Num25);
                Im = Im + q_s + ".png";
                System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                Task_Picture.Image = img;
                imgD25 = img;
                flagD25 = true;
            }
            else
            {
                Task_Picture.Image = imgD25;
            }
        }

        private void Task26_Button_Click(object sender, EventArgs e)
        {
            TextBox_Task.Visible = false;
            Task_Picture.Visible = true;
            k = 25;
            Answer_TextBox.Visible = false;
            Enter_Button.Visible = false;
            textBox_Checking.Visible = false;

            if (flag[k] == false)
            {
                Im = "Images//Task_26//Task//Task_26_";
                Random rnd = new Random();
                Num26 = rnd.Next(1, 20);
                q_s = Convert.ToString(Num26);
                Im = Im + q_s + ".png";
                System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                Task_Picture.Image = img;
                imgs[k] = img;
                flag[k] = true;
            }
            else
            {
                Task_Picture.Image = imgs[k];
            }
        }

        private void TaskDecision26_Button_Click(object sender, EventArgs e)
        {
            TextBox_Task.Visible = false;
            Task_Picture.Visible = true;

            if (flagD26 == false)
            {
                Im = "Images//Task_26//Answers//Answer_26_";
                Random rnd = new Random();
                q_s = Convert.ToString(Num26);
                Im = Im + q_s + ".png";
                System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                Task_Picture.Image = img;
                imgD26 = img;
                flagD26 = true;
            }
            else
            {
                Task_Picture.Image = imgD26;
            }
        }

        private void Task27_Button_Click(object sender, EventArgs e)
        {
            TextBox_Task.Visible = false;
            Task_Picture.Visible = true;
            k = 26;
            Answer_TextBox.Visible = false;
            Enter_Button.Visible = false;
            textBox_Checking.Visible = false;

            if (flag[k] == false)
            {
                Im = "Images//Task_27//Task//Task_27_";
                Random rnd = new Random();
                Num27 = rnd.Next(1, 20);
                q_s = Convert.ToString(Num27);
                Im = Im + q_s + ".png";
                System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                Task_Picture.Image = img;
                imgs[k] = img;
                flag[k] = true;
            }
            else
            {
                Task_Picture.Image = imgs[k];
            }
        }

        private void TaskDecision27_Button_Click(object sender, EventArgs e)
        {
            TextBox_Task.Visible = false;
            Task_Picture.Visible = true;

            if (flagD27 == false)
            {
                Im = "Images//Task_27//Answers//Answer_27_";
                q_s = Convert.ToString(Num27);
                Im = Im + q_s + ".png";
                System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                Task_Picture.Image = img;
                imgD27 = img;
                flagD27 = true;
            }
            else
            {
                Task_Picture.Image = imgD27;
            }
        }

        Programm Form = new Programm();
        private void Back_button_Click(object sender, EventArgs e)
        {
            Form.Show();
            this.Hide();
        }

        private void Exam_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Answer_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Task_TextChanged(object sender, EventArgs e)
        {

        }
        private void label24_Click(object sender, EventArgs e)
        {

        }
        private void label_Hours_Click(object sender, EventArgs e)
        {

        }
        private void label_Seconds_Click(object sender, EventArgs e)
        {

        }
        private void Exam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Show();
            this.Hide();
        }

    }
}
