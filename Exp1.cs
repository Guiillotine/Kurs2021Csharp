using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs2021Csharp
{
    public partial class Exp1 : Form
    {
        public Exp1()
        {
            InitializeComponent();
        }
        private void Exp1_Load(object sender, EventArgs e)
        {
            if (Globals.tablePKD.GetRowsNum() != 0) this.from.Text = "1"; else this.from.Text = "0";
            this.to.Text = Globals.tablePKD.GetRowsNum().ToString();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            int f = 1;
            int from = 0, to = 0;
            if (this.from.Text == "") { MessageBox.Show("Поле оставлено пустым", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); f = 0; }
            else if (((Convert.ToInt32(this.from.Text) > Globals.tablePKD.GetRowsNum()) || (Convert.ToInt32(this.from.Text) == 0)) && (f == 1))
            {
                MessageBox.Show("Строки с данным номером не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f = 0;
            }
            if (this.to.Text == "")
            {
                if (f == 1)
                {
                    MessageBox.Show("Поле оставлено пустым", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    f = 0;
                }
            }
            else if (((Convert.ToInt32(this.to.Text) > Globals.tablePKD.GetRowsNum()) || (Convert.ToInt32(this.to.Text) == 0)) && (f == 1))
            {
                MessageBox.Show("Строки с данным номером не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f = 0;
            }
            else if (Convert.ToInt32(this.to.Text) < Convert.ToInt32(this.from.Text))
            {
                if (f == 1)
                {
                    MessageBox.Show("Границы диапазона экспортируемых строк указаны некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    f = 0;
                }
            }
            if ((this.fileName.Text == "") && (f == 1)) { MessageBox.Show("Введите название файла", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); f = 0; }
            if (f == 1)
            {
                from = Convert.ToInt32(this.from.Text);
                to = Convert.ToInt32(this.to.Text);
                Globals.tablePKD.ExpSmallTable(this.fileName.Text, from, to);
                MessageBox.Show("Таблица экспортирована в файл \"" + this.fileName.Text + "\"", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.fileName.Text = "";
            }
        }
    }
}
