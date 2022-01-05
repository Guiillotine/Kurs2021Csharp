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
    public partial class CorrectProjForm : Form
    {
        public CorrectProjForm()
        {
            InitializeComponent();
        }
        private void CorrectProjForm_Load(object sender, EventArgs e)
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

			if (Globals.fmode == 0)
			{
				this.dateEnd.Enabled = false;
				this.volume.Enabled = false;
				for (int i = 0; i < Globals.tableRegZd.GetRowsNum(); i++)
				{
					if (Globals.tableRegZd.GetTableRow(i).GetSurname() == Globals.login)
					{
						for (int j = 0; j < Globals.tablePKD.GetRowsNum(); j++)
						{
							if (Globals.tablePKD.GetTableRow(j).GetTaskNumber() == Globals.tableRegZd.GetTableRow(i).GetTaskNumber()) break;
							if (j == Globals.tablePKD.GetRowsNum() - 1) taskNumber.Items.AddRange(new object[] { Globals.tableRegZd.GetTableRow(i).GetTaskNumber() });
						}
					}
				}
			}
			else for (int i = 0; i < Globals.tableRegZd.GetRowsNum(); i++) taskNumber.Items.AddRange(new object[] { Globals.tableRegZd.GetTableRow(i).GetTaskNumber() });
		}
        private void button_in_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_in_ok_Click(object sender, EventArgs e)
        {
			RowPKD row = new RowPKD();
			int f = 1;
			int numberStr = 0;
	
			if (this.number.Text != "") numberStr = Convert.ToInt32(this.number.Text);
			else if (this.number.Text == "") { MessageBox.Show("Введите номер строки для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); f = 0; }
			else if ((Convert.ToInt32(this.number.Text) > Globals.tablePKD.GetRowsNum()) || (Convert.ToInt32(this.number.Text) == 0)) { MessageBox.Show("Строки с данным номером нет в списке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); f = 0; }

			if (this.taskNumber.Text != "  .") row.SetTaskNumber(this.taskNumber.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.dateReg.Text != "  .  .") row.SetDateReg(this.dateReg.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.cipher.Text != "  -") row.SetCipher(this.cipher.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.projName.Text != "") row.SetProjName(this.projName.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.surname.Text != "") row.SetSurname(this.surname.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.dateEnd.Text == "  .  .") row.SetDateEnd("00.00.0000");
			else row.SetDateEnd(this.dateEnd.Text);

			if (this.volume.Text == "")  row.SetVolume(0);
			else row.SetVolume(Convert.ToInt32(this.volume.Text));
			if (f == 1)
			{
				Globals.tablePKD.EditStr(numberStr, row);
				Globals.tablePKD.Putfile(Globals.fnamePKD);
				dataGridView.Rows[0].Cells[0].Value = row.GetTaskNumber();
				dataGridView.Rows[0].Cells[1].Value = row.GetDateReg();
				dataGridView.Rows[0].Cells[2].Value = row.GetCipher();
				dataGridView.Rows[0].Cells[3].Value = row.GetProjName();
				dataGridView.Rows[0].Cells[4].Value = row.GetSurname();
				if (row.GetDateEnd() == "00.00.0000") dataGridView.Rows[0].Cells[5].Value = "     -------";
				else dataGridView.Rows[0].Cells[5].Value = row.GetDateEnd();
				dataGridView.Rows[0].Cells[6].Value = row.GetVolume().ToString();
				this.number.Text = "";
			}
	}

        private void number_TextChanged(object sender, EventArgs e)
        {
			RowPKD row = new RowPKD(); ;
			int numberStr = 0;
			if (this.number.Text != "") numberStr = Convert.ToInt32(this.number.Text);
			if ((numberStr <= Globals.tablePKD.GetRowsNum()) && (numberStr > 0))
			{
				this.taskNumber.Enabled = true;
				this.dateReg.Enabled = true;
				this.cipher.Enabled = true;
				this.projName.Enabled = true;
				this.surname.Enabled = true;
				this.dateEnd.Enabled = true;
				this.volume.Enabled = true;
				row = Globals.tablePKD.GetTableRow(numberStr - 1);
				this.taskNumber.Text = row.GetTaskNumber();
				this.dateReg.Text = row.GetDateReg();
				this.cipher.Text = row.GetCipher();
				this.projName.Text = row.GetProjName();
				this.surname.Text = row.GetSurname();
				this.dateEnd.Text = row.GetDateEnd();
				this.volume.Text = row.GetVolume().ToString();
			}
			else
			{
				this.taskNumber.Text = "";
				this.dateReg.Text = "";
				this.cipher.Text = "";
				this.projName.Text = "";
				this.surname.Text = "";
				this.dateEnd.Text = "";
				this.volume.Text = "";
				this.taskNumber.Enabled = false;
				this.dateReg.Enabled = false;
				this.cipher.Enabled = false;
				this.projName.Enabled = false;
				this.surname.Enabled = false;
				this.dateEnd.Enabled = false;
				this.volume.Enabled = false;
			}
		}

        private void taskNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = true;
		}
        private void surname_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = true;
		}
    }
}
