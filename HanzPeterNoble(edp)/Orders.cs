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
    public partial class Orders : Form
    {
        private List<string> FoodList;
        private List<string> DrinkList;

        public Orders(List<string> foods, List<string> drinks)
        {
            InitializeComponent();
            FoodList = foods;
            DrinkList = drinks;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            view1.View = View.List;
            view2.View = View.List;

            RefreshLists();
        }

        private void RefreshLists()
        {
            view1.Items.Clear();
            foreach (string food in FoodList)
                view1.Items.Add(food);

            view2.Items.Clear();
            foreach (string drink in DrinkList)
                view2.Items.Add(drink);
        }

        private void order_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();

            foreach (ListViewItem item in view1.SelectedItems)
                selectedItems.Add(item.Text);

            foreach (ListViewItem item in view2.SelectedItems)
                selectedItems.Add(item.Text);

            ProcessOrder processForm = new ProcessOrder(selectedItems);
            processForm.ShowDialog();
        }
    }
}
