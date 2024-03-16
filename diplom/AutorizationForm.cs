using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class AutorizationForm : Form
    {
        static public string loginActive;
        static public string whois;
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB(); //подключаемсяк к базе данних через мой клас
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.Text != "" &&  password.Text != "")
            {
                Authorization.Authorization1(login.Text, password.Text);
                switch (Authorization.role)
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунту не існує");
                            break;
                        }
                    case "Адмін":
                        {
                            loginActive = login.Text;
                            whois = "Адмін";
                            Authorization.User = login.Text;
                            
                            string surname = Authorization.AuthorizationName(login.Text);
                            Authorization.surname = surname;
                            MessageBox.Show(surname + ", раді вас бачити в нашому застосунку", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
