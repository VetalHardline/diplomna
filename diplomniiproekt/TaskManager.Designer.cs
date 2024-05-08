namespace diplomniiproekt
{
    partial class TaskManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Back = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backAdd = new System.Windows.Forms.Button();
            this.Add_Task = new System.Windows.Forms.Button();
            this.Donetxt = new System.Windows.Forms.TextBox();
            this.needtoDotxt = new System.Windows.Forms.TextBox();
            this.dateFinishTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backEdit = new System.Windows.Forms.Button();
            this.Edit_Task = new System.Windows.Forms.Button();
            this.Done_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.needtoDo_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateFinish_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCompletion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(1045, 726);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(112, 32);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(964, 86);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(193, 47);
            this.Add_Button.TabIndex = 1;
            this.Add_Button.Text = "Додати задачу";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(964, 209);
            this.Edit_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(193, 47);
            this.Edit_Button.TabIndex = 2;
            this.Edit_Button.Text = "Редагувати задачу";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(964, 342);
            this.Remove_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(193, 47);
            this.Remove_Button.TabIndex = 3;
            this.Remove_Button.Text = "Видалити";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Необхідно зробити:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ToDo,
            this.DateStart,
            this.DateCompletion,
            this.Done});
            this.dataGridView1.Location = new System.Drawing.Point(247, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 756);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.backAdd);
            this.groupBox1.Controls.Add(this.Add_Task);
            this.groupBox1.Controls.Add(this.Donetxt);
            this.groupBox1.Controls.Add(this.needtoDotxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 392);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додавання";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // backAdd
            // 
            this.backAdd.Location = new System.Drawing.Point(6, 359);
            this.backAdd.Name = "backAdd";
            this.backAdd.Size = new System.Drawing.Size(199, 27);
            this.backAdd.TabIndex = 11;
            this.backAdd.Text = "Отмена";
            this.backAdd.UseVisualStyleBackColor = true;
            this.backAdd.Click += new System.EventHandler(this.backAdd_Click);
            // 
            // Add_Task
            // 
            this.Add_Task.Location = new System.Drawing.Point(6, 317);
            this.Add_Task.Name = "Add_Task";
            this.Add_Task.Size = new System.Drawing.Size(199, 36);
            this.Add_Task.TabIndex = 10;
            this.Add_Task.Text = "Додати";
            this.Add_Task.UseVisualStyleBackColor = true;
            this.Add_Task.Click += new System.EventHandler(this.Add_Task_Click);
            // 
            // Donetxt
            // 
            this.Donetxt.Location = new System.Drawing.Point(9, 271);
            this.Donetxt.Name = "Donetxt";
            this.Donetxt.Size = new System.Drawing.Size(196, 26);
            this.Donetxt.TabIndex = 9;
            this.Donetxt.TextChanged += new System.EventHandler(this.Donetxt_TextChanged);
            this.Donetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Donetxt_KeyPress);
            // 
            // needtoDotxt
            // 
            this.needtoDotxt.Location = new System.Drawing.Point(6, 58);
            this.needtoDotxt.Name = "needtoDotxt";
            this.needtoDotxt.Size = new System.Drawing.Size(199, 26);
            this.needtoDotxt.TabIndex = 8;
            this.needtoDotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.needtoDotxt_KeyPress);
            // 
            // dateFinishTxt
            // 
            this.dateFinishTxt.Location = new System.Drawing.Point(1300, 496);
            this.dateFinishTxt.Name = "dateFinishTxt";
            this.dateFinishTxt.Size = new System.Drawing.Size(160, 26);
            this.dateFinishTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Зроблено(статус):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Виберіть дату закінчення:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker4);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.backEdit);
            this.groupBox2.Controls.Add(this.Edit_Task);
            this.groupBox2.Controls.Add(this.Done_txt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.needtoDo_txt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(22, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 342);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редагування";
            // 
            // backEdit
            // 
            this.backEdit.Location = new System.Drawing.Point(6, 309);
            this.backEdit.Name = "backEdit";
            this.backEdit.Size = new System.Drawing.Size(199, 27);
            this.backEdit.TabIndex = 12;
            this.backEdit.Text = "Отмена";
            this.backEdit.UseVisualStyleBackColor = true;
            this.backEdit.Click += new System.EventHandler(this.backEdit_Click);
            // 
            // Edit_Task
            // 
            this.Edit_Task.Location = new System.Drawing.Point(6, 267);
            this.Edit_Task.Name = "Edit_Task";
            this.Edit_Task.Size = new System.Drawing.Size(199, 36);
            this.Edit_Task.TabIndex = 11;
            this.Edit_Task.Text = "Редагувати";
            this.Edit_Task.UseVisualStyleBackColor = true;
            this.Edit_Task.Click += new System.EventHandler(this.Edit_Task_Click);
            // 
            // Done_txt
            // 
            this.Done_txt.Location = new System.Drawing.Point(9, 235);
            this.Done_txt.Name = "Done_txt";
            this.Done_txt.Size = new System.Drawing.Size(196, 26);
            this.Done_txt.TabIndex = 10;
            this.Done_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Done_txt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Зроблено(статус):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // needtoDo_txt
            // 
            this.needtoDo_txt.Location = new System.Drawing.Point(6, 54);
            this.needtoDo_txt.Name = "needtoDo_txt";
            this.needtoDo_txt.Size = new System.Drawing.Size(199, 26);
            this.needtoDo_txt.TabIndex = 9;
            this.needtoDo_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.needtoDo_txt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Необхідно зробити:";
            // 
            // dateFinish_txt
            // 
            this.dateFinish_txt.Location = new System.Drawing.Point(1330, 448);
            this.dateFinish_txt.Name = "dateFinish_txt";
            this.dateFinish_txt.Size = new System.Drawing.Size(160, 26);
            this.dateFinish_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Виберіть дату закінчення:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Виберіть дату початку:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 189);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Виберіть дату початку:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(5, 113);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker3.TabIndex = 14;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(5, 185);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker4.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Номер";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ToDo
            // 
            this.ToDo.DataPropertyName = "ToDo";
            this.ToDo.HeaderText = "Потрібно зробити";
            this.ToDo.Name = "ToDo";
            this.ToDo.ReadOnly = true;
            this.ToDo.Width = 220;
            // 
            // DateStart
            // 
            this.DateStart.DataPropertyName = "DateStart";
            this.DateStart.HeaderText = "Дата Початку";
            this.DateStart.Name = "DateStart";
            this.DateStart.ReadOnly = true;
            this.DateStart.Width = 130;
            // 
            // DateCompletion
            // 
            this.DateCompletion.DataPropertyName = "DateCompletion";
            this.DateCompletion.HeaderText = "Дата закінчення";
            this.DateCompletion.Name = "DateCompletion";
            this.DateCompletion.ReadOnly = true;
            this.DateCompletion.Width = 130;
            // 
            // Done
            // 
            this.Done.DataPropertyName = "Done";
            this.Done.HeaderText = "Зроблено";
            this.Done.Name = "Done";
            this.Done.ReadOnly = true;
            this.Done.Width = 159;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1169, 771);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.dateFinishTxt);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.dateFinish_txt);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Back);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskManager";
            this.Load += new System.EventHandler(this.TaskManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_Task;
        private System.Windows.Forms.TextBox Donetxt;
        private System.Windows.Forms.TextBox needtoDotxt;
        private System.Windows.Forms.TextBox dateFinishTxt;
        private System.Windows.Forms.Button Edit_Task;
        private System.Windows.Forms.TextBox Done_txt;
        private System.Windows.Forms.TextBox needtoDo_txt;
        private System.Windows.Forms.TextBox dateFinish_txt;
        private System.Windows.Forms.Button backAdd;
        private System.Windows.Forms.Button backEdit;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCompletion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Done;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label8;
    }
}