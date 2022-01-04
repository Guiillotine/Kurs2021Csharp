
namespace Kurs2021Csharp
{
    partial class AddProjForm
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
            this.taskNumber = new System.Windows.Forms.ComboBox();
            this.surname = new System.Windows.Forms.ComboBox();
            this.dateEnd = new System.Windows.Forms.MaskedTextBox();
            this.volume = new System.Windows.Forms.MaskedTextBox();
            this.dateReg = new System.Windows.Forms.MaskedTextBox();
            this.cipher = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.projName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView_in = new System.Windows.Forms.DataGridView();
            this.Column_numb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_napr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_chas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_att = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_in)).BeginInit();
            this.SuspendLayout();
            // 
            // taskNumber
            // 
            this.taskNumber.FormattingEnabled = true;
            this.taskNumber.Location = new System.Drawing.Point(50, 54);
            this.taskNumber.Name = "taskNumber";
            this.taskNumber.Size = new System.Drawing.Size(61, 21);
            this.taskNumber.TabIndex = 117;
            // 
            // surname
            // 
            this.surname.FormattingEnabled = true;
            this.surname.Location = new System.Drawing.Point(656, 56);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(117, 21);
            this.surname.TabIndex = 116;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(826, 56);
            this.dateEnd.Mask = "00/00/0000";
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(68, 20);
            this.dateEnd.TabIndex = 115;
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(970, 56);
            this.volume.Mask = "00000";
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(42, 20);
            this.volume.TabIndex = 114;
            this.volume.ValidatingType = typeof(int);
            // 
            // dateReg
            // 
            this.dateReg.Location = new System.Drawing.Point(189, 55);
            this.dateReg.Mask = "00/00/0000";
            this.dateReg.Name = "dateReg";
            this.dateReg.Size = new System.Drawing.Size(68, 20);
            this.dateReg.TabIndex = 113;
            // 
            // cipher
            // 
            this.cipher.Location = new System.Drawing.Point(354, 55);
            this.cipher.Mask = "00-000";
            this.cipher.Name = "cipher";
            this.cipher.Size = new System.Drawing.Size(57, 20);
            this.cipher.TabIndex = 112;
            this.cipher.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(474, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 15);
            this.label7.TabIndex = 111;
            this.label7.Text = "Добавленные проекты:";
            // 
            // projName
            // 
            this.projName.Location = new System.Drawing.Point(477, 55);
            this.projName.MaxLength = 100;
            this.projName.Name = "projName";
            this.projName.Size = new System.Drawing.Size(133, 20);
            this.projName.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(949, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 109;
            this.label9.Text = "Объём проекта";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(812, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 108;
            this.label8.Text = "Дата завершения";
            // 
            // dataGridView_in
            // 
            this.dataGridView_in.AllowUserToAddRows = false;
            this.dataGridView_in.AllowUserToDeleteRows = false;
            this.dataGridView_in.AllowUserToResizeColumns = false;
            this.dataGridView_in.AllowUserToResizeRows = false;
            this.dataGridView_in.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_in.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_in.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_numb,
            this.Column_name,
            this.Column_fio,
            this.Column_napr,
            this.Column_kurs,
            this.Column_chas,
            this.Column_att});
            this.dataGridView_in.Location = new System.Drawing.Point(12, 125);
            this.dataGridView_in.Name = "dataGridView_in";
            this.dataGridView_in.ReadOnly = true;
            this.dataGridView_in.RowHeadersVisible = false;
            this.dataGridView_in.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_in.Size = new System.Drawing.Size(1064, 105);
            this.dataGridView_in.TabIndex = 107;
            // 
            // Column_numb
            // 
            this.Column_numb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_numb.HeaderText = "Номер задания";
            this.Column_numb.Name = "Column_numb";
            this.Column_numb.ReadOnly = true;
            this.Column_numb.Width = 90;
            // 
            // Column_name
            // 
            this.Column_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_name.FillWeight = 459.8131F;
            this.Column_name.HeaderText = "Дата регистрации";
            this.Column_name.Name = "Column_name";
            this.Column_name.ReadOnly = true;
            // 
            // Column_fio
            // 
            this.Column_fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_fio.FillWeight = 28.03738F;
            this.Column_fio.HeaderText = "Шифр проекта";
            this.Column_fio.Name = "Column_fio";
            this.Column_fio.ReadOnly = true;
            this.Column_fio.Width = 105;
            // 
            // Column_napr
            // 
            this.Column_napr.FillWeight = 28.03738F;
            this.Column_napr.HeaderText = "Наименование проекта";
            this.Column_napr.Name = "Column_napr";
            this.Column_napr.ReadOnly = true;
            // 
            // Column_kurs
            // 
            this.Column_kurs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_kurs.FillWeight = 28.03738F;
            this.Column_kurs.HeaderText = "Исполнитель";
            this.Column_kurs.Name = "Column_kurs";
            this.Column_kurs.ReadOnly = true;
            this.Column_kurs.Width = 200;
            // 
            // Column_chas
            // 
            this.Column_chas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_chas.FillWeight = 28.03738F;
            this.Column_chas.HeaderText = "Дата завершения проекта";
            this.Column_chas.Name = "Column_chas";
            this.Column_chas.ReadOnly = true;
            this.Column_chas.Width = 140;
            // 
            // Column_att
            // 
            this.Column_att.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_att.FillWeight = 28.03738F;
            this.Column_att.HeaderText = "Объем проекта";
            this.Column_att.Name = "Column_att";
            this.Column_att.ReadOnly = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(1001, 245);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 106;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(676, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 105;
            this.label6.Text = " Исполнитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 104;
            this.label4.Text = "  Наименование проекта";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(341, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 103;
            this.label3.Text = "Шифр проекта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "   Дата регистрации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Номер задания";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 245);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 100;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AddProjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 285);
            this.Controls.Add(this.taskNumber);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.dateReg);
            this.Controls.Add(this.cipher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.projName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView_in);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Name = "AddProjForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление проекта";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_in)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox taskNumber;
        private System.Windows.Forms.ComboBox surname;
        private System.Windows.Forms.MaskedTextBox dateEnd;
        private System.Windows.Forms.MaskedTextBox volume;
        private System.Windows.Forms.MaskedTextBox dateReg;
        private System.Windows.Forms.MaskedTextBox cipher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox projName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_numb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_napr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_kurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_chas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_att;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
    }
}