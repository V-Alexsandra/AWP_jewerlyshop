using System;

namespace AWP_jewerlyshop
{
    /// <summary>
    /// Interaction logic for AddProductWin.xaml
    /// </summary>
    public partial class AddProductWin : Window
    {
        public static string? whom;
        public static int samplev;
        public static string? gemtypev;
        public static double sizev;
        public static string? designv;
        public static string? producttypev;
        public static string? metalltypev;

        public static double pricev;
        public static double weightv;
        public static int countv;

        public AddProductWin()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ProductWin win = new ProductWin();
            win.Show();
            this.Close();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                samplev = Convert.ToInt32(sample.Text.Substring(sample.Text.Length - 3, 3));

                gemtypev = gemtype.Text;
                sizev = Convert.ToDouble(size.Text);
                designv = design.Text;
                producttypev = producttype.Text;
                metalltypev = metalltype.Text;

                pricev = Convert.ToDouble(price.Text);
                weightv = Convert.ToDouble(weight.Text);
                countv = Convert.ToInt32(count.Text);
                DataBase.get_values(whom, samplev, gemtypev, sizev, designv, producttypev, metalltypev);
                DataBase.add_product(pricev, weightv, countv);
                ProductWin win2 = new ProductWin();
                win2.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Данные введены некорректно");
            }
        }

        private void for_kids_Checked(object sender, RoutedEventArgs e) { whom = "Для детей"; }

        private void ynisex_Checked(object sender, RoutedEventArgs e) { whom = "Унисекс"; }

        private void for_man_Checked(object sender, RoutedEventArgs e) { whom = "Для мужчин"; }

        private void for_women_Checked(object sender, RoutedEventArgs e) { whom = "Для женщин"; }
    }
}
