
namespace Kurs2021Csharp
{
    partial class CorrectZdForm
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
            this.status = new System.Windows.Forms.ComboBox();
            this.surname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.projNumber = new System.Windows.Forms.MaskedTextBox();
            this.date = new System.Windows.Forms.MaskedTextBox();
            this.taskNumber = new System.Windows.Forms.MaskedTextBox();
            this.task = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.TextBox();
            this.customer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column_numb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_napr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_chas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_att = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_prim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_in_ok = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_in_back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Принято",
            "В работе",
            "Отложено",
            "Отменено",
            "Выполнено"});
            this.status.Location = new System.Drawing.Point(817, 61);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(89, 21);
            this.status.TabIndex = 121;
            // 
            // surname
            // 
            this.surname.Enabled = false;
            this.surname.FormattingEnabled = true;
            this.surname.Location = new System.Drawing.Point(671, 61);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(117, 21);
            this.surname.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 119;
            this.label2.Text = "№";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(12, 61);
            this.number.Mask = "00000";
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(42, 20);
            this.number.TabIndex = 118;
            this.number.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(170, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 28);
            this.label10.TabIndex = 117;
            this.label10.Text = "Дата выдачи          задания";
            // 
            // projNumber
            // 
            this.projNumber.Enabled = false;
            this.projNumber.Location = new System.Drawing.Point(581, 61);
            this.projNumber.Mask = "00-000";
            this.projNumber.Name = "projNumber";
            this.projNumber.Size = new System.Drawing.Size(57, 20);
            this.projNumber.TabIndex = 116;
            this.projNumber.ValidatingType = typeof(int);
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(173, 61);
            this.date.Mask = "00/00/0000";
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(68, 20);
            this.date.TabIndex = 115;
            // 
            // taskNumber
            // 
            this.taskNumber.Enabled = false;
            this.taskNumber.Location = new System.Drawing.Point(94, 61);
            this.taskNumber.Mask = "00/000";
            this.taskNumber.Name = "taskNumber";
            this.taskNumber.Size = new System.Drawing.Size(40, 20);
            this.taskNumber.TabIndex = 114;
            this.taskNumber.ValidatingType = typeof(System.DateTime);
            // 
            // task
            // 
            this.task.Enabled = false;
            this.task.Location = new System.Drawing.Point(419, 61);
            this.task.MaxLength = 100;
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(133, 20);
            this.task.TabIndex = 113;
            // 
            // note
            // 
            this.note.Enabled = false;
            this.note.Location = new System.Drawing.Point(928, 61);
            this.note.MaxLength = 35;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(133, 20);
            this.note.TabIndex = 112;
            // 
            // customer
            // 
            this.customer.Enabled = false;
            this.customer.Location = new System.Drawing.Point(272, 61);
            this.customer.MaxLength = 15;
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(114, 20);
            this.customer.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(961, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 110;
            this.label9.Text = "Примечание";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(835, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 109;
            this.label8.Text = "  Статус";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_numb,
            this.Column_name,
            this.Column_fio,
            this.Column_napr,
            this.Column_kurs,
            this.Column_chas,
            this.Column_att,
            this.Column_prim});
            this.dataGridView.Location = new System.Drawing.Point(12, 139);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(1064, 64);
            this.dataGridView.TabIndex = 108;
            // 
            // Column_numb
            // 
            this.Column_numb.HeaderText = "Номер задания";
            this.Column_numb.Name = "Column_numb";
            this.Column_numb.ReadOnly = true;
            // 
            // Column_name
            // 
            this.Column_name.HeaderText = "Дата выдачи задания";
            this.Column_name.Name = "Column_name";
            this.Column_name.ReadOnly = true;
            // 
            // Column_fio
            // 
            this.Column_fio.HeaderText = "Наименование заказчика";
            this.Column_fio.Name = "Column_fio";
            this.Column_fio.ReadOnly = true;
            // 
            // Column_napr
            // 
            this.Column_napr.HeaderText = "Содержание задания";
            this.Column_napr.Name = "Column_napr";
            this.Column_napr.ReadOnly = true;
            // 
            // Column_kurs
            // 
            this.Column_kurs.HeaderText = "Номер проекта";
            this.Column_kurs.Name = "Column_kurs";
            this.Column_kurs.ReadOnly = true;
            // 
            // Column_chas
            // 
            this.Column_chas.HeaderText = "Фамилия инженера-конструктора";
            this.Column_chas.Name = "Column_chas";
            this.Column_chas.ReadOnly = true;
            // 
            // Column_att
            // 
            this.Column_att.HeaderText = "Статус";
            this.Column_att.Name = "Column_att";
            this.Column_att.ReadOnly = true;
            // 
            // Column_prim
            // 
            this.Column_prim.HeaderText = "Примечание";
            this.Column_prim.Name = "Column_prim";
            this.Column_prim.ReadOnly = true;
            // 
            // button_in_ok
            // 
            this.button_in_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_in_ok.Location = new System.Drawing.Point(1001, 219);
            this.button_in_ok.Name = "button_in_ok";
            this.button_in_ok.Size = new System.Drawing.Size(75, 23);
            this.button_in_ok.TabIndex = 107;
            this.button_in_ok.Text = "Ок";
            this.button_in_ok.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(668, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 106;
            this.label6.Text = "            Фамилия инженера-конструктора";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(588, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 28);
            this.label5.TabIndex = 105;
            this.label5.Text = " Номер проекта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 104;
            this.label4.Text = "Содержание задания";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(284, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 103;
            this.label3.Text = "Наименование       заказчика";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Номер задания";
            // 
            // button_in_back
            // 
            this.button_in_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_in_back.Location = new System.Drawing.Point(12, 219);
            this.button_in_back.Name = "button_in_back";
            this.button_in_back.Size = new System.Drawing.Size(75, 23);
            this.button_in_back.TabIndex = 101;
            this.button_in_back.Text = "Назад";
            this.button_in_back.UseVisualStyleBackColor = true;
            this.button_in_back.Click += new System.EventHandler(this.button_in_back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(465, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 15);
            this.label7.TabIndex = 100;
            this.label7.Text = "Отредактированная строка:";
            // 
            // CorrectZdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 268);
            this.Controls.Add(this.status);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.projNumber);
            this.Controls.Add(this.date);
            this.Controls.Add(this.taskNumber);
            this.Controls.Add(this.task);
            this.Controls.Add(this.note);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button_in_ok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_in_back);
            this.Controls.Add(this.label7);
            this.Name = "CorrectZdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование заданий";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.ComboBox surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox number;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox projNumber;
        private System.Windows.Forms.MaskedTextBox date;
        private System.Windows.Forms.MaskedTextBox taskNumber;
        private System.Windows.Forms.TextBox task;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.TextBox customer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_numb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_napr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_kurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_chas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_att;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_prim;
        private System.Windows.Forms.Button button_in_ok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_in_back;
        private System.Windows.Forms.Label label7;
    }
}