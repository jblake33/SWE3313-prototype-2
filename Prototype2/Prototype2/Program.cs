using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// This class contains Employee, Table, Item class and a
/// "Setup" class to hold the temporary attributes for the prototype.
/// </summary>
namespace Prototype2
{
    static class Program
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
    public class Employee ///Class for employee
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
        ///We don't have to add a schedule for the prototype.
    }
    public class Table ///Class for tables
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
    public class Item ///Class for menu items
    {
        private int itemID;
        private string itemName;
        private bool isAvailable;
        private double price;
        public Item(int itemID, string itemName, bool isAvailable, double price)
        {
            this.itemID = itemID;
            this.itemName = itemName;
            this.isAvailable = isAvailable;
            this.price = price;
        }
        public int GetItemID()
        {
            return itemID;
        }
        public string GetItemName()
        {
            return itemName;
        }
        public void SetItemName(string s)
        {
            itemName = s;
        }
        public bool IsAvailable()
        {
            return isAvailable;
        }
        public double GetItemPrice()
        {
            return price;
        }
        public void SetItemPrice(double d)
        {
            price = d;
        }
    }
    public static class Setup ///Static class to hold global variables
    {
        ///Because this is just a prototype, there is an employee, six tables, and some menu items
        public static Employee emp1 = new Employee(1000, "John Doe", false);
        public static Table table1 = new Table(10, "Empty");
        public static Table table2 = new Table(11, "Seated");
        public static Table table3 = new Table(12, "Seated");
        public static Table table4 = new Table(13, "Seated");
        public static Table table5 = new Table(14, "Needs Cleaning");
        public static Table table6 = new Table(15, "Needs Cleaning");
        ///Menu items can be added here
    }

}
