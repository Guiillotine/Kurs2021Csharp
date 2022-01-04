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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
			Globals.tablePKD.Getfile(Globals.fnamePKD);
			PKDForm form1 = new PKDForm();
            form1.Show();
            this.Hide();

			/*
            fstream file;
			string password;
			int f = 0;
			file.open(fnameLogin, fstream::in);
			if (!file.is_open()) MessageBox::Show("Не удалось открыть файл с логинами и паролями. Авторизация невозможна", "Ошибка", MessageBoxButtons::OK, MessageBoxIcon::Error);
			else
			{
				int k = 0;
				while (!file.eof())
				{
					file >> login;
					if (this->TBLogin->Text == gcnew String(login.c_str()))
					{ 
						file >> password;
						if (this->TBPassword->Text == gcnew String(password.c_str()))
						{
							f = 1;
							if (k == 0) fmode = 1;
							PKDForm^ form1 = gcnew PKDForm(); RegZdForm^ form2 = gcnew RegZdForm();
							if (tablePKD.Getfile(fnamePKD) == 0) MessageBox::Show("Не удалось открыть файл с таблицей \"Учет ПКД\"", "Ошибка", MessageBoxButtons::OK, MessageBoxIcon::Error);
							else
							{		
								if (tableRegZd.Getfile(fnameRegZd) == 0) MessageBox::Show("Не удалось открыть файл с таблицей \"Регистрация заданий на проектирование\"", "Ошибка", MessageBoxButtons::OK, MessageBoxIcon::Error);
								else
								{ 
									if (!fmode) form1->Show(); else form2->Show();
									LoginForm::Hide();
									break;
								}
							}
						}
					}
					k++;
				}
				if (!f) MessageBox::Show("Неверно указан логин или пароль", "Ошибка", MessageBoxButtons::OK, MessageBoxIcon::Error);
			} */






		}
	}
}
