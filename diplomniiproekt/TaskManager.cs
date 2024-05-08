using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplomniiproekt
{
    public partial class TaskManager : Form
    {
        public TaskManager()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            ManagerClass.GetData();
            dataGridView1.DataSource = ManagerClass.dtStatus;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
        static public string nomer, Datenachalo, DateFinish, needtodo, Donee;
        private void Edit_Button_Click(object sender, EventArgs e)
        {
            nomer = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            needtodo = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //Datenachalo = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //DateFinish = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Donee = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            groupBox2.Visible = true;

            
            needtoDo_txt.Text = needtodo;
            Done_txt.Text = Donee;
        }

        private void backAdd_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string del = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult delet = MessageBox.Show("Ви дійсно хочете видалити цю задачу?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delet == DialogResult.Yes)
                {
                    ManagerClass.DeleteData(del);
                    ManagerClass.GetData();
                    dataGridView1.DataSource = ManagerClass.dtStatus;
                    MessageBox.Show("Задача видалена!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                }
            }

            catch
            {
                MessageBox.Show("Помилка при видаленні даних!");
            }
        }

        private void needtoDotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if(!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Donetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void needtoDo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Done_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Donetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Edit_Task_Click(object sender, EventArgs e)
        {
            DateTime ts1 = dateTimePicker1.Value;
            DateTime ts2 = dateTimePicker2.Value;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd"; // Вказуєм формат дати, який в моїй базі данних
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

           // if (ts1 > ts2)  //Перевірка на дати(дата завершення не може бути раніше дати початку)
          //  {
            //    MessageBox.Show("Дата завершення не може бути раніше дати початку", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             //   return;
          //  }

            if (needtoDo_txt.Text == needtodo)
            {
                if (needtoDo_txt.Text != "" && Done_txt.Text != "")
                {
                    if (ManagerClass.EditData(int.Parse(nomer), needtoDo_txt.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), Done_txt.Text))
                    {
                        MessageBox.Show("Успішне редагування!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManagerClass.GetData();
                        groupBox2.Visible = false;
                        needtoDo_txt.Text = "";
                        Done_txt.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Заповніть всі обов'язкові поля!");
                }
            }
            else
            {
                string sql = @"SELECT Id FROM todo WHERE ToDo = '" + "' ";
                DBConnection.msCommand.CommandText = sql;
                Object result = DBConnection.msCommand.ExecuteScalar();
                if(result != null)
                {
                    MessageBox.Show("У вас вже є така задача");
                    needtoDo_txt.Text = "";
                }
                else
                {
                    if (needtoDo_txt.Text != "" && Done_txt.Text != "")
                    {
                        if (ManagerClass.EditData(int.Parse(nomer), needtoDo_txt.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), Done_txt.Text))
                        {
                            MessageBox.Show("Успішне редагування!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ManagerClass.GetData();
                            groupBox2.Visible = false;
                            needtoDo_txt.Text = "";
                            Done_txt.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заповніть всі обов'язкові поля!");
                    } 
                }
            }
        }

        private void backEdit_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void Add_Task_Click(object sender, EventArgs e)
        {
            DateTime ts1 = dateTimePicker1.Value;
            DateTime ts2 = dateTimePicker2.Value;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd"; // Вказуєм формат дати, який в моїй базі данних
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

            if(ts1 > ts2)  //Перевірка на дати(дата завершення не може бути раніше дати початку)
            {
                MessageBox.Show("Дата завершення не може бути раніше дати початку", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (needtoDotxt.Text != "" && dateTimePicker1.Text != "" && dateTimePicker2.Text != "" && Donetxt.Text != "") //Перевірка на дублювання таску
            {
                string sql = @"SELECT Id FROM todo WHERE ToDo = '" + needtoDotxt.Text + "'";
                DBConnection.msCommand.CommandText = sql;
                Object result = DBConnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас вже є такий таск!", "Дублювання запису", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateFinishTxt.Text =  "";
                    needtoDotxt.Text = "";
                    Donetxt.Text = "";
                }
                else
                {
                    if (ManagerClass.AddData(needtoDotxt.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), Donetxt.Text))
                    {
                        MessageBox.Show("Задача успішно додалась!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox1.Visible = false;
                      
                        needtoDotxt.Text = "";
                        Donetxt.Text = "";
                        ManagerClass.GetData();
                    }
                    else
                    {
                        MessageBox.Show("Задача не була додана!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заповніть усі обов'язкові поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
