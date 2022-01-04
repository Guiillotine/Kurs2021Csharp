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
    public partial class RegZdForm : Form
    {
        public RegZdForm()
        {
            InitializeComponent();
        }
        private void RegZdForm_Load(object sender, EventArgs e)
        {
            if (Globals.fmode == 0)
            {
                this.Text = "Учет ПКД (Пользователь: " + Globals.login + ")";
                this.toolStripButtonCorrect.Visible = false;
                this.изменитьСтрокуToolStripMenuItem.Visible = false;
            }
            else this.Text = "Учет ПКД (Режим расширенного доступа)";
        }
        private void toolStripButtonOpenZd_Click(object sender, EventArgs e)
        {
            PKDForm form = new PKDForm();
            form.Show();
            this.Hide();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AddZdForm form = new AddZdForm();
            form.Show();
        }

        private void toolStripButtonCorrect_Click(object sender, EventArgs e)
        {
            CorrectZdForm form = new CorrectZdForm();
            form.Show();
        }

        private void toolStripButtonRequest_Click(object sender, EventArgs e)
        {
            RequestZdForm form = new RequestZdForm();
            form.Show();
        }

        private void журналУчетаНомеровПКДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exp1 form = new Exp1();
            form.Show();
        }

        private void журналУчетаВыполненнойПКДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exp2 form = new Exp2();
            form.Show();
        }

        private void журналРегистрацииЗаданийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exp3 form = new Exp3();
            form.Show();
        }
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.Show();
        }
        private void RegZdForm_Activated(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) ;
            while (dataGridView1.Rows.Count != 0) dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count - 1]);
            for (int i = 0; i < 10; i++) ;
            for (int i = 0; i < Globals.tableRegZd.GetRowsNum(); i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[1].Value = Globals.tableRegZd.GetTableRow(i).GetTaskNumber();
                dataGridView1.Rows[i].Cells[2].Value = Globals.tableRegZd.GetTableRow(i).GetDate();
                dataGridView1.Rows[i].Cells[3].Value = Globals.tableRegZd.GetTableRow(i).GetCustomer();
                dataGridView1.Rows[i].Cells[4].Value = Globals.tableRegZd.GetTableRow(i).GetTask();
                dataGridView1.Rows[i].Cells[5].Value = Globals.tableRegZd.GetTableRow(i).GetProjNumber();
                dataGridView1.Rows[i].Cells[6].Value = Globals.tableRegZd.GetTableRow(i).GetSurname();
                dataGridView1.Rows[i].Cells[7].Value = Globals.tableRegZd.GetTableRow(i).GetStatus();
                dataGridView1.Rows[i].Cells[8].Value = Globals.tableRegZd.GetTableRow(i).GetNote();
            }
        }
    }
}
