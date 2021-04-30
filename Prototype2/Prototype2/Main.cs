using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype2
{
    static class Main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Employee
    {
        private int empID;
        private string name;
        private bool isManager;
        public Employee(int empID, string name, bool isManager)
        {
            this.empID = empID;
            this.name = name;
            this.isManager = isManager;
        }
        public int GetEmpID()
        {
            return empID;
        }
        public string GetEmpName()
        {
            return name;
        }
        public void SetEmpName(string n)
        {
            name = n;
        }
        public bool IsManager()
        {
            return isManager;
        }
        //May need a get/set schedule and schedule attributes, can be added later
    }
    public class Table
    {
        private int tableID;
        private string status;
        public Table(int tableID, string status) {
            this.tableID = tableID;
            this.status = status;
        }
        public int GetTableID()
        {
            return tableID;
        }
        public string GetTableStatus()
        {
            return status;
        }
        public void SetTableStatus(string s)
        {
            status = s;
        }
    }

}
