using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace diplom
{
    internal partial class Form1
    {
        private MySqlConnection connection;
        public Form1()
        {
            /*InitializeComponent();
            string connectionString = "server=localhost;user=root;database=diplom;password=2003;";//подключение к базе
            MySqlConnection connection = new MySqlConnection(connectionString);
            /*
            connection.Open();

            string sql = "SELECT Done FROM todo WHERE id = 2";
            MySqlCommand command = new MySqlCommand(sql, connection);

            string answerfromdb = command.ExecuteScalar().ToString;

            connection.Close();*/



        }

        private void addButton_Click(object sender, EventArgs e)
        {
           // DbController.AddNewData(DeadLineToDoLabel, ToDoText, DoneText, ToDoDataGridView, connection);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization form = new Authorization();
            form.Show();
        }
    }
}
