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
	public partial class CorrectZdForm : Form
	{
		private void CorrectZdForm_Load(object sender, EventArgs e)
		{
			dataGridView.Rows.Add();
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
		public CorrectZdForm()
		{
			InitializeComponent();
		}

		private void button_in_back_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void button_in_ok_Click(object sender, EventArgs e)
		{
			RowRegZd row = new RowRegZd();
			int f = 1;
			int numberStr = 0;

	if (this.number.Text != "") numberStr = Convert.ToInt32(this.number.Text);
	else if (this.number.Text == "") { MessageBox.Show("Введите номер строки для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); f = 0; }
	else if ((Convert.ToInt32(this.number.Text) > Globals.tableRegZd.GetRowsNum()) || (Convert.ToInt32(this.number.Text) == 0)) { MessageBox.Show("Строки с данным номером нет в списке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); f = 0; }

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
		Globals.tableRegZd.EditStr(numberStr, row);
		Globals.tableRegZd.Putfile(Globals.fnameRegZd);
		dataGridView.Rows[0].Cells[0].Value = row.GetTaskNumber();
		dataGridView.Rows[0].Cells[1].Value = row.GetDate();
		dataGridView.Rows[0].Cells[2].Value = row.GetCustomer();
		dataGridView.Rows[0].Cells[3].Value = row.GetTask();
		dataGridView.Rows[0].Cells[4].Value = row.GetProjNumber();
		dataGridView.Rows[0].Cells[5].Value = row.GetSurname();
		dataGridView.Rows[0].Cells[6].Value = row.GetStatus();
		dataGridView.Rows[0].Cells[7].Value = row.GetNote();
		this.number.Text = "";
	}
	}
		private void number_TextChanged(object sender, EventArgs e)
		{
			RowRegZd row = new RowRegZd();
			int numberStr = 0;
			if (this.number.Text != "") numberStr = Convert.ToInt32(this.number.Text);
			if ((numberStr <= Globals.tableRegZd.GetRowsNum()) && (numberStr > 0))
			{
				this.taskNumber.Enabled = true;
				this.date.Enabled = true;
				this.customer.Enabled = true;
				this.task.Enabled = true;
				this.projNumber.Enabled = true;
				this.surname.Enabled = true;
				this.status.Enabled = true;
				this.note.Enabled = true;
				row = Globals.tableRegZd.GetTableRow(numberStr - 1);
				this.taskNumber.Text = row.GetTaskNumber();
				this.date.Text = row.GetDate();
				this.customer.Text = row.GetCustomer();
				this.task.Text = row.GetTask();
				this.projNumber.Text = row.GetProjNumber();
				this.surname.Text = row.GetSurname();
				this.status.Text = row.GetStatus();
				this.note.Text = row.GetNote();
			}
			else
			{
				this.taskNumber.Text = "";
				this.date.Text = "";
				this.customer.Text = "";
				this.task.Text = "";
				this.projNumber.Text = "";
				this.surname.Text = "";
				this.status.Text = "";
				this.note.Text = "";
				this.taskNumber.Enabled = false;
				this.date.Enabled = false;
				this.customer.Enabled = false;
				this.task.Enabled = false;
				this.projNumber.Enabled = false;
				this.surname.Enabled = false;
				this.status.Enabled = false;
				this.note.Enabled = false;
			}
		}

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
