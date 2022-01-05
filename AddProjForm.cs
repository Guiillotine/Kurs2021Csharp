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
    public partial class AddProjForm : Form
    {
        public AddProjForm()
        {
            InitializeComponent();
        }

		private void AddProjForm_Load(object sender, EventArgs e)
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

		private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
			RowPKD row = new RowPKD(); //String login = "л"; int fmode = 1;
			int f = 1;
			if (this.taskNumber.Text != "") row.SetTaskNumber(this.taskNumber.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.dateReg.Text != "  .  .") row.SetDateReg(this.dateReg.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.cipher.Text != "  -") row.SetCipher(this.cipher.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if (this.projName.Text != "") row.SetProjName(this.projName.Text);
			else if (f == 1) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

			if ((this.surname.Text == "") && (f == 1)) { f = 0; MessageBox.Show("Введены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
			if ((this.surname.Text != Globals.login) && (f == 1) && (Globals.fmode == 0)) { f = 0; MessageBox.Show("Укажите свою фамилию в поле \"Исполнитель\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			else row.SetSurname(this.surname.Text);

			if (this.dateEnd.Text == "  .  .") row.SetDateEnd("00.00.0000");
			else row.SetDateEnd(this.dateEnd.Text);

			if (this.volume.Text == "")  row.SetVolume(0);
			else row.SetVolume(Convert.ToInt32(this.volume.Text)); 

			if (f == 1)
			{
			Globals.tablePKD.AddStr(row);
			row.Putfile(Globals.fnamePKD);
			dataGridView_in.Rows.Add();
			dataGridView_in.Rows[ix].Cells[0].Value = row.GetTaskNumber();
			dataGridView_in.Rows[ix].Cells[1].Value = row.GetDateReg();
			dataGridView_in.Rows[ix].Cells[2].Value = row.GetCipher();
			dataGridView_in.Rows[ix].Cells[3].Value = row.GetProjName();
			dataGridView_in.Rows[ix].Cells[4].Value = row.GetSurname();
			if (row.GetDateEnd() == "00.00.0000") dataGridView_in.Rows[ix].Cells[5].Value = "     -------";
			else dataGridView_in.Rows[ix].Cells[5].Value = row.GetDateEnd();
			dataGridView_in.Rows[ix].Cells[6].Value = row.GetVolume().ToString();
			ix++;
			this.taskNumber.Text = "";
			this.dateReg.Text = "";
			this.cipher.Text = "";
			this.projName.Text = "";
			this.surname.Text = "";
			this.dateEnd.Text = "";
			this.volume.Text = "";
			}
		}
		public int ix = 0;
    }
}
