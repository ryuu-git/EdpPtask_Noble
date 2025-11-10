namespace HanzPeterNoble_edp_
{
    public partial class Form1 : Form
    {
        private Products productsForm = new Products();
        public Form1()
        {
            InitializeComponent();
        }

        private void view_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Show();
        }
        private void order_Click(object sender, EventArgs e)
        {
            Orders o = new Orders(productsForm.Foods, productsForm.Drinks);
            o.ShowDialog();
        }
    }
}   