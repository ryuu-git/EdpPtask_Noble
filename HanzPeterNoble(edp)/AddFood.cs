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
    public partial class AddFood : Form
    {
        private Products main;

        public AddFood(Products p)
        {
            InitializeComponent();
            main = p;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (insert.Text.Trim() != "")
            {
                main.Foods.Add(insert.Text.Trim());
                main.RefreshLists();
                label2.ForeColor = Color.Green;
                label2.Text = "Food added successfully!";
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Enter a food name.";
            }
        }
    }
}
