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
    public partial class Insert_Tasks : MaterialForm
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Questions.mdb;";
        private OleDbConnection myConnection;
        public Insert_Tasks()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Insert_Tasks_Load(object sender, EventArgs e)
        {
            Im = "Images//Confirm.png";
            System.IO.FileStream fs = new System.IO.FileStream(@Im, System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            Confirm = img;
        }
        Image Confirm;
        string Im;
        string num = "";
        string query;
        string way;
        string Req, quan;
        int quantity;
        string image_name;
        private void radioButton_SText_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox_TextS.Visible = true;
            pictureBox_Task.Visible = false;
            pictureBox_Task.Image = null;
            richTextBox_TextS.Text = "";
        }

        private void radioButton_SText_Click(object sender, EventArgs e)
        {
            button_ChooseIMG.Visible = false;
            richTextBox_TextS.Visible = true;
            pictureBox_Confirm.Image = null;
        }


        private void radioButton_SImage_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox_TextS.Visible = false;
            pictureBox_Task.Visible = true;
            pictureBox_Task.Image = null;
            richTextBox_TextS.Text = "";
        }


        private void radioButton_SImage_Click(object sender, EventArgs e)
        {
            button_ChooseIMG.Visible = true;
            pictureBox_Confirm.Image = null;
        }

        private void button_ChooseIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image files (*.PNG)|*PNG";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox_Task.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Ошибка", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            pictureBox_Task.Image = null;
        }


        private void button_Save_Click(object sender, EventArgs e)
        {
            if(richTextBox_TextS.Text != "" && textBox_Answer.Text != "" && num != "" || (pictureBox_Task != null && textBox_Answer.Text != "" && num != ""))
            {
                

                if (radioButton_SText.Checked == true)
                {
                    if (richTextBox_TextS.Text != "")
                    {
                        query = "INSERT INTO Task" + num + " (Task_Text, Answer) VALUES ('" + richTextBox_TextS.Text + "','" + textBox_Answer.Text + "')";
                        MessageBox.Show(query);
                        OleDbCommand command = new OleDbCommand(query, myConnection);
                        command.ExecuteNonQuery();
                        pictureBox_Confirm.Image = Confirm;
                    }
                    else
                        MessageBox.Show("Не введён текст задачи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (radioButton_SImage.Checked == true)
                {
                    if (pictureBox_Task != null)
                    {
                        Req = "SELECT Count(*) FROM Task" + num;
                        OleDbCommand command2 = new OleDbCommand(Req, myConnection);
                        quan = command2.ExecuteScalar().ToString();
                        quantity = Convert.ToInt32(quan);
                        quantity++;
                        quan = Convert.ToString(quantity);

                        image_name = "//Task_" + num + "_" + quan;

                        way = "Images//Task_" + num; 

                        if (pictureBox_Task.Image != null)
                        {
                            pictureBox_Task.Image.Save(way + image_name + ".png", System.Drawing.Imaging.ImageFormat.Png);
                            query = "INSERT INTO Task" + num + " (Answer) VALUES ('" + textBox_Answer.Text + "')";
                            MessageBox.Show(query);
                            OleDbCommand command = new OleDbCommand(query, myConnection);
                            command.ExecuteNonQuery();
                            pictureBox_Confirm.Image = Confirm;
                        }
                        else
                            MessageBox.Show("Не выбрано изображение задачи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (radioButton_SText.Checked != true && radioButton_SImage.Checked != true)
                    MessageBox.Show("Не выбран тип данных задачи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
               else
            {
                MessageBox.Show("Введите недостающие параметры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void comboBox_TaskTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = comboBox_TaskTypes.Text;
        }

        private void richTextBox_TextS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Answer_TextChanged(object sender, EventArgs e)
        {

        }

        Programm Form = new Programm();
        private void Insert_Tasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Show();
            this.Hide();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Form.Show();
            this.Hide();
        }
    }
}
