
using System;

namespace AWP_jewerlyshop
{
    public partial class DelWin : Window
    {
        public static int product_idv;
        public DelWin()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        { 
            ProductWin win = new ProductWin();
            win.Show();
            this.Close();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                product_idv = Convert.ToInt32(del_t.Text);
                DataBase.del_product(product_idv);
                MainWindow.win.Close();
                ProductWin win = new ProductWin();
                win.Show();
                this.Close();                
            }
            catch
            {
                MessageBox.Show("Введите номер продукта, который хотите удалить");
                this.Close();
            }
        }
    }
}
