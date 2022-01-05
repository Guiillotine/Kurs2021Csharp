
namespace Kurs2021Csharp
{
    partial class CorrectProjForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.MaskedTextBox();
            this.dateEnd = new System.Windows.Forms.MaskedTextBox();
            this.volume = new System.Windows.Forms.MaskedTextBox();
            this.dateReg = new System.Windows.Forms.MaskedTextBox();
            this.cipher = new System.Windows.Forms.MaskedTextBox();
            this.projName = new System.Windows.Forms.TextBox();
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
            // taskNumber
            // 
            this.taskNumber.FormattingEnabled = true;
            this.taskNumber.Location = new System.Drawing.Point(107, 49);
            this.taskNumber.Name = "taskNumber";
            this.taskNumber.Size = new System.Drawing.Size(61, 21);
            this.taskNumber.TabIndex = 119;
            this.taskNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.taskNumber_KeyPress);
            // 
            // surname
            // 
            this.surname.Enabled = false;
            this.surname.FormattingEnabled = true;
            this.surname.Location = new System.Drawing.Point(655, 49);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(117, 21);
            this.surname.TabIndex = 118;
            this.surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 117;
            this.label5.Text = "№";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(28, 50);
            this.number.Mask = "00000";
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(42, 20);
            this.number.TabIndex = 116;
            this.number.ValidatingType = typeof(int);
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // dateEnd
            // 
            this.dateEnd.Enabled = false;
            this.dateEnd.Location = new System.Drawing.Point(826, 51);
            this.dateEnd.Mask = "00/00/0000";
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(68, 20);
            this.dateEnd.TabIndex = 115;
            // 
            // volume
            // 
            this.volume.Enabled = false;
            this.volume.Location = new System.Drawing.Point(970, 51);
            this.volume.Mask = "00000";
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(42, 20);
            this.volume.TabIndex = 114;
            this.volume.ValidatingType = typeof(int);
            // 
            // dateReg
            // 
            this.dateReg.Enabled = false;
            this.dateReg.Location = new System.Drawing.Point(226, 50);
            this.dateReg.Mask = "00/00/0000";
            this.dateReg.Name = "dateReg";
            this.dateReg.Size = new System.Drawing.Size(68, 20);
            this.dateReg.TabIndex = 113;
            // 
            // cipher
            // 
            this.cipher.Enabled = false;
            this.cipher.Location = new System.Drawing.Point(354, 50);
            this.cipher.Mask = "00-000";
            this.cipher.Name = "cipher";
            this.cipher.Size = new System.Drawing.Size(57, 20);
            this.cipher.TabIndex = 112;
            this.cipher.ValidatingType = typeof(int);
            // 
            // projName
            // 
            this.projName.Enabled = false;
            this.projName.Location = new System.Drawing.Point(477, 50);
            this.projName.MaxLength = 100;
            this.projName.Name = "projName";
            this.projName.Size = new System.Drawing.Size(133, 20);
            this.projName.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(949, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 110;
            this.label9.Text = "Объём проекта";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(809, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 109;
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
            this.dataGridView.Location = new System.Drawing.Point(12, 126);
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
            this.button_in_ok.Location = new System.Drawing.Point(1001, 210);
            this.button_in_ok.Name = "button_in_ok";
            this.button_in_ok.Size = new System.Drawing.Size(75, 23);
            this.button_in_ok.TabIndex = 107;
            this.button_in_ok.Text = "Ок";
            this.button_in_ok.UseVisualStyleBackColor = true;
            this.button_in_ok.Click += new System.EventHandler(this.button_in_ok_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(675, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 106;
            this.label6.Text = " Исполнитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "  Наименование проекта";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(341, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 104;
            this.label3.Text = "Шифр проекта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "   Дата регистрации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = " Номер задания";
            // 
            // button_in_back
            // 
            this.button_in_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_in_back.Location = new System.Drawing.Point(12, 210);
            this.button_in_back.Name = "button_in_back";
            this.button_in_back.Size = new System.Drawing.Size(75, 23);
            this.button_in_back.TabIndex = 101;
            this.button_in_back.Text = "Назад";
            this.button_in_back.UseVisualStyleBackColor = true;
            this.button_in_back.Click += new System.EventHandler(this.button_in_back_Click);
            // 
            // CorrectProjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 247);
            this.Controls.Add(this.taskNumber);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.number);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.dateReg);
            this.Controls.Add(this.cipher);
            this.Controls.Add(this.projName);
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
            this.Name = "CorrectProjForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование проектов";
            this.Load += new System.EventHandler(this.CorrectProjForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox taskNumber;
        private System.Windows.Forms.ComboBox surname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox number;
        private System.Windows.Forms.MaskedTextBox dateEnd;
        private System.Windows.Forms.MaskedTextBox volume;
        private System.Windows.Forms.MaskedTextBox dateReg;
        private System.Windows.Forms.MaskedTextBox cipher;
        private System.Windows.Forms.TextBox projName;
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