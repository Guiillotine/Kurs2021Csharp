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
    }
}
