namespace AWP_jewerlyshop
{
    public partial class AddOutofstork : Window
    {
        public static int count;
        public AddOutofstork()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                count = Convert.ToInt32(add_t.Text);
                DataBase.add_out_product(OutOfStockWin.product_idv, count);
                ProductWin win = new ProductWin();
                win.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введите корректное значение");
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            DataBase.add_out_product(OutOfStockWin.product_idv, count);
            ProductWin win = new ProductWin();
            win.Show();
            this.Close();
        }
    }
}
