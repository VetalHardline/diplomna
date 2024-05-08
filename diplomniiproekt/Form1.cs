using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplomniiproekt
{
    public partial class Form1 : Form
    {
        static public string loginActive;
        static public string whois;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            DBConnection.ConnectionDB(); //подключаемсяк к базе данних через мой клас
        }

        private void Authoriz_Click(object sender, EventArgs e)
        {
            if (login.Text != "" && password.Text != "")
            {
                Authorization.Authorization1(login.Text, password.Text);
                switch (Authorization.role)
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунту не існує", "Перевірьте данні і спробуйте знову", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            login.Text = "";
                            password.Text = "";
                            break;
                        }
                    case "Адмін":
                        {
                            loginActive = login.Text;
                            whois = "Адмін";
                            Authorization.User = login.Text;

                            string surname = Authorization.AuthorizationName(login.Text);
                            Authorization.surname = surname;
                            MessageBox.Show(surname + ", раді вас бачити в нашому застосунку", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();

                            TaskManager tasks = new TaskManager();
                            tasks.Show();
                            break;
                        }
                    case "Користувач":
                        {
                            loginActive = login.Text;
                            whois = "Користувач";
                            Authorization.User = login.Text;

                            string surname = Authorization.AuthorizationName(login.Text);
                            Authorization.surname = surname;
                            MessageBox.Show(surname + ", раді вас бачити в нашому застосунку", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();

                            TaskManager tasks = new TaskManager();
                            tasks.Show();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Заповніть усі обов'зкові поля!", "Заповнення полей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
