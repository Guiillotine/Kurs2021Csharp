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
    public partial class RequestZdForm : Form
    {
        public RequestZdForm()
        {
            InitializeComponent();
        }
        private void RequestZdForm_Load(object sender, EventArgs e)
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

        private void button_back_req_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_ok_req_Click(object sender, EventArgs e)
        {
			RowRegZd row = new RowRegZd();
			int f = 0, ix = 0; 
			while (dataGridView.Rows.Count != 0) dataGridView.Rows.Remove(dataGridView.Rows[dataGridView.Rows.Count - 1]);
			for (int i = 0; i < Globals.tableRegZd.GetRowsNum(); i++) 
			{
				row = Globals.tableRegZd.GetTableRow(i);
				if ((this.taskNumber.Text == "  .") || (row.GetTaskNumber() == this.taskNumber.Text));
				else continue;

				if ((this.date.Text == "  .  .") || (row.GetDate() == this.date.Text));
				else continue;

				if ((this.customer.Text == "") || (row.GetCustomer() == this.customer.Text));
				else continue;

				if ((this.projNumber.Text == "  -") || (row.GetProjNumber() == this.projNumber.Text));
				else continue;

				if ((this.surname.Text == "") || (row.GetSurname() == this.surname.Text));
				else continue;

				if ((this.status.Text == "") || (row.GetStatus() == this.status.Text)                    );
				else continue;
			f = 1;
			dataGridView.Rows.Add();
			dataGridView.Rows [ix].Cells [0].Value = row.GetTaskNumber();
			dataGridView.Rows [ix].Cells [1].Value = row.GetDate();
			dataGridView.Rows [ix].Cells [2].Value = row.GetCustomer();
			dataGridView.Rows [ix].Cells [3].Value = row.GetTask();
			dataGridView.Rows [ix].Cells [4].Value = row.GetProjNumber();
			dataGridView.Rows [ix].Cells [5].Value = row.GetSurname();
			dataGridView.Rows[ix].Cells[6].Value = row.GetStatus();
			dataGridView.Rows [ix].Cells [7].Value = row.GetNote();
			ix++;
			}
			if (f == 0) MessageBox.Show("По вашему запросу результатов не найдено", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
