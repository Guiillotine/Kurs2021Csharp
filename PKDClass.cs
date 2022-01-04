using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kurs2021Csharp
{
    public class RowPKD
    {
        public RowPKD()
        {
        }
        public RowPKD(string taskNumber, string dateReg, string cipher, string projName, string surname, string dateEnd, int volume)
        {
            this.taskNumber = taskNumber;
            this.dateReg = dateReg;
            this.cipher = cipher;
            this.projName = projName;
            this.surname = surname;
            this.dateEnd = dateEnd;
            this.volume = volume;
        }
        public void SetTaskNumber(string taskNumber)
        {
            this.taskNumber = taskNumber;
        }
        public string GetTaskNumber()
        {
            return(taskNumber);
        }
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
        public void SetSurname(string surname)
         {
             this.surname = surname;
         }
        public string GetSurname()
         {
             return(surname);
         }
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
            string path = AppContext.BaseDirectory;
            FileStream f = new FileStream(path + "/" + fnamePKD, FileMode.Append);
            //StreamWriter stream = new StreamWriter(f);
            StreamWriter stream = new StreamWriter(f, Encoding.GetEncoding(1251));
            stream.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", taskNumber, dateReg, cipher, projName, surname, dateEnd, volume);
            stream.Close();
            f.Close();
        }
        public object Clone()
        {
            return new RowPKD(taskNumber, dateReg, cipher, projName, surname, dateEnd, volume);
        }

        private String taskNumber;

        private String dateReg;
        private String cipher;
        private String projName;

        private String surname;

        private String dateEnd;
        private int volume;

    }

    public class TablePKD
    {
    public TablePKD()
    {
        rowsNum = 0;
    }
    public void AddStr(RowPKD tableRow)
    {
        if (rowsNum > 0) ArrResize();
        tableRows[rowsNum] = (RowPKD)tableRow.Clone();
        //tableRows[rowsNum] = tableRow;
        rowsNum++;
    }
    public void EditStr(int numberStr, RowPKD tableRow)
    {
        tableRows[numberStr - 1] = tableRow;
    }
    public void ArrResize()
    {
        RowPKD[] tableRows2 = new RowPKD[rowsNum + 1];
        for (int i = 0; i < rowsNum; i++) tableRows2[i] = (RowPKD)tableRows[i].Clone();
        tableRows = tableRows2;
    }
    public int GetRowsNum()
    {
        return (rowsNum);
    }
    public RowPKD GetTableRow(int index)
    {
        return tableRows[index];
    }
    public void Putfile(string fnamePKD)
    {
        string path = AppContext.BaseDirectory;
        FileStream f = new FileStream(path + "/" + fnamePKD, FileMode.Append);
        StreamWriter stream = new StreamWriter(f, Encoding.GetEncoding(1251));
        for (int i = 0; i < GetRowsNum(); i++)
            stream.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", tableRows[i].GetTaskNumber(), tableRows[i].GetDateReg(), tableRows[i].GetCipher(), tableRows[i].GetProjName(), tableRows[i].GetSurname(), tableRows[i].GetDateEnd(), tableRows[i].GetVolume());
        stream.Close();
        f.Close();
    }
    public int Getfile(string fnamePKD)
    {
        string path = AppContext.BaseDirectory + "/" + fnamePKD;
        string str;
            if (File.Exists(path))
            {
                FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader stream = new StreamReader(f, Encoding.GetEncoding(1251));
                int i = 0;
                RowPKD row = new RowPKD();
                while (!stream.EndOfStream)
                {
                    str = stream.ReadLine();
                    switch (i)
                    {
                        case 0: row.SetTaskNumber(str); break;
                        case 1: row.SetDateReg(str); break;
                        case 2: row.SetCipher(str); break;
                        case 3: row.SetProjName(str); break;
                        case 4: row.SetSurname(str); break;
                        case 5: row.SetDateEnd(str); break;
                        case 6: row.SetVolume(Convert.ToInt32(str)); AddStr(row); break;
                    }
                    i++;
                    if (i == 7) i = 0;
                }
                stream.Close();
                f.Close();
            }
        else return 0;
        return 1;
    }
    public int ExpBigTable(string fname, int from, int to)
    {
        /*ofstream f;
        f.open(fname);
        if (!f.is_open()) return 0;
        f << "                                                           ЖУРНАЛ УЧЕТА ВЫПОЛНЕННОЙ ПРОЕКТНО-КОНСТРУКТОРСКОЙ ДОКУМЕНТАЦИИ\n\n";
        f << "   НОМЕР       ДАТА      ШИФР                                            НАИМЕНОВАНИЕ ПРОЕКТА                                                ИСПОЛНИТЕЛЬ      ДАТА ЗАВЕРШЕНИЯ ОБЪЕМ\n";
        f << "  ЗАДАНИЯ  РЕГИСТРАЦИИ  ПРОЕКТА                                                                                                                                   ПРОЕКТА   (в  л.А4)\n";
        for (int i = from - 1; i < to; i++)
        {
            if ((tableRows[i].GetVolume() == 0) || (tableRows[i].GetDateEnd() == "00.00.0000")) continue;
            f << "| ";
            f << tableRows[i].GetTaskNumber();
            for (int j = tableRows[i].GetTaskNumber().length(); j < 8; j++) f << ' ';
            f << "| ";
            f << tableRows[i].GetDateReg();
            for (int j = tableRows[i].GetDateReg().length(); j < 11; j++) f << ' ';
            f << "| ";
            f << tableRows[i].GetCipher();
            for (int j = tableRows[i].GetCipher().length(); j < 7; j++) f << ' ';
            f << "| ";
            f << tableRows[i].GetProjName();
            for (int j = tableRows[i].GetProjName().length(); j < 101; j++) f << ' ';
            f << "| ";
            f << tableRows[i].GetSurname();
            for (int j = tableRows[i].GetSurname().length(); j < 21; j++) f << ' ';
            f << "| ";
            f << tableRows[i].GetDateEnd();
            for (int j = tableRows[i].GetDateEnd().length(); j < 12; j++) f << ' ';
            f << "| ";
            f << tableRows[i].GetVolume();
            for (int j = to_string(tableRows[i].GetVolume()).length(); j < 6; j++) f << ' ';
            f << "|\n";
        }
        f.close();*/
        return (1);
    }
    public int ExpSmallTable(string fname, int from, int to)
    {
       /* ofstream f;
        f.open(fname);
        if (!f.is_open()) return 0;
        f << "                                              ЖУРНАЛ УЧЕТА НОМЕРОВ ПРОЕКТНО-КОНСТРУКТОРСКОЙ ДОКУМЕНТАЦИИ\n\n";
        f << "   НОМЕР       ДАТА      ШИФР                                            НАИМЕНОВАНИЕ ПРОЕКТА                                                ИСПОЛНИТЕЛЬ\n";
        f << "  ЗАДАНИЯ  РЕГИСТРАЦИИ  ПРОЕКТА\n";
        for (int i = from - 1; i < to; i++)
        {
            f << "| ";
            f << tableRows[i].GetTaskNumber();
            for (int j = tableRows[i].GetTaskNumber().length(); j < 8; j++) f << ' ';
            f << "| ";
            f << tableRows[i].GetDateReg();
            for (int j = tableRows[i].GetDateReg().length(); j < 11; j++) f << ' ';
            f << "| ";
            f << tableRows[i].GetCipher();
            for (int j = tableRows[i].GetCipher().length(); j < 7; j++) f << ' ';
            f << "| ";
            f << tableRows[i].GetProjName();
            for (int j = tableRows[i].GetProjName().length(); j < 101; j++) f << ' ';
            f << "| ";
            f << tableRows[i].GetSurname();
            for (int j = tableRows[i].GetSurname().length(); j < 21; j++) f << ' ';
            f << "|\n";
        }
        f.close();*/
        return (1);
    }
    private RowPKD[] tableRows = new RowPKD[1];
    private int rowsNum;
}

}


