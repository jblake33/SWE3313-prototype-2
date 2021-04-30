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
    public partial class Form3 : Form
    {
        private bool side1isCollapsed;
        private bool side2isCollapsed;
        private bool side3isCollapsed;
        public Form3()
        {
            InitializeComponent();
            label1.Text = "Add items to Table " + Setup.selectedTable.GetTableID();
            ///Category buttons
            button1.Text = "Soup/Salads";
            button6.Text = "Entrees";
            button12.Text = "Drinks";
            ///Menu item buttons in the drop downs
            button2.Text = Setup.soup1.GetItemName();
            button3.Text = Setup.salad1.GetItemName();
            button4.Text = Setup.salad2.GetItemName();
            button7.Text = Setup.entree1.GetItemName();
            button8.Text = Setup.entree2.GetItemName();
            button9.Text = Setup.entree3.GetItemName();
            button10.Text = Setup.entree4.GetItemName();
            button11.Text = Setup.entree5.GetItemName();
            button13.Text = Setup.drink1.GetItemName();
            button14.Text = Setup.drink2.GetItemName();
            button15.Text = Setup.drink3.GetItemName();
            button16.Text = Setup.drink4.GetItemName();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
        }
        private void button1_Click(object sender, EventArgs e)///soup/salad category button
        {
            label6.Hide();
            timer1.Start();
        }
        private void button6_Click(object sender, EventArgs e)///entree category button
        {
            label6.Hide();
            timer2.Start();
        }

        private void button5_Click(object sender, EventArgs e) ///Back button (goes to table screen)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Visible = false;
        }
        private void button12_Click(object sender, EventArgs e) ///drink category button
        {
            label6.Hide();
            timer3.Start();
        }
        private void timer1_Tick(object sender, EventArgs e) ///This makes the soup/salad category drop down
        {
            if (side1isCollapsed)
            {
                SideDropDown.Height += 10;
                if (SideDropDown.Size == SideDropDown.MaximumSize)
                {
                    timer1.Stop();
                    side1isCollapsed = false;
                }
            }
            else
            {
                SideDropDown.Height -= 10;
                if (SideDropDown.Size == SideDropDown.MinimumSize)
                {
                    timer1.Stop();
                    side1isCollapsed = true;
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e) ///This makes the entree category drop down
        {
            if (side2isCollapsed)
            {
                Side2DropDown.Height += 10;
                if (Side2DropDown.Size == Side2DropDown.MaximumSize)
                {
                    timer2.Stop();
                    side2isCollapsed = false;
                }
            }
            else
            {
                Side2DropDown.Height -= 10;
                if (Side2DropDown.Size == Side2DropDown.MinimumSize)
                {
                    timer2.Stop();
                    side2isCollapsed = true;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e) ///This makes the drink category drop down
        {
            if (side3isCollapsed)
            {
                Side3DropDown.Height += 10;
                if (Side3DropDown.Size == Side3DropDown.MaximumSize)
                {
                    timer3.Stop();
                    side3isCollapsed = false;
                }
            }
            else
            {
                Side3DropDown.Height -= 10;
                if (Side3DropDown.Size == Side3DropDown.MinimumSize)
                {
                    timer3.Stop();
                    side3isCollapsed = true;
                }
            }
        }
        /// <summary>
        /// below are for each menu item to make the item information appear
        /// </summary>



        private void button6_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Setup.selectedItem = Setup.soup1;
            label3.Show();
            label4.Show();
            label5.Show();
            label3.Text = Setup.soup1.GetItemName();
            label4.Text = "$" + Setup.soup1.GetItemPrice().ToString();
            if (Setup.soup1.IsAvailable())
            {
                label5.Text = "This item is available";
            } 
            else
            {
                label5.Text = "This item is currently unavailable...";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Setup.selectedItem = Setup.salad1;
            label3.Show();
            label4.Show();
            label5.Show();
            label3.Text = Setup.salad1.GetItemName();
            label4.Text = "$" + Setup.salad1.GetItemPrice().ToString();
            if (Setup.salad1.IsAvailable())
            {
                label5.Text = "This item is available";
            }
            else
            {
                label5.Text = "This item is currently unavailable...";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Setup.selectedItem = Setup.salad2;
            label3.Show();
            label4.Show();
            label5.Show();
            label3.Text = Setup.salad2.GetItemName();
            label4.Text = "$" + Setup.salad2.GetItemPrice().ToString();
            if (Setup.salad2.IsAvailable())
            {
                label5.Text = "This item is available";
            }
            else
            {
                label5.Text = "This item is currently unavailable...";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Setup.selectedItem = Setup.entree1;
            label3.Show();
            label4.Show();
            label5.Show();
            label3.Text = Setup.entree1.GetItemName();
            label4.Text = "$" + Setup.entree1.GetItemPrice().ToString();
            if (Setup.entree1.IsAvailable())
            {
                label5.Text = "This item is available";
            }
            else
            {
                label5.Text = "This item is currently unavailable...";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Setup.selectedItem = Setup.entree2;
            label3.Show();
            label4.Show();
            label5.Show();
            label3.Text = Setup.entree2.GetItemName();
            label4.Text = "$" + Setup.entree2.GetItemPrice().ToString();
            if (Setup.entree2.IsAvailable())
            {
                label5.Text = "This item is available";
            }
            else
            {
                label5.Text = "This item is currently unavailable...";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Setup.selectedItem = Setup.entree3;
            label3.Show();
            label4.Show();
            label5.Show();
            label3.Text = Setup.entree3.GetItemName();
            label4.Text = "$" + Setup.entree3.GetItemPrice().ToString();
            if (Setup.entree3.IsAvailable())
            {
                label5.Text = "This item is available";
            }
            else
            {
                label5.Text = "This item is currently unavailable...";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Setup.selectedItem = Setup.entree4;
            label3.Show();
            label4.Show();
            label5.Show();
            label3.Text = Setup.entree4.GetItemName();
            label4.Text = "$" + Setup.entree4.GetItemPrice().ToString();
            if (Setup.entree4.IsAvailable())
            {
                label5.Text = "This item is available";
            }
            else
            {
                label5.Text = "This item is currently unavailable...";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Setup.selectedItem = Setup.entree5;
            label3.Show();
            label4.Show();
            label5.Show();
            label3.Text = Setup.entree5.GetItemName();
            label4.Text = "$" + Setup.entree5.GetItemPrice().ToString();
            if (Setup.entree5.IsAvailable())
            {
                label5.Text = "This item is available";
            }
            else
            {
                label5.Text = "This item is currently unavailable...";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Setup.selectedItem = Setup.drink1;
            label3.Show();
            label4.Show();
            label5.Show();
            label3.Text = Setup.drink1.GetItemName();
            label4.Text = "$" + Setup.drink1.GetItemPrice().ToString();
            if (Setup.drink1.IsAvailable())
            {
                label5.Text = "This item is available";
            }
            else
            {
                label5.Text = "This item is currently unavailable...";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Setup.selectedItem = Setup.drink2;
            label3.Show();
            label4.Show();
            label5.Show();
            label3.Text = Setup.drink2.GetItemName();
            label4.Text = "$" + Setup.drink2.GetItemPrice().ToString();
            if (Setup.drink2.IsAvailable())
            {
                label5.Text = "This item is available";
            }
            else
            {
                label5.Text = "This item is currently unavailable...";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Setup.selectedItem = Setup.drink3;
            label3.Show();
            label4.Show();
            label5.Show();
            label3.Text = Setup.drink3.GetItemName();
            label4.Text = "$" + Setup.drink3.GetItemPrice().ToString();
            if (Setup.drink3.IsAvailable())
            {
                label5.Text = "This item is available";
            }
            else
            {
                label5.Text = "This item is currently unavailable...";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Setup.selectedItem = Setup.drink4;
            label3.Show();
            label4.Show();
            label5.Show();
            label3.Text = Setup.drink4.GetItemName();
            label4.Text = "$" + Setup.drink4.GetItemPrice().ToString();
            if (Setup.drink4.IsAvailable())
            {
                label5.Text = "This item is available";
            }
            else
            {
                label5.Text = "This item is currently unavailable...";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Item i = Setup.selectedItem;
            Setup.selectedTable.AddToBill(i);
            label6.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
