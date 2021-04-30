using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype2
{
    public partial class Form2 : Form
    {
        public Form2() //When the form is created, this runs
        {
            InitializeComponent();
            button2.BackColor = FindColor(Setup.table1);
            button2.Text = "Table " + Setup.table1.GetTableID();
            button3.BackColor = FindColor(Setup.table2);
            button3.Text = "Table " + Setup.table2.GetTableID();
            button4.BackColor = FindColor(Setup.table3);
            button4.Text = "Table " + Setup.table3.GetTableID();
            button5.BackColor = FindColor(Setup.table4);
            button5.Text = "Table " + Setup.table4.GetTableID();
            button6.BackColor = FindColor(Setup.table5);
            button6.Text = "Table " + Setup.table5.GetTableID();
            button7.BackColor = FindColor(Setup.table6);
            button7.Text = "Table " + Setup.table6.GetTableID();
            label1.Text = "Hello, " + Setup.emp1.GetEmpName() + "!";
            label2.Hide();
            label3.Hide();
            button8.Hide();
        }

        public static void SetSelectedTable(Table t)
        {
            Setup.selectedTable = t;
        }
        public static Color FindColor(Table t) //This method just return the color based on table status
        {
            Color c;
            switch (t.GetTableStatus()) {
                case "Empty":
                    c = Color.FromArgb(0, 200, 0);
                    break;
                case "Seated":
                    c = Color.FromArgb(200, 200, 0);
                    break;
                case "Needs Cleaning":
                    c = Color.FromArgb(200, 0, 0);
                    break;
                default:
                    c = Color.FromArgb(0, 0, 0);
                    break;
            }
            return c;
        }
        private void button1_Click(object sender, EventArgs e) ///Sign out Button
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e) ///Table 1 Button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table1.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table1;
        }
        private void button3_Click(object sender, EventArgs e) ///Table 2 Button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table2.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table2;
        }

        private void button4_Click(object sender, EventArgs e) ///Table 3 Button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table3.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table3;
        }

        private void button5_Click(object sender, EventArgs e) ///Table 4 Button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table4.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table4;
        }

        private void button6_Click(object sender, EventArgs e) ///Table 5 Button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table5.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table5;
        }

        private void button7_Click(object sender, EventArgs e) ///Table 6 Button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table6.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table6;
        }

        private void button8_Click(object sender, EventArgs e) ///Add order button. Tables that need cleaning can't have orders added
        {
            if (!Setup.selectedTable.GetTableStatus().Equals("Needs Cleaning")) {
                Form3 form3 = new Form3();
                form3.Show();
                this.Visible = false;
            }
            else
            {
                label3.Show();
                label3.Text = "Orders can't be added to dirty tables.";
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Visible = false;
        }
    }
}
