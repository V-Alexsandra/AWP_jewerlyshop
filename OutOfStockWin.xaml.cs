namespace AWP_jewerlyshop
{
    /// <summary>
    /// Interaction logic for OutOfStockWin.xaml
    /// </summary>
    public partial class OutOfStockWin : Window
    {
        public static int product_idv;
        public static int countv;

        

        public OutOfStockWin()
        {
            InitializeComponent();
            DataBase.show_info_outofstork();
            product.DataContext = DataBase.dt;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ProductWin win = new ProductWin();
            win.Show();
            this.Close();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                product_idv = Convert.ToInt32(product_id_textbox.Text);
                DataBase.del_out_product(product_idv);
                DataBase.show_info_outofstork();
                ProductWin win = new ProductWin();
                win.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Укажите номер товара");
            }
       
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                product_idv = Convert.ToInt32(product_id_textbox.Text);
                AddOutofstork win = new AddOutofstork();
                win.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Укажите номер товара");
            }
            
        }
    }
}
