using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HanzPeterNoble_edp_
{
    public partial class RemoveDrinks : Form
    {
        Products main;

        public RemoveDrinks(Products p)
        {
            InitializeComponent();
            main = p;
        }

        private void rev_Click(object sender, EventArgs e)
        {
            if (main.Drinks.Contains(insert.Text.Trim()))
            {
                main.Drinks.Remove(insert.Text.Trim());
                main.RefreshLists();
                label2.ForeColor = Color.Green;
                label2.Text = "Drink Removed successfully!";
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Drink not found in list.";
            }
        }
    }
}
