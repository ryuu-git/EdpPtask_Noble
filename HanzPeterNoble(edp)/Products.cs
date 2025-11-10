using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanzPeterNoble_edp_
{
    public partial class Products : Form
    {
        public List<string> Foods = new List<string>();
        public List<string> Drinks = new List<string>();

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            view1.Columns.Add("Food Name", 150);
            view2.Columns.Add("Drink Name", 150);
            RefreshLists();
        }

        public void RefreshLists()
        {
            view1.Items.Clear();
            foreach (string food in Foods)
            {
                view1.Items.Add(food);
            }

            view2.Items.Clear();
            foreach (string drink in Drinks)
            {
                view2.Items.Add(drink);
            }
        }

        private void add1_Click(object sender, EventArgs e)
        {
            AddFood addForm = new AddFood(this);
            addForm.ShowDialog();
        }

        private void rev1_Click(object sender, EventArgs e)
        {
            RemoveFood removeForm = new RemoveFood(this);
            removeForm.ShowDialog();
        }

        private void add2_Click(object sender, EventArgs e)
        {
            AddDrinks addDrinkForm = new AddDrinks(this);
            addDrinkForm.ShowDialog();
        }

        private void rev2_Click(object sender, EventArgs e)
        {
            RemoveDrinks removeDrinkForm = new RemoveDrinks(this);
            removeDrinkForm.ShowDialog();
        }
    }
}