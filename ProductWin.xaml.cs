namespace AWP_jewerlyshop
{
    public partial class ProductWin : Window
    {
        public ProductWin()
        {
            InitializeComponent();
            DataBase.show_info_product();
            product.DataContext = DataBase.dt;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddProductWin win = new AddProductWin();
            win.Show();
            this.Close();
        }

        private void countbtn_Click(object sender, RoutedEventArgs e)
        {
            OutOfStockWin win = new OutOfStockWin();
            win.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void Buttondel_Click(object sender, RoutedEventArgs e)
        {
            DelWin win = new DelWin();
            win.Show();
            this.Close();
        }

        private void Buttonring_Click(object sender, RoutedEventArgs e)
        {
            DataBase.show_info_rings();
            product.DataContext = DataBase.dt;
        }

        private void Buttonears_Click(object sender, RoutedEventArgs e)
        {
            DataBase.show_info_ears();
            product.DataContext = DataBase.dt;
        }

        private void Buttbraslets_Click(object sender, RoutedEventArgs e)
        {
            DataBase.show_info_braslets();
            product.DataContext = DataBase.dt;
        }

        private void Buttonchains_Click(object sender, RoutedEventArgs e)
        {
            DataBase.show_info_chains();
            product.DataContext = DataBase.dt;
        }

        private void Buttonpendent_Click(object sender, RoutedEventArgs e)
        {

            DataBase.show_info_pendent();
            product.DataContext = DataBase.dt;
        }

        private void all_Click(object sender, RoutedEventArgs e)
        {
            DataBase.show_info_product();
            product.DataContext = DataBase.dt;
        }
    }
}
