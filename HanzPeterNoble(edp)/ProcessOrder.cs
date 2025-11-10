using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace HanzPeterNoble_edp_
{
    public partial class ProcessOrder : Form
    {
        private List<string> orderItems;

        public ProcessOrder(List<string> items)
        {
            InitializeComponent();
            orderItems = new List<string>(items);
        }

        private void ProcessOrder_Load(object sender, EventArgs e)
        {
            view.View = View.List;
            RefreshList();
        }

        private void RefreshList()
        {
            view.Items.Clear();
            foreach (string item in orderItems)
                view.Items.Add(new ListViewItem(item));
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(insert.Text))
            {
                orderItems.Add(insert.Text);
                insert.Clear();
                RefreshList();
            }
        }

        private void rev_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selected in view.SelectedItems)
            {
                orderItems.Remove(selected.Text);
            }
            RefreshList();
        }

        private void print_Click(object sender, EventArgs e)
        {
            string name = names.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name before printing.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name}.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("PROCESS ORDER RECEIPT");
                writer.WriteLine("-----------------------");
                foreach (var item in orderItems)
                    writer.WriteLine(item);
                writer.WriteLine("-----------------------");
                writer.WriteLine($"Name: {name}");
                writer.WriteLine($"Date: {DateTime.Now}");
            }

            MessageBox.Show($"Order saved to {filePath}", "Printed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}