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
    public partial class RequestProjForm : Form
    {
        public RequestProjForm()
        {
            InitializeComponent();
        }

        private void button_in_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
