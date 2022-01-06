using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs2021Csharp
{
    public abstract class Row
    {
        public abstract void Putfile(String fname);
        public void SetTaskNumber(String taskNumber)
        {
            this.taskNumber = taskNumber;
        }
        public String GetTaskNumber()
        {
            return (taskNumber);
        }
        public void SetSurname(String surname)
        {
            this.surname = surname;
        }
        public String GetSurname()
        {
            return (surname);
        }
        protected String taskNumber;
        protected String surname;
    }
    public abstract class Table
    {
        public Table()
        {
            rowsNum = 0;
        }
        public abstract void ArrResize(); 
        public int GetRowsNum()
        {
            return (rowsNum);
        }
        public abstract void Putfile(string fname);
        public abstract int Getfile(string fname);

    protected int rowsNum;
    }
}
