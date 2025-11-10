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
    public partial class RemoveFood : Form
    {
        Products main;

        public RemoveFood(Products p)
        {
            InitializeComponent();
            main = p;
        }

        private void rev_Click(object sender, EventArgs e)
        {
            if (main.Foods.Contains(insert.Text.Trim()))
            {
                main.Foods.Remove(insert.Text.Trim());
                main.RefreshLists();
                label2.ForeColor = Color.Green;
                label2.Text = "Foood Removed successfully!";
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Food not found in list.";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
