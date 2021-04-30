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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            label1.Text = "Bill for table " + Setup.selectedTable.GetTableID();
            textBox1.Text = Setup.selectedTable.GetBill() + "\nTotal: $" + Setup.selectedTable.GetBillTotal().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
