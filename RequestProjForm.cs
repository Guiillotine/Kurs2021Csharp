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
    public partial class RequestProjForm : Form
    {
        public RequestProjForm()
        {
            InitializeComponent();
        }
        private void RequestProjForm_Load(object sender, EventArgs e)
        {
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
				surname.Items.AddRange(new object[] { "" });
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
			RowPKD row = new RowPKD();
			int f = 0, ix = 0;
			while (dataGridView.Rows.Count != 0) dataGridView.Rows.Remove(dataGridView.Rows[dataGridView.Rows.Count - 1]);
			for (int i = 0; i < Globals.tablePKD.GetRowsNum(); i++) 
			{
				row = Globals.tablePKD.GetTableRow(i);
				if ((this.taskNumber.Text == "  .")|| (row.GetTaskNumber() == this.taskNumber.Text));
				else continue;

				if ((this.dateReg.Text == "  .  .")||(row.GetDateReg() == this.dateReg.Text));
				else continue;

				if ((this.cipher.Text == "  -")||(row.GetCipher() == this.cipher.Text));
				else continue;

				if ((this.projName.Text == "")||(row.GetProjName() == this.projName.Text));
				else continue;

				if ((this.surname.Text == "") || (row.GetSurname() == this.surname.Text));
				else continue;

				if ((this.dateEnd.Text == "  .  .") || (row.GetDateEnd() == this.dateEnd.Text));
				else continue;

				if (this.volume.Text != "")
				{
				if ((this.sign.Text == "=") || (this.sign.Text == "")) if (row.GetVolume() != Convert.ToInt32(this.volume.Text)) continue;
				if (this.sign.Text == ">=") if (row.GetVolume() < Convert.ToInt32(this.volume.Text)) continue;
				if (this.sign.Text == "<=") if (row.GetVolume() > Convert.ToInt32(this.volume.Text)) continue;
				}
			f = 1;
			dataGridView.Rows.Add();
			dataGridView.Rows [ix].Cells [0].Value = row.GetTaskNumber();
			dataGridView.Rows [ix].Cells [1].Value = row.GetDateReg();
			dataGridView.Rows [ix].Cells [2].Value = row.GetCipher();
			dataGridView.Rows [ix].Cells [3].Value = row.GetProjName();
			dataGridView.Rows [ix].Cells [4].Value = row.GetSurname();
			if (row.GetDateEnd() == "00.00.0000") dataGridView.Rows [ix].Cells [5].Value = "     -------";
			else dataGridView.Rows [ix].Cells [5].Value = row.GetDateEnd();
			dataGridView.Rows [ix].Cells [6].Value = row.GetVolume().ToString();
			ix++;
			}
			if (f == 0) MessageBox.Show("По вашему запросу результатов не найдено", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void surname_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = true;
		}
        private void sign_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = true;
		}
    }
}
