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
    public partial class Programm : MaterialForm
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Questions.mdb;";
        private OleDbConnection myConnection;
        public Programm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Programm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            Application.Exit();
        }

        private void Test_Button_Click_1(object sender, EventArgs e)
        {
            Exam Form = new Exam();
            Form.Show();
            this.Hide();
        }
        private void Questions_Button_Click(object sender, EventArgs e)
        {
            Tasks Form = new Tasks();
            Form.Show();
            this.Hide();
        }

        private void InsertTasks_Button_Click(object sender, EventArgs e)
        {
            Insert_Tasks Form = new Insert_Tasks();
            Form.Show();
            this.Hide();
        }



        private void Task_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
