using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kurs2021Csharp
{
    public partial class AddZdForm : Form
    {
        public AddZdForm()
        {
            InitializeComponent();
        }
		private void AddZdForm_Load(object sender, EventArgs e)
		{
			ix = 0;
			string path = AppContext.BaseDirectory + "/" + Globals.fnameLogin;
			string str;
			if (File.Exists(path))
			{
				FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read);
				StreamReader stream = new StreamReader(f, Encoding.GetEncoding(1251));
				int k = 0;
				while (!stream.EndOfStream)
				{
					str = stream.ReadLine();
					if (k != 0) surname.Items.AddRange(new object[] { str });
					str = stream.ReadLine();
					k++;
				}
				stream.Close();
				f.Close();
			}
			else
			{
				MessageBox.Show("Не удалось открыть файл cо списком исполнителей для заполнения таблицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
		}
		private void button_in_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void button_in_ok_Click(object sender, EventArgs e)
		{
			RowRegZd row = new RowRegZd();
			int f = 1;

			if (this.taskNumber.Text != "  .") row.SetTaskNumber(this.taskNumber.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.date.Text != "  .  .") row.SetDate(this.date.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.customer.Text != "") row.SetCustomer(this.customer.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.task.Text != "") row.SetTask(this.task.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.projNumber.Text != "  -") row.SetProjNumber(this.projNumber.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.surname.Text != "") row.SetSurname(this.surname.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.status.Text != "") row.SetStatus(this.status.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.note.Text != "") row.SetNote(this.note.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
			if (f == 1)
			{
				Globals.tableRegZd.AddStr(row);
				dataGridView_in.Rows.Add();
				dataGridView_in.Rows[ix].Cells[0].Value = row.GetTaskNumber();
				dataGridView_in.Rows[ix].Cells[1].Value = row.GetDate();
				dataGridView_in.Rows[ix].Cells[2].Value = row.GetCustomer();
				dataGridView_in.Rows[ix].Cells[3].Value = row.GetTask();
				dataGridView_in.Rows[ix].Cells[4].Value = row.GetProjNumber();
				dataGridView_in.Rows[ix].Cells[5].Value = row.GetSurname();
				dataGridView_in.Rows[ix].Cells[6].Value = row.GetStatus();
				dataGridView_in.Rows[ix].Cells[7].Value = row.GetNote();
				ix++;
				this.taskNumber.Text = "";
				this.date.Text = "";
				this.customer.Text = "";
				this.task.Text = "";
				this.projNumber.Text = "";
				this.surname.Text = "";
				this.status.Text = "";
				this.note.Text = "";
			}
		}
		public int ix = 0;

        private void surname_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = true;
		}
        private void status_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = true;
		}
    }
}
