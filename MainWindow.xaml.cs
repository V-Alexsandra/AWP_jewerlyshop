using System;
using System.Collections.Generic;
using System.Linq;
namespace AWP_jewerlyshop
{
    public partial class MainWindow : Window
    {
        public static ProductWin win;
        public MainWindow()
        {
            InitializeComponent();
            DataBase.show_info_shop();
            shop.DataContext = DataBase.dt;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataBase.available_shops();
                DataBase.shop_id = Convert.ToInt32(shop_id_textbox.Text);
                if (DataBase.shop_id > DataBase.available_shop_count)
                {
                    throw new Exception();
                }
                win = new ProductWin();
                win.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введите корректное значение");
            }
        }

        private void Buttonref_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для начала работы с преложением необходимо выбрать магазин ювелирных изделий. После ввода номера магазина откроется форма, которая содержит все товары в данном магазине. Дробные числа вводятся через точку. Чтобы добавить товар нужно нажать на кнопку \"Добавить товар\", для удаления товара \"Удалить товар\". Для сортировки товаров необходимо нажать на столбец, который нужно отсортировать. При нажатии на соответствующие кнопки, можно вывести определенную категорию товара. \n \n \n Разработала: Воронкова Александра");
        }
    }
}
