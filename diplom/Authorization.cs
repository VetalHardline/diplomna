using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    internal class Authorization
    {
        static public string role, surname, User;

        static public void Authorization1(string login, string password)
        {
            try
            {
                DBConnection.msCommand.CommandText = @"SELECT name_role from sp_role, account WHERE Login = '" + login + "' and Password = '" + password + "' and account.id_role=sp_role.id_role";
                Object result = DBConnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    role = result.ToString();
                    User = login;
                }
                else
                {
                    role = null;
                    surname = null;
                }
            }
            catch
            {
                role = User = null;
                MessageBox.Show("Помилка при авторизації!");
            }
        }

        static public string AuthorizationName(string login)
        {
            try
            {
                DBConnection.msCommand.CommandText = @"SELECT Surname FROM account WHERE Login = '" + login + "'";
                Object result = DBConnection.msCommand.ExecuteScalar();
                surname=result.ToString();  
                return surname;
            }
            catch
            {
                return null;
            }
        } 
    }
}
