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

        }
        private void button3_Click(object sender, EventArgs e) ///Table 2 Button
        {

        }

        private void button4_Click(object sender, EventArgs e) ///Table 3 Button
        {

        }

        private void button5_Click(object sender, EventArgs e) ///Table 4 Button
        {

        }

        private void button6_Click(object sender, EventArgs e) ///Table 5 Button
        {

        }

        private void button7_Click(object sender, EventArgs e) ///Table 6 Button
        {

        }
    }
}
