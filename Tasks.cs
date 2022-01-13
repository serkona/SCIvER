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
    public partial class Tasks : MaterialForm
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Questions.mdb;";
        private OleDbConnection myConnection;
        public Tasks()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }
        private void Tasks_Load(object sender, EventArgs e)
        {

        }

        public void GiveQuan(string type)
        {
            textBox_AllNumber.Text = "";
            textBox_Number.Text = "1";
            OleDbCommand command2 = new OleDbCommand("SELECT Count(*) FROM Task" + type, myConnection);
            quan = command2.ExecuteScalar().ToString();
            textBox_AllNumber.Text = quan;
        }
            public void GiveTaskC(string type)
        {
            textBox_Answer.Visible = false;
            Button_Next.Enabled = true;
            Button_Back.Enabled = false;
            act = Convert.ToInt32(type); ;
            Num = 1;
            Task_Picture.Visible = true;
            TextBox_Task.Visible = false;
            Im = "Images//Task_" + type + "//Task//Task_" + type + "_1.png";
            System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            Task_Picture.Image = img;
        }



        public void GiveTask(string type)
        {
            textBox_Answer.Visible = false;
            Button_Next.Enabled = true;
            Button_Back.Enabled = false;
            act = Convert.ToInt32(type); ;
            Num = 1;

            Req = "SELECT Task_Text FROM Task" + type + " WHERE Number = ";
            q_s = Convert.ToString(Num);
            Req = Req + q_s;
            OleDbCommand command = new OleDbCommand(Req, myConnection);
            text = command.ExecuteScalar().ToString();
            if (text != "")
            {
                TextBox_Task.Visible = true;
                Task_Picture.Visible = false;
                TextBox_Task.Text = text;
            }

            else
            {
                Task_Picture.Visible = true;
                TextBox_Task.Visible = false;
                Im = "Images//Task_" + type + "//Task_" + type + "_1.png";
                System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                Task_Picture.Image = img;
            }
            Req_answ = "SELECT Answer FROM Task" + type + " WHERE Number = " + q_s;
            OleDbCommand command1 = new OleDbCommand(Req_answ, myConnection);
            answer = command1.ExecuteScalar().ToString();
            textBox_Answer.Text = answer;
        }



        string Req, Req_answ, quan, answer, text, q_s, Im;
        int act, i;



        int Num;



        string num_s;



        private void Button_Back_Click(object sender, EventArgs e)
        {
            textBox_Answer.Visible = false;
            for (i = 0; i < 27; i++)
            {
                if (i == act)
                {
                    break;
                }
            }
            num_s = Convert.ToString(i);

            if (num_s != "24" && num_s != "25" && num_s != "26" && num_s != "27")
            {
                Req = "SELECT Count(*) FROM Task" + num_s;
                OleDbCommand command2 = new OleDbCommand(Req, myConnection);
                quan = command2.ExecuteScalar().ToString();
                Quantity[0] = Convert.ToInt32(quan);

                Num--;
                if (Num == 1)
                    Button_Back.Enabled = false;
                if (Num > 1)
                    Button_Back.Enabled = true;
                if (Num < Quantity[0])
                    Button_Next.Enabled = true;

                Req = "SELECT Task_Text FROM Task" + num_s + " WHERE Number = ";
                q_s = Convert.ToString(Num);
                Req = Req + q_s;
                OleDbCommand command = new OleDbCommand(Req, myConnection);
                text = command.ExecuteScalar().ToString();
                textBox_Number.Text = q_s;


                if (text != "")
                {
                    TextBox_Task.Visible = true;
                    Task_Picture.Visible = false;
                    TextBox_Task.Text = text;
                }

                else
                {
                    Task_Picture.Visible = true;
                    TextBox_Task.Visible = false;
                    Im = "Images//Task_" + num_s + "//Task_" + num_s + "_" + Num + ".png";
                    System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                    fs.Close();
                    Task_Picture.Image = img;
                }


                Req_answ = "SELECT Answer FROM Task" + num_s + " WHERE Number = " + q_s;
                OleDbCommand command1 = new OleDbCommand(Req_answ, myConnection);
                answer = command1.ExecuteScalar().ToString();
                textBox_Answer.Text = answer;
            }
           else
            {
                Quantity[0] = Convert.ToInt32(20);
                textBox_AllNumber.Text = "20";
                Num--;
                if (Num == 1)
                    Button_Back.Enabled = false;
                if (Num > 1)
                    Button_Back.Enabled = true;
                if (Num < Quantity[0])
                    Button_Next.Enabled = true;
                textBox_Number.Text = Convert.ToString(Num);
                Task_Picture.Visible = true;
                TextBox_Task.Visible = false;
                Im = "Images//Task_" + num_s + "//Task//Task_" + num_s + "_" + Num + ".png";
                System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                Task_Picture.Image = img;
            }

        }


        private void Button_Next_Click(object sender, EventArgs e)
        {
            textBox_Answer.Visible = false;
            for (i = 0; i < 27; i ++)
                {
                    if (i == act)
                    {
                        break;
                    }
                }
            num_s = Convert.ToString(i);

            if (num_s != "24" && num_s != "25" && num_s != "26" && num_s != "27")
            {
                Req = "SELECT Count(*) FROM Task" + num_s;
                OleDbCommand command2 = new OleDbCommand(Req, myConnection);
                quan = command2.ExecuteScalar().ToString();
                Quantity[0] = Convert.ToInt32(quan);

                Num++;
                if (Num == Quantity[0])
                    Button_Next.Enabled = false;
                if (Num > 1)
                    Button_Back.Enabled = true;

                Req = "SELECT Task_Text FROM Task" + num_s + " WHERE Number = ";
                q_s = Convert.ToString(Num);
                Req = Req + q_s;
                OleDbCommand command = new OleDbCommand(Req, myConnection);
                text = command.ExecuteScalar().ToString();
                textBox_Number.Text = q_s;

                if (text != "")
                {
                    TextBox_Task.Visible = true;
                    Task_Picture.Visible = false;
                    TextBox_Task.Text = text;
                }

                else
                {
                    Task_Picture.Visible = true;
                    TextBox_Task.Visible = false;
                    Im = "Images//Task_" + num_s + "//Task_" + num_s + "_" + Num + ".png";
                    System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                    fs.Close();
                    Task_Picture.Image = img;
                }


                Req_answ = "SELECT Answer FROM Task" + num_s + " WHERE Number = " + q_s;
                OleDbCommand command1 = new OleDbCommand(Req_answ, myConnection);
                answer = command1.ExecuteScalar().ToString();
                textBox_Answer.Text = answer;
            }

            else

            {
                Quantity[0] = Convert.ToInt32(20);
                textBox_AllNumber.Text = "20";
                Num++;
                if (Num == Quantity[0])
                    Button_Next.Enabled = false;
                if (Num > 1)
                    Button_Back.Enabled = true;
                textBox_Number.Text = Convert.ToString(Num);
                Task_Picture.Visible = true;
                TextBox_Task.Visible = false;
                Im = "Images//Task_" + num_s + "//Task//Task_" + num_s + "_" + Num + ".png";
                System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                Task_Picture.Image = img;

            }

        }


        int[] Quantity = new int[27] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private void Task1_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("1");
            button_Answer.Enabled = true;
            GiveTask("1");
        }
        private void Task2_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("2");
            button_Answer.Enabled = true;
            GiveTask("2");
        }
        private void Task3_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("3");
            button_Answer.Enabled = true;
            GiveTask("3");
        }

        private void Task4_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("4");
            button_Answer.Enabled = true;
            GiveTask("4");
        }
        private void Task5_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("5");
            button_Answer.Enabled = true;
            GiveTask("5");
        }

        private void Task6_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("6");
            button_Answer.Enabled = true;
            GiveTask("6");
        }

        private void Task7_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("7");
            button_Answer.Enabled = true;
            GiveTask("7");
        }

        private void Task8_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("8");
            button_Answer.Enabled = true;
            GiveTask("8");
        }

        private void Task9_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("9");
            button_Answer.Enabled = true;
            GiveTask("9");
        }

        private void Task10_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("10");
            button_Answer.Enabled = true;
            GiveTask("10");
        }

        private void Task11_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("11");
            button_Answer.Enabled = true;
            GiveTask("11");
        }

        private void Task12_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("12");
            button_Answer.Enabled = true;
            GiveTask("12");
        }

        private void Task13_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("13");
            button_Answer.Enabled = true;
            GiveTask("13");
        }

        private void Task14_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("14");
            button_Answer.Enabled = true;
            GiveTask("14");
        }

        private void Task15_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("15");
            button_Answer.Enabled = true;
            GiveTask("15");
        }

        private void Task16_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("16");
            button_Answer.Enabled = true;
            GiveTask("16");
        }

        private void Task17_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("17");
            button_Answer.Enabled = true;
            GiveTask("17");
        }

        private void Task18_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("18");
            button_Answer.Enabled = true;
            GiveTask("18");
        }

        private void Task19_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("19");
            button_Answer.Enabled = true;
            GiveTask("19");
        }

        private void Task20_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("20");
            button_Answer.Enabled = true;
            GiveTask("20");
        }

        private void Task21_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("21");
            button_Answer.Enabled = true;
            GiveTask("21");
        }

        private void Task22_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("22");
            button_Answer.Enabled = true;
            GiveTask("22");
        }

        private void Task23_Button_Click(object sender, EventArgs e)
        {
            GiveQuan("23");
            button_Answer.Enabled = true;
            GiveTask("23");
        }

        private void Task24_Button_Click(object sender, EventArgs e)
        {
            textBox_Number.Text = "1";
            textBox_AllNumber.Text = "20";
            button_Answer.Enabled = false;
            GiveTaskC("24");
        }

        private void Task25_Button_Click(object sender, EventArgs e)
        {
            textBox_Number.Text = "1";
            textBox_AllNumber.Text = "20";
            button_Answer.Enabled = false;
            GiveTaskC("25");
        }

        private void Task26_Button_Click(object sender, EventArgs e)
        {
            textBox_Number.Text = "1";
            textBox_AllNumber.Text = "20";
            button_Answer.Enabled = false;
            GiveTaskC("26");
        }

        private void Task27_Button_Click(object sender, EventArgs e)
        {
            textBox_Number.Text = "1";
            textBox_AllNumber.Text = "20";
            button_Answer.Enabled = false;
            GiveTaskC("27");
        }

        private void button_Answer_Click(object sender, EventArgs e)
        {
            textBox_Answer.Visible = true;
        }



        Programm Form = new Programm();
        private void Back_button_Click(object sender, EventArgs e)
        {
            Form.Show();
            this.Hide();
        }

        private void Tasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Show();
            this.Hide();
        }

        private void Tasks_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }


}
