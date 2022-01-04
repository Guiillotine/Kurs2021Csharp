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
            //if (!fmode) this->Text = L"Учет ПКД (Пользователь: " + gcnew String(login.c_str()) + ")";
            //else this->Text = L"Учет ПКД (Режим расширенного доступа)";
            //if (!fmode)
            {
                //this.toolStripButtonCorrect.Visible = false;
                //this.изменитьСтрокуToolStripMenuItem.Visible = false;
            }            
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
            form.Show();
        }

        private void toolStripButtonCorrect_Click(object sender, EventArgs e)
        {
            CorrectProjForm form = new CorrectProjForm();
            form.Show();
        }

        private void toolStripButtonRequest_Click(object sender, EventArgs e)
        {
            RequestProjForm form = new RequestProjForm();
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
        private void PKDForm_Activated(object sender, EventArgs e)
        {
          /*  while (dataGridView1->Rows->Count != 0)
                dataGridView1->Rows->Remove(dataGridView1->Rows[dataGridView1->Rows->Count - 1]);
            for (int x = 0; x < tablePKD.GetRowsNum(); x++)
            {
                dataGridView1->Rows->Add();
                dataGridView1->Rows[x]->Cells[0]->Value = (x + 1).ToString();
                dataGridView1->Rows[x]->Cells[1]->Value = gcnew String(tablePKD.GetTableRow(x).GetTaskNumber().c_str());
                dataGridView1->Rows[x]->Cells[2]->Value = gcnew String(tablePKD.GetTableRow(x).GetDateReg().c_str());
                dataGridView1->Rows[x]->Cells[3]->Value = gcnew String(tablePKD.GetTableRow(x).GetCipher().c_str());
                dataGridView1->Rows[x]->Cells[4]->Value = gcnew String(tablePKD.GetTableRow(x).GetProjName().c_str());
                dataGridView1->Rows[x]->Cells[5]->Value = gcnew String(tablePKD.GetTableRow(x).GetSurname().c_str());
                if ((tablePKD.GetTableRow(x).GetDateEnd() == "00.00.0000") || tablePKD.GetTableRow(x).GetDateEnd() == "  .  .")
                    dataGridView1->Rows[x]->Cells[6]->Value = "     -------";
                else dataGridView1->Rows[x]->Cells[6]->Value = gcnew String(tablePKD.GetTableRow(x).GetDateEnd().c_str());
                dataGridView1->Rows[x]->Cells[7]->Value = tablePKD.GetTableRow(x).GetVolume().ToString();
            }*/
        }
    }
}
