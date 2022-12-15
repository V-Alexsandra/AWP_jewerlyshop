namespace AWP_jewerlyshop
{
    internal class DataBase
    {
        public static MySqlCommand cmd;
        public static readonly MySqlConnection mycon = new("SERVER=localhost;DATABASE=jewerlyshop;UID=root;PASSWORD=sasha3003;");
        public static DataTable dt;
        public static MySqlDataAdapter adpt;

        public static int available_shop_count;

        public static int shop_id;
        public static int sex_id;
        public static int sample_id;
        public static int size_id;
        public static int gem_id;
        public static int design_id;
        public static int metall_id;
        public static int producttype_id;
        public static int characteristic_id;

        public static void checkconnection()
        {
            try
            {
                mycon.Open();
            }
            catch (System.InvalidOperationException)
            {
                mycon.Close();
                mycon.Open();
            }
        }

        public static void available_shops()
        {
            checkconnection();
            cmd = new MySqlCommand($"select count(shop_id) from shop", mycon);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                available_shop_count = Convert.ToInt32(reader[0]);
            }
            reader.Close();
        }
        public static void show_info_shop()
        {
            checkconnection();
            adpt = new MySqlDataAdapter($"select shop_id as \"Номер магазина\",city as \"Город\", street as \"Улица\", house as \"Дом\" from shop;", mycon);
            dt = new DataTable();
            adpt.Fill(dt);
            mycon.Close();
        }

        public static void show_info_product()
        {
            checkconnection();
            adpt = new MySqlDataAdapter($"select product_id as \"Номер товара\", producttype.producttype as \"Вид украшения\", metall.metalltype as \"Вид металла\", gem.gemtype as \"Вид вставки\", size.size as \"Размер\", sex.whom as \"Для кого\",  design.design as \"Конструкция\", product.weight as \"Вес украшения\", product.count as \"Количество\", product.price as \"Стоимость\"  from product inner join producttype on product.producttype_id=producttype.producttype_id inner join characteristic on product.characteristic_id = characteristic.characteristic_id inner join sex on characteristic.sex_id = sex.sex_id inner join metall on characteristic.metall_id = metall.metall_id inner join size on characteristic.size_id = size.size_id inner join gem on characteristic.gem_id = gem.gem_id inner join design on characteristic.design_id = design.design_id where product.shop_id = {shop_id}", mycon);
            dt = new DataTable();
            adpt.Fill(dt);
            mycon.Close();
        }

        public static void show_info_outofstork()
        {
            checkconnection();
            adpt = new MySqlDataAdapter($"select product_id as \"Номер товара\", producttype.producttype as \"Вид украшения\", metall.metalltype as \"Вид металла\", gem.gemtype as \"Вид вставки\", size.size as \"Размер\", sex.whom as \"Для кого\",  design.design as \"Конструкция\", product.weight as \"Вес украшения\", product.count as \"Количество\", product.price as \"Стоимость\"  from product inner join producttype on product.producttype_id=producttype.producttype_id inner join characteristic on product.characteristic_id = characteristic.characteristic_id inner join sex on characteristic.sex_id = sex.sex_id inner join metall on characteristic.metall_id = metall.metall_id inner join size on characteristic.size_id = size.size_id inner join gem on characteristic.gem_id = gem.gem_id inner join design on characteristic.design_id = design.design_id where product.count = 0", mycon);
            dt = new DataTable();
            adpt.Fill(dt);
            mycon.Close();
        }

        public static void show_info_rings()
        {
            checkconnection();
            adpt = new MySqlDataAdapter($"select product_id as \"Номер товара\", producttype.producttype as \"Вид украшения\", metall.metalltype as \"Вид металла\", gem.gemtype as \"Вид вставки\", size.size as \"Размер\", sex.whom as \"Для кого\",  design.design as \"Конструкция\", product.weight as \"Вес украшения\", product.count as \"Количество\", product.price as \"Стоимость\"  from product inner join producttype on product.producttype_id=producttype.producttype_id inner join characteristic on product.characteristic_id = characteristic.characteristic_id inner join sex on characteristic.sex_id = sex.sex_id inner join metall on characteristic.metall_id = metall.metall_id inner join size on characteristic.size_id = size.size_id inner join gem on characteristic.gem_id = gem.gem_id inner join design on characteristic.design_id = design.design_id where producttype.producttype = \"Кольцо\"", mycon);
            dt = new DataTable();
            adpt.Fill(dt);
            mycon.Close();
        }

        public static void show_info_ears()
        {
            checkconnection();
            adpt = new MySqlDataAdapter($"select product_id as \"Номер товара\", producttype.producttype as \"Вид украшения\", metall.metalltype as \"Вид металла\", gem.gemtype as \"Вид вставки\", size.size as \"Размер\", sex.whom as \"Для кого\",  design.design as \"Конструкция\", product.weight as \"Вес украшения\", product.count as \"Количество\", product.price as \"Стоимость\"  from product inner join producttype on product.producttype_id=producttype.producttype_id inner join characteristic on product.characteristic_id = characteristic.characteristic_id inner join sex on characteristic.sex_id = sex.sex_id inner join metall on characteristic.metall_id = metall.metall_id inner join size on characteristic.size_id = size.size_id inner join gem on characteristic.gem_id = gem.gem_id inner join design on characteristic.design_id = design.design_id where producttype.producttype = \"Серьги\"", mycon);
            dt = new DataTable();
            adpt.Fill(dt);
            mycon.Close();
        }

        public static void show_info_braslets()
        {
            checkconnection();
            adpt = new MySqlDataAdapter($"select product_id as \"Номер товара\", producttype.producttype as \"Вид украшения\", metall.metalltype as \"Вид металла\", gem.gemtype as \"Вид вставки\", size.size as \"Размер\", sex.whom as \"Для кого\",  design.design as \"Конструкция\", product.weight as \"Вес украшения\", product.count as \"Количество\", product.price as \"Стоимость\"  from product inner join producttype on product.producttype_id=producttype.producttype_id inner join characteristic on product.characteristic_id = characteristic.characteristic_id inner join sex on characteristic.sex_id = sex.sex_id inner join metall on characteristic.metall_id = metall.metall_id inner join size on characteristic.size_id = size.size_id inner join gem on characteristic.gem_id = gem.gem_id inner join design on characteristic.design_id = design.design_id where producttype.producttype = \"Браслет\"", mycon);
            dt = new DataTable();
            adpt.Fill(dt);
            mycon.Close();
        }

        public static void show_info_chains()
        {
            checkconnection();
            adpt = new MySqlDataAdapter($"select product_id as \"Номер товара\", producttype.producttype as \"Вид украшения\", metall.metalltype as \"Вид металла\", gem.gemtype as \"Вид вставки\", size.size as \"Размер\", sex.whom as \"Для кого\",  design.design as \"Конструкция\", product.weight as \"Вес украшения\", product.count as \"Количество\", product.price as \"Стоимость\"  from product inner join producttype on product.producttype_id=producttype.producttype_id inner join characteristic on product.characteristic_id = characteristic.characteristic_id inner join sex on characteristic.sex_id = sex.sex_id inner join metall on characteristic.metall_id = metall.metall_id inner join size on characteristic.size_id = size.size_id inner join gem on characteristic.gem_id = gem.gem_id inner join design on characteristic.design_id = design.design_id where producttype.producttype = \"Цепи\"", mycon);
            dt = new DataTable();
            adpt.Fill(dt);
            mycon.Close();
        }

        public static void show_info_pendent()
        {
            checkconnection();
            adpt = new MySqlDataAdapter($"select product_id as \"Номер товара\", producttype.producttype as \"Вид украшения\", metall.metalltype as \"Вид металла\", gem.gemtype as \"Вид вставки\", size.size as \"Размер\", sex.whom as \"Для кого\",  design.design as \"Конструкция\", product.weight as \"Вес украшения\", product.count as \"Количество\", product.price as \"Стоимость\"  from product inner join producttype on product.producttype_id=producttype.producttype_id inner join characteristic on product.characteristic_id = characteristic.characteristic_id inner join sex on characteristic.sex_id = sex.sex_id inner join metall on characteristic.metall_id = metall.metall_id inner join size on characteristic.size_id = size.size_id inner join gem on characteristic.gem_id = gem.gem_id inner join design on characteristic.design_id = design.design_id where producttype.producttype = \"Подвески\"", mycon);
            dt = new DataTable();
            adpt.Fill(dt);
            mycon.Close();
        }

        public static void get_values(string whom, int samplev, string gemtypev, double sizev, string designv, string producttypev, string metalltypev)
        {
            checkconnection();
            cmd = new MySqlCommand($"select sex_id from sex where whom = '{whom}'", mycon);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                sex_id = Convert.ToInt32(reader[0]);
            }
            reader.Close();   
            
            cmd = new MySqlCommand($"select sample_id from sample where sample = {samplev}", mycon);
            var reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                sample_id = Convert.ToInt32(reader1[0]);
            }
            reader1.Close();

            cmd = new MySqlCommand($"select gem_id from gem where gemtype = '{gemtypev}'", mycon);
            var reader2 = cmd.ExecuteReader();
            if (reader2.Read())
            {
                gem_id = Convert.ToInt32(reader2[0]);
            }
            reader2.Close();

            cmd = new MySqlCommand($"select metall_id from metall where metalltype = '{metalltypev}' and sample_id = {sample_id}; ", mycon);
            var reader7 = cmd.ExecuteReader();
            if (reader7.Read())
            {
               metall_id = Convert.ToInt32(reader7[0]);
            }
            reader7.Close();

            cmd = new MySqlCommand($"select size_id from size where size = {sizev}", mycon);
            var reader3 = cmd.ExecuteReader();
            if (reader3.Read())
            {
                size_id = Convert.ToInt32(reader3[0]);
            }
            reader3.Close();

            cmd = new MySqlCommand($"select design_id from design where design = '{designv}'", mycon);
            var reader4 = cmd.ExecuteReader();
            if (reader4.Read())
            {
                design_id = Convert.ToInt32(reader4[0]);
            }
            reader4.Close();

            cmd = new MySqlCommand($"select producttype_id from producttype where producttype = '{producttypev}'", mycon);
            var reader5 = cmd.ExecuteReader();
            if (reader5.Read())
            {
                producttype_id = Convert.ToInt32(reader5[0]);
            }
            reader5.Close();

            cmd = new MySqlCommand($"select count(characteristic_id) from characteristic;", mycon);
            var reader6 = cmd.ExecuteReader();
            if (reader6.Read())
            {
                characteristic_id = Convert.ToInt32(reader6[0]);
                characteristic_id++;
            }
            reader6.Close();

            mycon.Close();
        }

        public static void add_product(double price, double weight, int count)
        {
            checkconnection();
            cmd = new MySqlCommand("insert characteristic(characteristic_id, sex_id, metall_id, gem_id, size_id, design_id) values (@characteristic_id, @sex_id, @metall_id, @gem_id, @size_id, @design_id)", mycon);
            cmd.Parameters.AddWithValue("@characteristic_id", characteristic_id);
            cmd.Parameters.AddWithValue("@sex_id", sex_id);
            cmd.Parameters.AddWithValue("@metall_id", metall_id);
            cmd.Parameters.AddWithValue("@gem_id", gem_id);
            cmd.Parameters.AddWithValue("@size_id", size_id);
            cmd.Parameters.AddWithValue("@design_id", design_id);
            cmd.ExecuteNonQuery();

            cmd = new MySqlCommand("insert product(producttype_id, price, weight, shop_id, count, characteristic_id) values (@producttype_id, @price, @weight, @shop_id, @count, @characteristic_id)", mycon);
            cmd.Parameters.AddWithValue("@producttype_id", producttype_id);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@weight", weight);
            cmd.Parameters.AddWithValue("@shop_id", shop_id);
            cmd.Parameters.AddWithValue("@count", count);
            cmd.Parameters.AddWithValue("@characteristic_id", characteristic_id);
            cmd.ExecuteNonQuery();

            mycon.Close();

        }

        public static void del_out_product(int product_id)
        {
            checkconnection();
            adpt = new MySqlDataAdapter($"delete from product where product_id = {product_id}", mycon);
            dt = new DataTable();
            adpt.Fill(dt);
            mycon.Close();
        }

        public static void add_out_product(int product_id, int count)
        {
            checkconnection();
            adpt = new MySqlDataAdapter($"update product SET count = {count} where product_id = {product_id}", mycon);
            dt = new DataTable();
            adpt.Fill(dt);
        }

        public static void del_product(int product_id)
        {
            checkconnection();
            adpt = new MySqlDataAdapter($"delete from product where product_id = {product_id}", mycon);
            dt = new DataTable();
            adpt.Fill(dt);

            adpt = new MySqlDataAdapter($"delete from characteristic where characteristic_id = {product_id}", mycon);
            dt = new DataTable();
            adpt.Fill(dt);
            mycon.Close();
        }
    }
}
