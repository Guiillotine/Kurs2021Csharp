using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kurs2021Csharp
{
    public class RowPKD : Row
    {
        public RowPKD()
        {
        }
        public RowPKD(String taskNumber, String dateReg, String cipher, String projName, String surname, String dateEnd, int volume)
        {
            this.taskNumber = taskNumber;
            this.dateReg = dateReg;
            this.cipher = cipher;
            this.projName = projName;
            this.surname = surname;
            this.dateEnd = dateEnd;
            this.volume = volume;
        }
        public void SetDateReg(String dateReg)
        {
            this.dateReg = dateReg;
        }
        public String GetDateReg()
        {
            return (dateReg);
        }
        public void SetCipher(String cipher)
        {
            this.cipher = cipher;
        }
        public String GetCipher()
        {
            return (cipher);
        }
        public void SetProjName(String projName)
        {
            this.projName = projName;
        }
        public String GetProjName()
        {
            return (projName);
        }
        public void SetDateEnd(String dateEnd)
        {
            this.dateEnd = dateEnd;
        }
        public String GetDateEnd()
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
        public override void Putfile(String fnamePKD)
        {
            String path = AppContext.BaseDirectory;
            FileStream f = new FileStream(path + "/" + fnamePKD, FileMode.Append);
            StreamWriter stream = new StreamWriter(f, Encoding.GetEncoding(1251));
            stream.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", taskNumber, dateReg, cipher, projName, surname, dateEnd, volume);
            stream.Close();
            f.Close();
        }
        public object Clone()
        {
            return new RowPKD(taskNumber, dateReg, cipher, projName, surname, dateEnd, volume);
        }
        private String dateReg;
        private String cipher;
        private String projName;
        private String dateEnd;
        private int volume;
    }

    public class TablePKD : Table
    {
    public void AddStr(RowPKD tableRow)
    {
        if (rowsNum > 0) ArrResize();
        tableRows[rowsNum] = (RowPKD)tableRow.Clone();
        rowsNum++;
    }
    public void EditStr(int numberStr, RowPKD tableRow)
    {
        tableRows[numberStr - 1] = tableRow;
    }
    public override void ArrResize()
    {
        RowPKD[] tableRows2 = new RowPKD[rowsNum + 1];
        for (int i = 0; i < rowsNum; i++) tableRows2[i] = (RowPKD)tableRows[i].Clone();
        tableRows = tableRows2;
    }
    public RowPKD GetTableRow(int index)
    {
        return tableRows[index];
    }
    public override void Putfile(String fnamePKD)
    {
        String path = AppContext.BaseDirectory;
        FileStream f = new FileStream(path + "/" + fnamePKD, FileMode.Create);
        StreamWriter stream = new StreamWriter(f, Encoding.GetEncoding(1251));
        for (int i = 0; i < GetRowsNum(); i++)
            stream.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", tableRows[i].GetTaskNumber(), tableRows[i].GetDateReg(), tableRows[i].GetCipher(), tableRows[i].GetProjName(), tableRows[i].GetSurname(), tableRows[i].GetDateEnd(), tableRows[i].GetVolume());
        stream.Close();
        f.Close();
    }
    public override int Getfile(String fnamePKD)
    {
        String path = AppContext.BaseDirectory + "/" + fnamePKD;
        String str;
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
    public void ExpBigTable(String fname, int from, int to)
    {
        String path = AppContext.BaseDirectory;
        FileStream f = new FileStream(path + "/" + fname, FileMode.Create);
        StreamWriter stream = new StreamWriter(f, Encoding.GetEncoding(1251));
        stream.Write("                                                           ЖУРНАЛ УЧЕТА ВЫПОЛНЕННОЙ ПРОЕКТНО-КОНСТРУКТОРСКОЙ ДОКУМЕНТАЦИИ\n\n");
        stream.Write("   НОМЕР       ДАТА      ШИФР                                            НАИМЕНОВАНИЕ ПРОЕКТА                                                ИСПОЛНИТЕЛЬ      ДАТА ЗАВЕРШЕНИЯ ОБЪЕМ\n");
        stream.Write("  ЗАДАНИЯ  РЕГИСТРАЦИИ  ПРОЕКТА                                                                                                                                   ПРОЕКТА   (в  л.А4)\n");
        for (int i = from - 1; i < to; i++)
        {
            if ((tableRows[i].GetVolume() == 0) || (tableRows[i].GetDateEnd() == "00.00.0000")) continue;
            stream.Write("| ");
            stream.Write("{0}",tableRows[i].GetTaskNumber());
            for (int j = tableRows[i].GetTaskNumber().Length; j < 8; j++) stream.Write(" ");
            stream.Write("| ");
            stream.Write("{0}",tableRows[i].GetDateReg());
            for (int j = tableRows[i].GetDateReg().Length; j < 11; j++) stream.Write(" ");
            stream.Write("| ");
            stream.Write("{0}",tableRows[i].GetCipher());
            for (int j = tableRows[i].GetCipher().Length; j < 7; j++) stream.Write(" ");
            stream.Write("| ");
            stream.Write("{0}",tableRows[i].GetProjName());
            for (int j = tableRows[i].GetProjName().Length; j < 101; j++) stream.Write(" ");
            stream.Write("| ");
            stream.Write("{0}",tableRows[i].GetSurname());
            for (int j = tableRows[i].GetSurname().Length; j < 21; j++) stream.Write(" ");
            stream.Write("| ");
            stream.Write("{0}",tableRows[i].GetDateEnd());
            for (int j = tableRows[i].GetDateEnd().Length; j < 12; j++) stream.Write(" ");
            stream.Write("| ");
            stream.Write("{0}",tableRows[i].GetVolume());
            for (int j = Convert.ToString(tableRows[i].GetVolume()).Length; j < 6; j++) stream.Write(" ");
            stream.Write("|\n");
        }
            stream.Close();
            f.Close();
    }
    public void ExpSmallTable(String fname, int from, int to)
    {
            String path = AppContext.BaseDirectory;
            FileStream f = new FileStream(path + "/" + fname, FileMode.Create);
            StreamWriter stream = new StreamWriter(f, Encoding.GetEncoding(1251));
            stream.Write("                                              ЖУРНАЛ УЧЕТА НОМЕРОВ ПРОЕКТНО-КОНСТРУКТОРСКОЙ ДОКУМЕНТАЦИИ\n\n");
            stream.Write("   НОМЕР       ДАТА      ШИФР                                            НАИМЕНОВАНИЕ ПРОЕКТА                                                ИСПОЛНИТЕЛЬ\n");
            stream.Write("  ЗАДАНИЯ  РЕГИСТРАЦИИ  ПРОЕКТА\n");
            for (int i = from - 1; i < to; i++)
            {
                stream.Write("| ");
                stream.Write("{0}", tableRows[i].GetTaskNumber());
                for (int j = tableRows[i].GetTaskNumber().Length; j < 8; j++) stream.Write(" ");
                stream.Write("| ");
                stream.Write("{0}",tableRows[i].GetDateReg());
                for (int j = tableRows[i].GetDateReg().Length; j < 11; j++) stream.Write(" ");
                stream.Write("| ");
                stream.Write("{0}", tableRows[i].GetCipher());
                for (int j = tableRows[i].GetCipher().Length; j < 7; j++) stream.Write(" ");
                stream.Write("| ");
                stream.Write("{0}", tableRows[i].GetProjName());
                for (int j = tableRows[i].GetProjName().Length; j < 101; j++) stream.Write(" ");
                stream.Write("| ");
                stream.Write("{0}", tableRows[i].GetSurname());
                for (int j = tableRows[i].GetSurname().Length; j < 21; j++) stream.Write(" ");
                stream.Write("|\n");
            }
            stream.Close();
            f.Close();
    }
    private RowPKD[] tableRows = new RowPKD[1];
}

}


