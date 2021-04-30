using System;
using System.Collections.Generic;
using System.Collections;
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
        private string bill;
        private double billtotal;
        public Table(int tableID, string status) {
            this.tableID = tableID;
            this.status = status;
            bill = "";
            billtotal = 0.0;
        }
        public void AddToBill(Item i)
        {
            bill += i.GetItemName() + ", ";
            billtotal += i.GetItemPrice();
        }
        public string GetBill()
        {
            return bill;
        }
        public double GetBillTotal()
        {
            return billtotal;
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
        public static Table selectedTable;
        public static Item selectedItem;
        public static Item soup1 = new Item(1, "Soup of the Day", true, 8.00);
        public static Item salad1 = new Item(2, "House Salad", true, 9.00);
        public static Item salad2 = new Item(3, "Caesar Salad", true, 8.50);
        public static Item entree1 = new Item(4, "Fried Chicken", true, 14.00);
        public static Item entree2 = new Item(5, "Cheeseburger", true, 13.50);
        public static Item entree3 = new Item(6, "Hot Dog", true, 16.00);
        public static Item entree4 = new Item(7, "Grilled Cheese", true, 9.00);
        public static Item entree5 = new Item(8, "Baked Cod", true, 15.00);
        public static Item drink1 = new Item(9, "Water", true, 0.50);
        public static Item drink2 = new Item(10, "Tea", true, 1.50);
        public static Item drink3 = new Item(11, "Lemonade", true, 1.50);
        public static Item drink4 = new Item(12, "Soda", true, 2.00);
        
    }

}
