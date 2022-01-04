
namespace Kurs2021Csharp
{
    partial class RequestProjForm
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
            this.surname = new System.Windows.Forms.ComboBox();
            this.sign = new System.Windows.Forms.ComboBox();
            this.dateEnd = new System.Windows.Forms.MaskedTextBox();
            this.volume = new System.Windows.Forms.MaskedTextBox();
            this.taskNumber = new System.Windows.Forms.MaskedTextBox();
            this.dateReg = new System.Windows.Forms.MaskedTextBox();
            this.cipher = new System.Windows.Forms.MaskedTextBox();
            this.projName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.button_in_ok = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_in_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // surname
            // 
            this.surname.FormattingEnabled = true;
            this.surname.Location = new System.Drawing.Point(651, 60);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(117, 21);
            this.surname.TabIndex = 115;
            // 
            // sign
            // 
            this.sign.FormattingEnabled = true;
            this.sign.Items.AddRange(new object[] {
            "=",
            "<=",
            ">="});
            this.sign.Location = new System.Drawing.Point(945, 60);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(35, 21);
            this.sign.TabIndex = 114;
            this.sign.Text = "=";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(823, 61);
            this.dateEnd.Mask = "00/00/0000";
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(68, 20);
            this.dateEnd.TabIndex = 113;
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(986, 60);
            this.volume.Mask = "00000";
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(42, 20);
            this.volume.TabIndex = 112;
            this.volume.ValidatingType = typeof(int);
            // 
            // taskNumber
            // 
            this.taskNumber.Location = new System.Drawing.Point(53, 60);
            this.taskNumber.Mask = "00/00";
            this.taskNumber.Name = "taskNumber";
            this.taskNumber.Size = new System.Drawing.Size(40, 20);
            this.taskNumber.TabIndex = 111;
            this.taskNumber.ValidatingType = typeof(System.DateTime);
            // 
            // dateReg
            // 
            this.dateReg.Location = new System.Drawing.Point(186, 60);
            this.dateReg.Mask = "00/00/0000";
            this.dateReg.Name = "dateReg";
            this.dateReg.Size = new System.Drawing.Size(68, 20);
            this.dateReg.TabIndex = 110;
            // 
            // cipher
            // 
            this.cipher.Location = new System.Drawing.Point(351, 60);
            this.cipher.Mask = "00-000";
            this.cipher.Name = "cipher";
            this.cipher.Size = new System.Drawing.Size(57, 20);
            this.cipher.TabIndex = 109;
            this.cipher.ValidatingType = typeof(int);
            // 
            // projName
            // 
            this.projName.Location = new System.Drawing.Point(474, 60);
            this.projName.MaxLength = 50;
            this.projName.Name = "projName";
            this.projName.Size = new System.Drawing.Size(133, 20);
            this.projName.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(481, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 107;
            this.label7.Text = "По запросу найдено:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(942, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 106;
            this.label9.Text = "Объём проекта";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(809, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 105;
            this.label8.Text = "Дата завершения";
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
            this.Column_att});
            this.dataGridView.Location = new System.Drawing.Point(12, 143);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(1064, 228);
            this.dataGridView.TabIndex = 104;
            // 
            // Column_numb
            // 
            this.Column_numb.HeaderText = "Номер задания";
            this.Column_numb.Name = "Column_numb";
            this.Column_numb.ReadOnly = true;
            // 
            // Column_name
            // 
            this.Column_name.HeaderText = "Дата регистрации";
            this.Column_name.Name = "Column_name";
            this.Column_name.ReadOnly = true;
            // 
            // Column_fio
            // 
            this.Column_fio.HeaderText = "Шифр проекта";
            this.Column_fio.Name = "Column_fio";
            this.Column_fio.ReadOnly = true;
            // 
            // Column_napr
            // 
            this.Column_napr.HeaderText = "Наименование проекта";
            this.Column_napr.Name = "Column_napr";
            this.Column_napr.ReadOnly = true;
            // 
            // Column_kurs
            // 
            this.Column_kurs.HeaderText = "Исполнитель";
            this.Column_kurs.Name = "Column_kurs";
            this.Column_kurs.ReadOnly = true;
            // 
            // Column_chas
            // 
            this.Column_chas.HeaderText = "Дата завершения проекта";
            this.Column_chas.Name = "Column_chas";
            this.Column_chas.ReadOnly = true;
            // 
            // Column_att
            // 
            this.Column_att.HeaderText = "Объем проекта";
            this.Column_att.Name = "Column_att";
            this.Column_att.ReadOnly = true;
            // 
            // button_in_ok
            // 
            this.button_in_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_in_ok.Location = new System.Drawing.Point(1001, 389);
            this.button_in_ok.Name = "button_in_ok";
            this.button_in_ok.Size = new System.Drawing.Size(75, 23);
            this.button_in_ok.TabIndex = 103;
            this.button_in_ok.Text = "Ок";
            this.button_in_ok.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(671, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 102;
            this.label6.Text = " Исполнитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "  Наименование проекта";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(335, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 100;
            this.label3.Text = "Шифр проекта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "   Дата регистрации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Номер задания";
            // 
            // button_in_back
            // 
            this.button_in_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_in_back.Location = new System.Drawing.Point(12, 389);
            this.button_in_back.Name = "button_in_back";
            this.button_in_back.Size = new System.Drawing.Size(75, 23);
            this.button_in_back.TabIndex = 97;
            this.button_in_back.Text = "Назад";
            this.button_in_back.UseVisualStyleBackColor = true;
            this.button_in_back.Click += new System.EventHandler(this.button_in_back_Click);
            // 
            // RequestProjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 423);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.taskNumber);
            this.Controls.Add(this.dateReg);
            this.Controls.Add(this.cipher);
            this.Controls.Add(this.projName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button_in_ok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_in_back);
            this.Name = "RequestProjForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Составление запроса по проектам";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox surname;
        private System.Windows.Forms.ComboBox sign;
        private System.Windows.Forms.MaskedTextBox dateEnd;
        private System.Windows.Forms.MaskedTextBox volume;
        private System.Windows.Forms.MaskedTextBox taskNumber;
        private System.Windows.Forms.MaskedTextBox dateReg;
        private System.Windows.Forms.MaskedTextBox cipher;
        private System.Windows.Forms.TextBox projName;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Button button_in_ok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_in_back;
    }
}