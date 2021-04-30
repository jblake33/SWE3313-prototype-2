using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
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
            if (Setup.selectedItem != null)
            {
                bill += i.GetItemName() + ", ";
                billtotal += i.GetItemPrice();
            }
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
    public class EmployeeFileIO
    {
        public static List<Employee> GetEmployeeList()
        {
            string line = "";
            string[] linearr = new string[3];
            List<Employee> list = new List<Employee>();
            try
            {
                FileStream fs = new FileStream("emplist.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    linearr = line.Split(',');
                    int id = Int32.Parse(linearr[0]);
                    bool isM;
                    if (linearr[2] == "true") { isM = true; }
                    else { isM = false; }
                    list.Add(new Employee(id, linearr[1], isM));
                }
            }
            catch (IOException e) { }
            return list;
        }
    }
        public static class Setup ///Static class to hold global variables (this is for the entire prototype)
        {
            public static Table table1 = new Table(10, "Empty");
            public static Table table2 = new Table(11, "Seated");
            public static Table table3 = new Table(12, "Seated");
            public static Table table4 = new Table(13, "Seated");
            public static Table table5 = new Table(14, "Needs Cleaning");
            public static Table table6 = new Table(15, "Needs Cleaning");
            public static Table table7 = new Table(16, "Needs Cleaning");
            public static Table table8 = new Table(17, "Needs Cleaning");
            public static Table table9 = new Table(18, "Needs Cleaning");
            public static Table table10 = new Table(19, "Seated");
            public static Table table11 = new Table(20, "Seated");
            public static Table table12 = new Table(21, "Seated");
            public static Table table13 = new Table(22, "Needs Cleaning");
            public static Table table14 = new Table(23, "Empty");
            public static Table table15 = new Table(24, "Needs Cleaning");
            public static Table table16 = new Table(25, "Seated");
            public static Table table17 = new Table(26, "Needs Cleaning");
            public static Table table18 = new Table(27, "Seated");
            public static Table table19 = new Table(28, "Needs Cleaning");
            public static Table table20 = new Table(29, "Seated");
            public static Table table21 = new Table(30, "Empty");
            public static Table table22 = new Table(31, "Needs Cleaning");
            public static Table table23 = new Table(32, "Seated");
            public static Table table24 = new Table(33, "Seated");
            public static Table table25 = new Table(34, "Needs Cleaning");
            public static Table table26 = new Table(35, "Seated");
            public static Table table27 = new Table(36, "Empty");
            public static Table table28 = new Table(37, "Empty");
            public static Table table29 = new Table(38, "Seated");
            public static Table table30 = new Table(39, "Needs Cleaning");
            public static Table selectedTable;
        public static Employee selectedEmployee;
            public static Item selectedItem;
            public static Item soup1 = new Item(1, "Soup of the Day", true, 8.00);
            public static Item soup2 = new Item(2, "Tomato Soup", true, 7.00);
            public static Item salad1 = new Item(3, "House Salad", true, 9.00);
            public static Item salad2 = new Item(4, "Caesar Salad", true, 8.50);
            public static Item entree1 = new Item(5, "Fried Chicken", true, 14.00);
            public static Item entree2 = new Item(6, "Cheeseburger", true, 13.50);
            public static Item entree3 = new Item(7, "Hot Dog", true, 16.00);
            public static Item entree4 = new Item(8, "Grilled Cheese", true, 9.00);
            public static Item entree5 = new Item(9, "Baked Cod", true, 15.00);
            public static Item drink1 = new Item(10, "Water", true, 0.50);
            public static Item drink2 = new Item(11, "Tea", true, 1.50);
            public static Item drink3 = new Item(12, "Lemonade", true, 1.50);
            public static Item drink4 = new Item(13, "Soda", true, 2.00);
            public static Item dessert1 = new Item(14, "Ice Cream", true, 2.00);
            public static Item dessert2 = new Item(15, "Cookie", true, 2.00);
            public static Item dessert3 = new Item(16, "Brownie", true, 2.00);
            public static Item dessert4 = new Item(17, "Flavored Ice", true, 2.00);
            public static Item appetizer1 = new Item(18, "Veggies and Dip", true, 5.00);
            public static Item appetizer2 = new Item(19, "Chips", true, 1.50);
            public static Item appetizer3 = new Item(20, "Onion Rings", true, 2.50);
            public static Item appetizer4 = new Item(21, "French Fries", true, 3.00);

        }
    }

