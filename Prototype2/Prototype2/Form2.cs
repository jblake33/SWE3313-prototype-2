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

            button9.BackColor = FindColor(Setup.table7);
            button9.Text = "Table " + Setup.table7.GetTableID();
            button10.BackColor = FindColor(Setup.table8);
            button10.Text = "Table " + Setup.table8.GetTableID();
            button11.BackColor = FindColor(Setup.table9);
            button11.Text = "Table " + Setup.table9.GetTableID();
            button12.BackColor = FindColor(Setup.table10);
            button12.Text = "Table " + Setup.table10.GetTableID();
            button13.BackColor = FindColor(Setup.table11);
            button13.Text = "Table " + Setup.table11.GetTableID();
            button14.BackColor = FindColor(Setup.table12);
            button14.Text = "Table " + Setup.table12.GetTableID();
            button15.BackColor = FindColor(Setup.table13);
            button15.Text = "Table " + Setup.table13.GetTableID();
            button16.BackColor = FindColor(Setup.table14);
            button16.Text = "Table " + Setup.table14.GetTableID();
            button17.BackColor = FindColor(Setup.table15);
            button17.Text = "Table " + Setup.table15.GetTableID();
            button18.BackColor = FindColor(Setup.table16);
            button18.Text = "Table " + Setup.table16.GetTableID();
            button19.BackColor = FindColor(Setup.table17);
            button19.Text = "Table " + Setup.table17.GetTableID();
            button20.BackColor = FindColor(Setup.table18);
            button20.Text = "Table " + Setup.table18.GetTableID();
            button21.BackColor = FindColor(Setup.table19);
            button21.Text = "Table " + Setup.table19.GetTableID();
            button22.BackColor = FindColor(Setup.table20);
            button22.Text = "Table " + Setup.table20.GetTableID();
            button23.BackColor = FindColor(Setup.table21);
            button23.Text = "Table " + Setup.table21.GetTableID();
            button24.BackColor = FindColor(Setup.table22);
            button24.Text = "Table " + Setup.table22.GetTableID();
            button25.BackColor = FindColor(Setup.table23);
            button25.Text = "Table " + Setup.table23.GetTableID();
            button26.BackColor = FindColor(Setup.table24);
            button26.Text = "Table " + Setup.table24.GetTableID();
            button27.BackColor = FindColor(Setup.table25);
            button27.Text = "Table " + Setup.table25.GetTableID();
            button28.BackColor = FindColor(Setup.table26);
            button28.Text = "Table " + Setup.table26.GetTableID();
            button29.BackColor = FindColor(Setup.table27);
            button29.Text = "Table " + Setup.table27.GetTableID();
            button30.BackColor = FindColor(Setup.table28);
            button30.Text = "Table " + Setup.table28.GetTableID();
            button31.BackColor = FindColor(Setup.table29);
            button31.Text = "Table " + Setup.table29.GetTableID();
            button32.BackColor = FindColor(Setup.table30);
            button32.Text = "Table " + Setup.table30.GetTableID();
            label1.Text = "Hello, " + Setup.selectedEmployee.GetEmpName() + "!";
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
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }
        private void button3_Click(object sender, EventArgs e) ///Table 2 Button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table2.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table2;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button4_Click(object sender, EventArgs e) ///Table 3 Button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table3.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table3;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button5_Click(object sender, EventArgs e) ///Table 4 Button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table4.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table4;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button6_Click(object sender, EventArgs e) ///Table 5 Button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table5.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table5;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button7_Click(object sender, EventArgs e) ///Table 6 Button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table6.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table6;
            if (Setup.selectedTable.GetBill() != "") {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
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
            if (!Setup.selectedTable.GetTableStatus().Equals("Needs Cleaning"))
            {
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

        private void button9_Click(object sender, EventArgs e) ///Table 7 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table7.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table7;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button10_Click(object sender, EventArgs e) ///Table 8 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table8.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table8;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button11_Click(object sender, EventArgs e) ///Table 9 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table9.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table9;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button12_Click(object sender, EventArgs e) ///Table 10 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table10.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table10;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button13_Click(object sender, EventArgs e) ///Table 11 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table11.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table11;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button14_Click(object sender, EventArgs e) ///Table 12 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table12.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table12;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button15_Click(object sender, EventArgs e) ///Table 13 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table13.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table13;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button16_Click(object sender, EventArgs e) ///Table 14 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table14.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table14;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button17_Click(object sender, EventArgs e) ///Table 15 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table15.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table15;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button18_Click(object sender, EventArgs e) ///Table 16 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table16.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table16;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button19_Click(object sender, EventArgs e) ///Table 17 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table17.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table17;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button20_Click(object sender, EventArgs e) ///Table 18 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table18.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table18;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button21_Click(object sender, EventArgs e) ///Table 19 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table19.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table19;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button22_Click(object sender, EventArgs e) ///Table 20 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table20.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table20;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button23_Click(object sender, EventArgs e) ///Table 21 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table21.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table21;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button24_Click(object sender, EventArgs e) ///Table 22 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table22.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table22;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button25_Click(object sender, EventArgs e) ///Table 23 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table23.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table23;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button26_Click(object sender, EventArgs e) ///Table 24 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table24.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table24;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button27_Click(object sender, EventArgs e) ///Table 25 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table25.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table25;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button28_Click(object sender, EventArgs e) ///Table 26 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table26.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table26;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button29_Click(object sender, EventArgs e) ///Table 27 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table27.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table27;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button30_Click(object sender, EventArgs e) ///Table 28 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table28.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table28;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button31_Click(object sender, EventArgs e) ///Table 29 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table29.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table29;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }

        private void button32_Click(object sender, EventArgs e) ///Table 30 button
        {
            label2.Show();
            button8.Show();
            label2.Text = "Table " + Setup.table30.GetTableID();
            button8.Text = "Add Order...";
            Setup.selectedTable = Setup.table30;
            if (Setup.selectedTable.GetBill() != "")
            {
                textBox1.Text = Setup.selectedTable.GetBill() + "Total: $" + Setup.selectedTable.GetBillTotal();
            }
            else { textBox1.Text = "This table has no order."; }
        }
    }
}
