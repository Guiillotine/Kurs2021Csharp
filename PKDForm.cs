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
    public partial class PKDForm : Form
    {
        public PKDForm()
        {
            InitializeComponent();
        }

        private void PKDForm_Load(object sender, EventArgs e)
        {
            if (Globals.fmode == 0)
            {
                this.Text = "Учет ПКД (Пользователь: " + Globals.login + ")";
                this.toolStripButtonCorrect.Visible = false;
                this.изменитьСтрокуToolStripMenuItem.Visible = false;
            }
            else this.Text = "Учет ПКД (Режим расширенного доступа)";       
        }

        private void toolStripButtonOpenPKD_Click(object sender, EventArgs e)
        {
            RegZdForm form = new RegZdForm();
            form.Show();
            this.Hide();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AddProjForm form = new AddProjForm();
            form.ShowDialog();
        }

        private void toolStripButtonCorrect_Click(object sender, EventArgs e)
        {
            CorrectProjForm form = new CorrectProjForm();
            form.ShowDialog();
        }

        private void toolStripButtonRequest_Click(object sender, EventArgs e)
        {
            RequestProjForm form = new RequestProjForm();
            form.ShowDialog();
        }

        private void журналУчетаНомеровПКДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exp1 form = new Exp1();
            form.ShowDialog();
        }

        private void журналУчетаВыполненнойПКДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exp2 form = new Exp2();
            form.ShowDialog();
        }

        private void журналРегистрацииЗаданийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exp3 form = new Exp3();
            form.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.ShowDialog();
        }
        private void PKDForm_Activated(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count != 0)
                dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count - 1]);
            for (int x = 0; x < Globals.tablePKD.GetRowsNum(); x++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[x].Cells[0].Value = (x + 1).ToString();
                dataGridView1.Rows[x].Cells[1].Value = Globals.tablePKD.GetTableRow(x).GetTaskNumber();
                dataGridView1.Rows[x].Cells[2].Value = Globals.tablePKD.GetTableRow(x).GetDateReg();
                dataGridView1.Rows[x].Cells[3].Value = Globals.tablePKD.GetTableRow(x).GetCipher();
                dataGridView1.Rows[x].Cells[4].Value = Globals.tablePKD.GetTableRow(x).GetProjName();
                dataGridView1.Rows[x].Cells[5].Value = Globals.tablePKD.GetTableRow(x).GetSurname();
                if ((Globals.tablePKD.GetTableRow(x).GetDateEnd() == "00.00.0000") || Globals.tablePKD.GetTableRow(x).GetDateEnd() == "  .  .")
                    dataGridView1.Rows[x].Cells[6].Value = "     -------";
                else dataGridView1.Rows[x].Cells[6].Value = Globals.tablePKD.GetTableRow(x).GetDateEnd();
                dataGridView1.Rows[x].Cells[7].Value = Globals.tablePKD.GetTableRow(x).GetVolume().ToString();
            }
        }

        private void PKDForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
