
namespace Kurs2021Csharp
{
    partial class PKDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PKDForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenPKD = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenZd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCorrect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRequest = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRegZdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPKDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналУчетаНомеровПКДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналУчетаВыполненнойПКДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналРегистрацииЗаданийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_numb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_napr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_chas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_att = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenPKD,
            this.toolStripButtonOpenZd,
            this.toolStripButtonAdd,
            this.toolStripButtonCorrect,
            this.toolStripButtonRequest});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpenPKD
            // 
            this.toolStripButtonOpenPKD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenPKD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenPKD.Image")));
            this.toolStripButtonOpenPKD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenPKD.Name = "toolStripButtonOpenPKD";
            this.toolStripButtonOpenPKD.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpenPKD.Text = "Регистрация задания на проектирование";
            this.toolStripButtonOpenPKD.Click += new System.EventHandler(this.toolStripButtonOpenPKD_Click);
            // 
            // toolStripButtonOpenZd
            // 
            this.toolStripButtonOpenZd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenZd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenZd.Image")));
            this.toolStripButtonOpenZd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenZd.Name = "toolStripButtonOpenZd";
            this.toolStripButtonOpenZd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpenZd.Text = "Учет ПКД";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "Добавить строку";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonCorrect
            // 
            this.toolStripButtonCorrect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCorrect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCorrect.Image")));
            this.toolStripButtonCorrect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCorrect.Name = "toolStripButtonCorrect";
            this.toolStripButtonCorrect.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCorrect.Text = "Изменить строку";
            this.toolStripButtonCorrect.Click += new System.EventHandler(this.toolStripButtonCorrect_Click);
            // 
            // toolStripButtonRequest
            // 
            this.toolStripButtonRequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRequest.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRequest.Image")));
            this.toolStripButtonRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRequest.Name = "toolStripButtonRequest";
            this.toolStripButtonRequest.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRequest.Text = "Найти";
            this.toolStripButtonRequest.Click += new System.EventHandler(this.toolStripButtonRequest_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.экспортToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRegZdToolStripMenuItem,
            this.openPKDToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.файлToolStripMenuItem.Text = "Журнал";
            // 
            // openRegZdToolStripMenuItem
            // 
            this.openRegZdToolStripMenuItem.Name = "openRegZdToolStripMenuItem";
            this.openRegZdToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.openRegZdToolStripMenuItem.Text = "Регистрация задания на проектирование";
            this.openRegZdToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonOpenPKD_Click);
            // 
            // openPKDToolStripMenuItem
            // 
            this.openPKDToolStripMenuItem.Name = "openPKDToolStripMenuItem";
            this.openPKDToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.openPKDToolStripMenuItem.Text = "Учет проектно-конструкторской документации";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтрокуToolStripMenuItem,
            this.изменитьСтрокуToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьСтрокуToolStripMenuItem
            // 
            this.добавитьСтрокуToolStripMenuItem.Name = "добавитьСтрокуToolStripMenuItem";
            this.добавитьСтрокуToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.добавитьСтрокуToolStripMenuItem.Text = "Добавить строку";
            this.добавитьСтрокуToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // изменитьСтрокуToolStripMenuItem
            // 
            this.изменитьСтрокуToolStripMenuItem.Name = "изменитьСтрокуToolStripMenuItem";
            this.изменитьСтрокуToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.изменитьСтрокуToolStripMenuItem.Text = "Изменить строку";
            this.изменитьСтрокуToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonCorrect_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.найтиToolStripMenuItem.Text = "Найти...";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonRequest_Click);
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.журналУчетаНомеровПКДToolStripMenuItem,
            this.журналУчетаВыполненнойПКДToolStripMenuItem,
            this.журналРегистрацииЗаданийToolStripMenuItem});
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            // 
            // журналУчетаНомеровПКДToolStripMenuItem
            // 
            this.журналУчетаНомеровПКДToolStripMenuItem.Name = "журналУчетаНомеровПКДToolStripMenuItem";
            this.журналУчетаНомеровПКДToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.журналУчетаНомеровПКДToolStripMenuItem.Text = "Журнал учета номеров ПКД";
            this.журналУчетаНомеровПКДToolStripMenuItem.Click += new System.EventHandler(this.журналУчетаНомеровПКДToolStripMenuItem_Click);
            // 
            // журналУчетаВыполненнойПКДToolStripMenuItem
            // 
            this.журналУчетаВыполненнойПКДToolStripMenuItem.Name = "журналУчетаВыполненнойПКДToolStripMenuItem";
            this.журналУчетаВыполненнойПКДToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.журналУчетаВыполненнойПКДToolStripMenuItem.Text = "Журнал учета выполненной ПКД";
            this.журналУчетаВыполненнойПКДToolStripMenuItem.Click += new System.EventHandler(this.журналУчетаВыполненнойПКДToolStripMenuItem_Click);
            // 
            // журналРегистрацииЗаданийToolStripMenuItem
            // 
            this.журналРегистрацииЗаданийToolStripMenuItem.Name = "журналРегистрацииЗаданийToolStripMenuItem";
            this.журналРегистрацииЗаданийToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.журналРегистрацииЗаданийToolStripMenuItem.Text = "Журнал регистрации заданий ";
            this.журналРегистрацииЗаданийToolStripMenuItem.Click += new System.EventHandler(this.журналРегистрацииЗаданийToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(446, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Учет проектно-конструкторской документации";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column_numb,
            this.Column_name,
            this.Column_fio,
            this.Column_napr,
            this.Column_kurs,
            this.Column_chas,
            this.Column_att});
            this.dataGridView1.Location = new System.Drawing.Point(4, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1342, 618);
            this.dataGridView1.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // Column_numb
            // 
            this.Column_numb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_numb.HeaderText = "       Номер задания";
            this.Column_numb.Name = "Column_numb";
            this.Column_numb.ReadOnly = true;
            this.Column_numb.Width = 140;
            // 
            // Column_name
            // 
            this.Column_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_name.HeaderText = "                Дата регистрации";
            this.Column_name.Name = "Column_name";
            this.Column_name.ReadOnly = true;
            this.Column_name.Width = 200;
            // 
            // Column_fio
            // 
            this.Column_fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_fio.HeaderText = "                    Шифр проекта";
            this.Column_fio.Name = "Column_fio";
            this.Column_fio.ReadOnly = true;
            this.Column_fio.Width = 200;
            // 
            // Column_napr
            // 
            this.Column_napr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_napr.HeaderText = "                       Наименование проекта";
            this.Column_napr.Name = "Column_napr";
            this.Column_napr.ReadOnly = true;
            this.Column_napr.Width = 270;
            // 
            // Column_kurs
            // 
            this.Column_kurs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_kurs.HeaderText = "        Исполнитель";
            this.Column_kurs.Name = "Column_kurs";
            this.Column_kurs.ReadOnly = true;
            this.Column_kurs.Width = 130;
            // 
            // Column_chas
            // 
            this.Column_chas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_chas.HeaderText = "                Дата завершения                                  проекта";
            this.Column_chas.Name = "Column_chas";
            this.Column_chas.ReadOnly = true;
            this.Column_chas.Width = 200;
            // 
            // Column_att
            // 
            this.Column_att.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_att.HeaderText = "            Объем проекта";
            this.Column_att.Name = "Column_att";
            this.Column_att.ReadOnly = true;
            this.Column_att.Width = 155;
            // 
            // PKDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PKDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет ПКД";
            this.Activated += new System.EventHandler(this.PKDForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PKDForm_FormClosed);
            this.Load += new System.EventHandler(this.PKDForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenPKD;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenZd;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonCorrect;
        private System.Windows.Forms.ToolStripButton toolStripButtonRequest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRegZdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPKDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналУчетаНомеровПКДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналУчетаВыполненнойПКДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналРегистрацииЗаданийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_numb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_napr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_kurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_chas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_att;
    }
}