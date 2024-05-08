using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplomniiproekt
{
    internal class ManagerClass
    {
        static public DataTable dtStatus = new DataTable();

        static public void GetData()// за допомогою цієї функціїї ми бачимо данні на формі
        {
            try
            {
                DBConnection.msCommand.CommandText = "SELECT * FROM todo";
                dtStatus.Clear();
                DBConnection.msDataAdapter.SelectCommand = DBConnection.msCommand;
                DBConnection.msDataAdapter.Fill(dtStatus);
            }
            catch
            {
                MessageBox.Show("Помилка при отриманні данних!", "Помилка... ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        static public bool AddData(string ToDo, string DateStart, string DateCompletion, string Done)
        {
            try
            {
                DBConnection.msCommand.CommandText = "INSERT INTO todo VALUES(null, '" + ToDo + "', '" + DateStart + "', '" + DateCompletion + "', '" + Done + "')";
                if (DBConnection.msCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Помилка при додаванні запису!", "Помилка... ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditData(int Id, string ToDo, string DateStart, string DateCompletion, string Done)
        {
            try
            {
                DBConnection.msCommand.CommandText = "UPDATE todo SET ToDo  = '" + ToDo + "' WHERE Id = '" + Id + "';";
                DBConnection.msCommand.CommandText = "UPDATE todo SET DateStart  = '" + DateStart + "' WHERE Id = '" + Id + "';";
                DBConnection.msCommand.CommandText = "UPDATE todo SET DateCompletion  = '" + DateCompletion + "' WHERE Id = '" + Id + "';";
                DBConnection.msCommand.CommandText = "UPDATE todo SET Done  = '" + Done + "' WHERE Id = '" + Id + "';";
                if (DBConnection.msCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Помилка при редагуванні запису!", "Помилка... ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public void DeleteData(string del)
        {
            try
            {
                DBConnection.msCommand.CommandText = "DELETE FROM todo WHERE Id = '" + del + "';";
                DBConnection.msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні вибраного запису!", "Помилка... ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
