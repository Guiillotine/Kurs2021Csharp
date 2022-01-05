using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kurs2021Csharp
{
    public class RowRegZd
    {
        public RowRegZd()
        {
        }
        public RowRegZd(string taskNumber, string date, string customer, string task, string projNumber, string surname, string status, string note)
        {
            this.taskNumber = taskNumber;
            this.date = date;
            this.customer = customer;
            this.task = task;
            this.projNumber = projNumber;
            this.surname = surname;
            this.status = status;
            this.note = note;
        }
        public void SetTaskNumber(String taskNumber)
        {
            this.taskNumber = taskNumber;
        }
        public String GetTaskNumber()
        {
            return (taskNumber);
        }
        public void SetDate(String date)
        {
            this.date = date;
        }
        public String GetDate()
        {
            return (date);
        }
        public void SetCustomer(String customer)
        {
            this.customer = customer;
        }
        public String GetCustomer()
        {
            return (customer);
        }
        public void SetTask(String task)
        {
            this.task = task;
        }
        public String GetTask()
        {
            return (task);
        }
        public void SetProjNumber(String projNumber)
        {
            this.projNumber = projNumber;
        }
        public String GetProjNumber()
        {
            return (projNumber);
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public string GetSurname()
        {
            return (surname);
        }
        public void SetStatus(String status)
        {
            this.status = status;
        }
        public String GetStatus()
        {
            return (status);
        }
        public void SetNote(String note)
        {
            this.note = note;
        }
        public String GetNote()
        {
            return (note);
        }
        public void Putfile(String fnameRegZd)
        {
            string path = AppContext.BaseDirectory;
            FileStream f = new FileStream(path + "/" + fnameRegZd, FileMode.Append);
            StreamWriter stream = new StreamWriter(f, Encoding.GetEncoding(1251));
            stream.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}", taskNumber, date, customer, task, projNumber, surname, status, note);
            stream.Close();
            f.Close();
        }
        public object Clone()
        {
            return new RowRegZd(taskNumber, date, customer, task, projNumber, surname, status, note);
        }
        private String taskNumber;
        private String date;
        private String customer;
        private String task;
        private String projNumber;
        private String surname;
        private String status;
        private String note;
    }
    public class TableRegZd
    {
        public void AddStr(RowRegZd tableRow)
        {
            if (rowsNum > 0) ArrResize();
            tableRows[rowsNum] = (RowRegZd)tableRow.Clone();
            rowsNum++;
        }
        public void EditStr(int numberStr, RowRegZd tableRow)
        {
            tableRows[numberStr - 1] = tableRow;
        }
        public void ArrResize()
        {
            RowRegZd[] tableRows2 = new RowRegZd[rowsNum + 1];
            for (int i = 0; i < rowsNum; i++) tableRows2[i] = (RowRegZd)tableRows[i].Clone();
            tableRows = tableRows2;
        }
        public int GetRowsNum()
        {
            return (rowsNum);
        }
        public RowRegZd GetTableRow(int index)
        {
            return tableRows[index];
        }
        public void Putfile(string fnameRegZd)
        {
            string path = AppContext.BaseDirectory;
            FileStream f = new FileStream(path + "/" + fnameRegZd, FileMode.Create);
            StreamWriter stream = new StreamWriter(f, Encoding.GetEncoding(1251));
            for (int i = 0; i < GetRowsNum(); i++)
                stream.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}", tableRows[i].GetTaskNumber(), tableRows[i].GetDate(), tableRows[i].GetCustomer(), tableRows[i].GetTask(), tableRows[i].GetProjNumber(), tableRows[i].GetSurname(), tableRows[i].GetStatus(), tableRows[i].GetNote());
            stream.Close();
            f.Close();
        }
        public int Getfile(string fnameRegZd)
        {
            string path = AppContext.BaseDirectory + "/" + fnameRegZd;
            string str;
            if (File.Exists(path))
            {
                FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader stream = new StreamReader(f, Encoding.GetEncoding(1251));
                int i = 0;
                RowRegZd row = new RowRegZd();
                while (!stream.EndOfStream)
                {
                    str = stream.ReadLine();
                    switch (i)
                    {
                        case 0: row.SetTaskNumber(str); break;
                        case 1: row.SetDate(str); break;
                        case 2: row.SetCustomer(str); break;
                        case 3: row.SetTask(str); break;
                        case 4: row.SetProjNumber(str); break;
                        case 5: row.SetSurname(str); break;
                        case 6: row.SetStatus(str); break;
                        case 7: row.SetNote(str); AddStr(row); break; 
                    }
                    i++;
                    if (i == 8) i = 0;
                }
                stream.Close();
                f.Close();
            }
            else return 0;
            return 1;
        }
        public void ExpTable(string fname, int from, int to)
        {
            string path = AppContext.BaseDirectory;
            FileStream f = new FileStream(path + "/" + fname, FileMode.Create);
            StreamWriter stream = new StreamWriter(f, Encoding.GetEncoding(1251));
            stream.Write("                                                                                          ЖУРНАЛ РЕГИСТРАЦИИ ЗАДАНИЙ НА ПРОЕКТИРОВАНИЕ\n\n");
            stream.Write("  НОМЕР      ДАТА ВЫД.     НАИМЕНОВАНИЕ                                             СОДЕРЖАНИЕ ЗАДАНИЯ                                            НОМЕР          ФАМИЛИЯ              СТАТУС                    ПРИМЕЧАНИЕ\n");
            stream.Write(" ЗАДАНИЯ     ЗАДАНИЯ        ЗАКАЗЧИКА                                                                                                            ПРОЕКТА  ИНЖЕНЕРА-КОНСТРУКТОРА\n");
            for (int i = from - 1; i < to; i++)
            {
                stream.Write("| ");
                stream.Write("{0}",tableRows[i].GetTaskNumber());
                for (int j = tableRows[i].GetTaskNumber().Length; j < 8; j++) stream.Write(" ");
                stream.Write("| ");
                stream.Write("{0}",tableRows[i].GetDate());
                for (int j = tableRows[i].GetDate().Length; j < 11; j++) stream.Write(" ");
                stream.Write("| ");
                stream.Write("{0}", tableRows[i].GetCustomer());
                for (int j = tableRows[i].GetCustomer().Length; j < 16; j++) stream.Write(" ");
                stream.Write("| ");
                stream.Write("{0}", tableRows[i].GetTask());
                for (int j = tableRows[i].GetTask().Length; j < 101; j++) stream.Write(" ");
                stream.Write("| ");
                stream.Write("{0}", tableRows[i].GetProjNumber());
                for (int j = tableRows[i].GetProjNumber().Length; j < 7; j++) stream.Write(" ");
                stream.Write("| ");
                stream.Write("{0}", tableRows[i].GetSurname());
                for (int j = tableRows[i].GetSurname().Length; j < 21; j++) stream.Write(" ");
                stream.Write("| ");
                stream.Write("{0}", tableRows[i].GetStatus());
                for (int j = tableRows[i].GetStatus().Length; j < 16; j++) stream.Write(" ");
                stream.Write("| ");
                stream.Write("{0}", tableRows[i].GetNote());
                for (int j = tableRows[i].GetNote().Length; j < 36; j++) stream.Write(" ");
                stream.Write("|\n");
            }
            stream.Close();
            f.Close();
        }
        private RowRegZd[] tableRows = new RowRegZd[1];
        private int rowsNum;
    }
}
