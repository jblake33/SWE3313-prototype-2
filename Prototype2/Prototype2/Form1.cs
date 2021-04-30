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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) ///Sign in button
        {
            List<Employee> employees = EmployeeFileIO.GetEmployeeList();
            foreach (Employee m in employees)
            {
                if (textBox1.Text == m.GetEmpID().ToString())
                {
                    Setup.selectedEmployee = m;
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Visible = false;
                }
            }
        }
    }
}
