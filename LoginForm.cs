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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
			int f = 0;
			String password;
			String path = AppContext.BaseDirectory + "/" + Globals.fnameLogin;
			if (File.Exists(path))
			{
				FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
				StreamReader stream = new StreamReader(file, Encoding.GetEncoding(1251));
				int k = 0;
				while (!stream.EndOfStream)
				{
					Globals.login = stream.ReadLine();
					if (this.TBLogin.Text == Globals.login)
					{
						password = stream.ReadLine();
						if (this.TBPassword.Text == password)
						{
							f = 1;
							if (k == 0) Globals.fmode = 1;
							PKDForm form1 = new PKDForm(); RegZdForm form2 = new RegZdForm();
							if (Globals.tablePKD.Getfile(Globals.fnamePKD) == 0) MessageBox.Show("Не удалось открыть файл с таблицей \"Учет ПКД\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
							else
							{
								if (Globals.tableRegZd.Getfile(Globals.fnameRegZd) == 0) MessageBox.Show("Не удалось открыть файл с таблицей \"Регистрация заданий на проектирование\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
								else
								{
									if (Globals.fmode == 0) form1.Show(); else form2.Show();
									this.Hide();
									break;
								}
							}
						}
					}
					k++;
				}
				if (f == 0) MessageBox.Show("Неверно указан логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show("Не удалось открыть файл с логинами и паролями. Авторизация невозможна", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
