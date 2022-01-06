
namespace Kurs2021Csharp
{
    partial class RequestZdForm
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
            this.projNumber = new System.Windows.Forms.MaskedTextBox();
            this.date = new System.Windows.Forms.MaskedTextBox();
            this.taskNumber = new System.Windows.Forms.MaskedTextBox();
            this.customer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column_numb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_napr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_chas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_att = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_prim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.button_ok_req = new System.Windows.Forms.Button();
            this.button_back_req = new System.Windows.Forms.Button();
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
            this.status.Location = new System.Drawing.Point(924, 71);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(89, 21);
            this.status.TabIndex = 115;
            this.status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.status_KeyPress);
            // 
            // surname
            // 
            this.surname.FormattingEnabled = true;
            this.surname.Location = new System.Drawing.Point(700, 70);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(138, 21);
            this.surname.TabIndex = 114;
            this.surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname_KeyPress);
            // 
            // projNumber
            // 
            this.projNumber.Location = new System.Drawing.Point(566, 70);
            this.projNumber.Mask = "00-000";
            this.projNumber.Name = "projNumber";
            this.projNumber.Size = new System.Drawing.Size(57, 20);
            this.projNumber.TabIndex = 113;
            this.projNumber.ValidatingType = typeof(int);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(232, 71);
            this.date.Mask = "00/00/0000";
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(68, 20);
            this.date.TabIndex = 112;
            // 
            // taskNumber
            // 
            this.taskNumber.Location = new System.Drawing.Point(93, 70);
            this.taskNumber.Mask = "00/000";
            this.taskNumber.Name = "taskNumber";
            this.taskNumber.Size = new System.Drawing.Size(40, 20);
            this.taskNumber.TabIndex = 111;
            this.taskNumber.ValidatingType = typeof(System.DateTime);
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(371, 71);
            this.customer.MaxLength = 15;
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(114, 20);
            this.customer.TabIndex = 110;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(942, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 109;
            this.label8.Text = "  Статус";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(707, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 108;
            this.label6.Text = "            Фамилия инженера-конструктора";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(572, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 28);
            this.label5.TabIndex = 107;
            this.label5.Text = " Номер проекта";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(386, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 106;
            this.label3.Text = "Наименование       заказчика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Дата выдачи задания";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Номер задания";
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
            this.dataGridView.Location = new System.Drawing.Point(12, 147);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(1064, 198);
            this.dataGridView.TabIndex = 103;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(506, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 102;
            this.label7.Text = "По запросу найдено:";
            // 
            // button_ok_req
            // 
            this.button_ok_req.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ok_req.Location = new System.Drawing.Point(1001, 366);
            this.button_ok_req.Name = "button_ok_req";
            this.button_ok_req.Size = new System.Drawing.Size(75, 23);
            this.button_ok_req.TabIndex = 101;
            this.button_ok_req.Text = "Ок";
            this.button_ok_req.UseVisualStyleBackColor = true;
            this.button_ok_req.Click += new System.EventHandler(this.button_ok_req_Click);
            // 
            // button_back_req
            // 
            this.button_back_req.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back_req.Location = new System.Drawing.Point(19, 366);
            this.button_back_req.Name = "button_back_req";
            this.button_back_req.Size = new System.Drawing.Size(75, 23);
            this.button_back_req.TabIndex = 100;
            this.button_back_req.Text = "Назад";
            this.button_back_req.UseVisualStyleBackColor = true;
            this.button_back_req.Click += new System.EventHandler(this.button_back_req_Click);
            // 
            // RequestZdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1088, 397);
            this.Controls.Add(this.status);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.projNumber);
            this.Controls.Add(this.date);
            this.Controls.Add(this.taskNumber);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_ok_req);
            this.Controls.Add(this.button_back_req);
            this.MaximizeBox = false;
            this.Name = "RequestZdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Составление запроса по заданиям";
            this.Load += new System.EventHandler(this.RequestZdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.ComboBox surname;
        private System.Windows.Forms.MaskedTextBox projNumber;
        private System.Windows.Forms.MaskedTextBox date;
        private System.Windows.Forms.MaskedTextBox taskNumber;
        private System.Windows.Forms.TextBox customer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_numb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_napr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_kurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_chas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_att;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_prim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_ok_req;
        private System.Windows.Forms.Button button_back_req;
    }
}