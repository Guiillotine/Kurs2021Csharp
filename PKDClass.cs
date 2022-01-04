using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kurs2021Csharp
{
    class RowPKD
    {
        public RowPKD()
        {
        }
        /*void SetTaskNumber(string taskNumber)
        {
            this.taskNumber = taskNumber;
        }
        string GetTaskNumber()
        {
            return(taskNumber);
        }*/
        public void SetDateReg(string dateReg)
        {
            this.dateReg = dateReg;
        }
        public string GetDateReg()
        {
            return (dateReg);
        }
        public void SetCipher(string cipher)
        {
            this.cipher = cipher;
        }
        public string GetCipher()
        {
            return (cipher);
        }
        public void SetProjName(string projName)
        {
            this.projName = projName;
        }
        public string GetProjName()
        {
            return (projName);
        }
        /*void SetSurname(string surname)
         {
             this.surname = surname;
         }
         string GetSurname()
         {
             return(surname);
         }*/
        public void SetDateEnd(string dateEnd)
        {
            this.dateEnd = dateEnd;
        }
        public string GetDateEnd()
        {
            return (dateEnd);
        }
        public void SetVolume(int volume)
        {
            this.volume = volume;
        }
        public int GetVolume()
        {
            return (volume);
        }
        public void Putfile(string fnamePKD)
        {
            string path = AppContext.BaseDirectory;//AppDomain.CurrentDomain.BaseDirectory;//Directory.GetCurrentDirectory();
            FileStream f = new FileStream(path + "/1.txt", FileMode.Append);
            StreamWriter stream = new StreamWriter(f);
            stream.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", taskNumber, dateReg, cipher, projName, surname, dateEnd, volume);
            stream.Close();
            f.Close();
        }
        private String taskNumber;

        private String dateReg;
        private String cipher;
        private String projName;

        private String surname;

        private String dateEnd;
        private int volume;

    }






}


