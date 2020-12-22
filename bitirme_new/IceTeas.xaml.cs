using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace bitirme_new
{
    /// <summary>
    /// Interaction logic for IceTeas.xaml
    /// </summary>
    public partial class IceTeas : Window
    {
        int a = 0;
        int b = 0;
        int c = 0;

        SqlConnection con;
        SqlCommand cmd;
        public IceTeas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainDrinks d = new MainDrinks();
            d.Show();
            this.Close();
        }


        private void Addition1_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            count1.Text = a.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            con.Open();
            if (Table.table_id == 1)
            {

                string record1 = @"IF EXISTS(SELECT * FROM ORDR1 WHERE order_name = @order_name)
                        UPDATE ORDR1 SET count1 = @count1 WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR1(order_name, price,count1,tablenum) VALUES(@order_name, @price,@count1,@tablenum);";
                cmd = new SqlCommand(record1, con);
                cmd.Parameters.AddWithValue("@order_name", tea1.Content);
                cmd.Parameters.AddWithValue("@price", price1.Content);
                cmd.Parameters.AddWithValue("@count1", count1.Text);
                cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                cmd.ExecuteNonQuery();

            }
            else if (Table.table_id == 2)
            {
                string record2 = @"IF EXISTS(SELECT * FROM ORDR2 WHERE order_name = @order_name)
                        UPDATE ORDR2 SET count2 = @count2 WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR2(order_name, price,count2,tablenum) VALUES(@order_name, @price,@count2,@tablenum);";
                cmd = new SqlCommand(record2, con);
                cmd.Parameters.AddWithValue("@order_name", tea1.Content);
                cmd.Parameters.AddWithValue("@price", price1.Content);
                cmd.Parameters.AddWithValue("@count2", count1.Text);
                cmd.Parameters.AddWithValue("@tablenum", Table.table_id);


                cmd.ExecuteNonQuery();

            }
            else if (Table.table_id == 3)
            {
                string record3 = @"IF EXISTS(SELECT * FROM ORDR3 WHERE order_name = @order_name)
                        UPDATE ORDR3 SET count3 = @count3 WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR3(order_name, price,count3,tablenum) VALUES(@order_name, @price,@count3,@tablenum);";
                cmd = new SqlCommand(record3, con);
                cmd.Parameters.AddWithValue("@order_name", tea1.Content);
                cmd.Parameters.AddWithValue("@price", price1.Content);
                cmd.Parameters.AddWithValue("@count3", count1.Text);
                cmd.Parameters.AddWithValue("@tablenum", Table.table_id);


                cmd.ExecuteNonQuery();

            }

            con.Close();

        }

        private void Remove1_Click(object sender, RoutedEventArgs e)
        {

            if (a > 0)
            {
                a = a - 1;
                count1.Text = a.ToString();
                con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

                con.Open();
                if (Table.table_id == 1)
                {
                    string record1 = @"IF EXISTS(SELECT * FROM ORDR1 WHERE order_name = @order_name)
                        UPDATE ORDR1 SET count1 = @count1 WHERE order_name = @order_name
                        DELETE FROM ORDR1 WHERE count1=0";

                    cmd = new SqlCommand(record1, con);

                    cmd.Parameters.AddWithValue("@order_name", tea1.Content);
                    cmd.Parameters.AddWithValue("@price", price1.Content);
                    cmd.Parameters.AddWithValue("@count1", count1.Text);
                    cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                    cmd.ExecuteNonQuery();

                }
                else if (Table.table_id == 2)
                {
                    string record2 = @"IF EXISTS(SELECT * FROM ORDR2 WHERE order_name = @order_name)
                        UPDATE ORDR2 SET count2 = @count2 WHERE order_name = @order_name
                        DELETE FROM ORDR2 WHERE count2=0";


                    cmd = new SqlCommand(record2, con);
                    cmd.Parameters.AddWithValue("@order_name", tea1.Content);
                    cmd.Parameters.AddWithValue("@price", price1.Content);
                    cmd.Parameters.AddWithValue("@count2", count1.Text);
                    cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                    cmd.ExecuteNonQuery();

                }
                else if (Table.table_id == 3)
                {
                    string record3 = @"IF EXISTS(SELECT * FROM ORDR3 WHERE order_name = @order_name)
                        UPDATE ORDR3 SET count3 = @count3 WHERE order_name = @order_name
                        DELETE FROM ORDR3 WHERE count3=0";


                    cmd = new SqlCommand(record3, con);
                    cmd.Parameters.AddWithValue("@order_name", tea1.Content);
                    cmd.Parameters.AddWithValue("@price", price1.Content);
                    cmd.Parameters.AddWithValue("@count3", count1.Text);
                    cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                    cmd.ExecuteNonQuery();

                }




                con.Close();
            }
        }

        private void Addition2_Click(object sender, RoutedEventArgs e)
        {
            b = b + 1;
            count2.Text = b.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            con.Open();
            if (Table.table_id == 1)
            {
                string record1 = @"IF EXISTS(SELECT * FROM ORDR1 WHERE order_name = @order_name)
                        UPDATE ORDR1 SET count1 = @count1 WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR1(order_name, price,count1,tablenum) VALUES(@order_name, @price,@count1,@tablenum);";
                cmd = new SqlCommand(record1, con);
                cmd.Parameters.AddWithValue("@order_name", tea2.Content);
                cmd.Parameters.AddWithValue("@price", price2.Content);
                cmd.Parameters.AddWithValue("@count1", count2.Text);
                cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                cmd.ExecuteNonQuery();

            }
            else if (Table.table_id == 2)
            {
                string record2 = @"IF EXISTS(SELECT * FROM ORDR2 WHERE order_name = @order_name)
                        UPDATE ORDR2 SET count2 = @count2 WHERE order_name = @order_name
                    ELSE
                       INSERT INTO ORDR2(order_name, price,count2,tablenum) VALUES(@order_name, @price,@count2,@tablenum);";
                cmd = new SqlCommand(record2, con);
                cmd.Parameters.AddWithValue("@order_name", tea2.Content);
                cmd.Parameters.AddWithValue("@price", price2.Content);
                cmd.Parameters.AddWithValue("@count2", count2.Text);
                cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                cmd.ExecuteNonQuery();


            }
            else if (Table.table_id == 3)
            {
                string record3 = @"IF EXISTS(SELECT * FROM ORDR3 WHERE order_name = @order_name)
                        UPDATE ORDR3 SET count3 = @count3 WHERE order_name = @order_name
                    ELSE
                       INSERT INTO ORDR3(order_name, price,count3,tablenum) VALUES(@order_name, @price,@count3,@tablenum);";
                cmd = new SqlCommand(record3, con);
                cmd.Parameters.AddWithValue("@order_name", tea2.Content);
                cmd.Parameters.AddWithValue("@price", price2.Content);
                cmd.Parameters.AddWithValue("@count3", count2.Text);
                cmd.Parameters.AddWithValue("@tablenum", Table.table_id);


                cmd.ExecuteNonQuery();
            }
        }

        private void Remove2_Click(object sender, RoutedEventArgs e)
        {
            if (b > 0)
            {
                b = b - 1;
                count2.Text = c.ToString();
                con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

                con.Open();
                if (Table.table_id == 1)
                {
                    string record1 = @"IF EXISTS(SELECT * FROM ORDR1 WHERE order_name = @order_name)
                        UPDATE ORDR1 SET count1 = @count1 WHERE order_name = @order_name
                        DELETE FROM ORDR1 WHERE count1=0";


                    cmd = new SqlCommand(record1, con);
                    cmd.Parameters.AddWithValue("@order_name", tea2.Content);
                    cmd.Parameters.AddWithValue("@price", price2.Content);
                    cmd.Parameters.AddWithValue("@count1", count2.Text);
                    cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                    cmd.ExecuteNonQuery();

                }
                else if (Table.table_id == 2)
                {
                    string record2 = @"IF EXISTS(SELECT * FROM ORDR2 WHERE order_name = @order_name)
                        UPDATE ORDR2 SET count2 = @count2 WHERE order_name = @order_name
                        DELETE FROM ORDR2 WHERE count2=0";


                    cmd = new SqlCommand(record2, con);
                    cmd.Parameters.AddWithValue("@order_name", tea2.Content);
                    cmd.Parameters.AddWithValue("@price", price2.Content);
                    cmd.Parameters.AddWithValue("@count2", count2.Text);
                    cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                    cmd.ExecuteNonQuery();


                }
                else if (Table.table_id == 3)
                {
                    string record3 = @"IF EXISTS(SELECT * FROM ORDR3 WHERE order_name = @order_name)
                        UPDATE ORDR3 SET count3 = @count3 WHERE order_name = @order_name
                        DELETE FROM ORDR3 WHERE count3=0";


                    cmd = new SqlCommand(record3, con);
                    cmd.Parameters.AddWithValue("@order_name", tea2.Content);
                    cmd.Parameters.AddWithValue("@price", price2.Content);
                    cmd.Parameters.AddWithValue("@count3", count2.Text);
                    cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                    cmd.ExecuteNonQuery();


                }


                con.Close();
            }
        }

        private void Addition3_Click(object sender, RoutedEventArgs e)
        {
            c = c + 1;
            count3.Text = c.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
            con.Open();
            if (Table.table_id == 1)
            {
                string record1 = @"IF EXISTS(SELECT * FROM ORDR1 WHERE order_name = @order_name)
                        UPDATE ORDR1 SET count1 = @count1 WHERE order_name = @order_name
                    ELSE
                       INSERT INTO ORDR1(order_name, price,count1,tablenum) VALUES(@order_name, @price,@count1,@tablenum);";
                cmd = new SqlCommand(record1, con);
                cmd.Parameters.AddWithValue("@order_name", tea3.Content);
                cmd.Parameters.AddWithValue("@price", price3.Content);
                cmd.Parameters.AddWithValue("@count1", count3.Text);
                cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                cmd.ExecuteNonQuery();


            }
            else if (Table.table_id == 2)
            {
                string record2 = @"IF EXISTS(SELECT * FROM ORDR2 WHERE order_name = @order_name)
                        UPDATE ORDR2 SET count2 = @count2 WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR2(order_name, price,count2,tablenum) VALUES(@order_name, @price,@count2,@tablenum);";
                cmd = new SqlCommand(record2, con);
                cmd.Parameters.AddWithValue("@order_name", tea3.Content);
                cmd.Parameters.AddWithValue("@price", price3.Content);
                cmd.Parameters.AddWithValue("@count2", count3.Text);
                cmd.Parameters.AddWithValue("@tablenum", Table.table_id);


                cmd.ExecuteNonQuery();


            }
            else if (Table.table_id == 3)
            {
                string record3 = @"IF EXISTS(SELECT * FROM ORDR3 WHERE order_name = @order_name)
                        UPDATE ORDR3 SET count3 = @count3 WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR3(order_name, price,count3,tablenum) VALUES(@order_name, @price,@count3,@tablenum);";
                cmd = new SqlCommand(record3, con);
                cmd.Parameters.AddWithValue("@order_name", tea3.Content);
                cmd.Parameters.AddWithValue("@price", price3.Content);
                cmd.Parameters.AddWithValue("@count3", count3.Text);
                cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                cmd.ExecuteNonQuery();


            }


            con.Close();
        }

        private void Remove3_Click(object sender, RoutedEventArgs e)
        {
            if (c > 0)
            {
                c = c - 1;
                count3.Text = c.ToString();
                con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
                con.Open();
                if (Table.table_id == 1)
                {
                    string record1 = @"IF EXISTS(SELECT * FROM ORDR1 WHERE order_name = @order_name)
                        UPDATE ORDR1 SET count1 = @count1 WHERE order_name = @order_name
                        DELETE FROM ORDR1 WHERE count1=0";


                    cmd = new SqlCommand(record1, con);
                    cmd.Parameters.AddWithValue("@order_name", tea3.Content);
                    cmd.Parameters.AddWithValue("@price", price3.Content);
                    cmd.Parameters.AddWithValue("@count1", count3.Text);
                    cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                    cmd.ExecuteNonQuery();

                }
                else if (Table.table_id == 2)
                {
                    string record2 = @"IF EXISTS(SELECT * FROM ORDR2 WHERE order_name = @order_name)
                        UPDATE ORDR2 SET count2 = @count2 WHERE order_name = @order_name
                        DELETE FROM ORDR2 WHERE count2=0";


                    cmd = new SqlCommand(record2, con);
                    cmd.Parameters.AddWithValue("@order_name", tea3.Content);
                    cmd.Parameters.AddWithValue("@price", price3.Content);
                    cmd.Parameters.AddWithValue("@count2", count3.Text);
                    cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                    cmd.ExecuteNonQuery();


                }
                else if (Table.table_id == 3)
                {
                    string record3 = @"IF EXISTS(SELECT * FROM ORDR3 WHERE order_name = @order_name)
                        UPDATE ORDR3 SET count3 = @count3 WHERE order_name = @order_name
                        DELETE FROM ORDR3 WHERE count3=0";


                    cmd = new SqlCommand(record3, con);
                    cmd.Parameters.AddWithValue("@order_name", tea3.Content);
                    cmd.Parameters.AddWithValue("@price", price3.Content);
                    cmd.Parameters.AddWithValue("@count3", count3.Text);
                    cmd.Parameters.AddWithValue("@tablenum", Table.table_id);

                    cmd.ExecuteNonQuery();

                }


                con.Close();
            }
        }

        private void GoBasket_Click(object sender, RoutedEventArgs e)
        {

            KitchenStaff k = new KitchenStaff();
            Basket basket = new Basket();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            con.Open();
            if (Table.table_id == 1)
            {
                string totalPrice = "SELECT SUM (totalprice) FROM ORDR1";
                SqlCommand cmd = new SqlCommand(totalPrice, con);

                double total1 = Convert.ToDouble(cmd.ExecuteScalar());


                basket.totalpriceLabel.Content = total1.ToString();
                k.table1.Background = Brushes.Red;
            }
            else if (Table.table_id == 2)
            {
                string totalPrice = "SELECT SUM (totalprice) FROM ORDR2";
                SqlCommand cmd = new SqlCommand(totalPrice, con);

                double total2 = Convert.ToDouble(cmd.ExecuteScalar());


                basket.totalpriceLabel.Content = total2.ToString();
                k.table2.Background = Brushes.Red;
            }
            if (Table.table_id == 3)
            {
                string totalPrice = "SELECT SUM (totalprice) FROM ORDR3";
                SqlCommand cmd = new SqlCommand(totalPrice, con);

                double total3 = Convert.ToDouble(cmd.ExecuteScalar());


                basket.totalpriceLabel.Content = total3.ToString();
                k.table3.Background = Brushes.Red;
            }

            con.Close();
            //k.Show();

            basket.Show();
            this.Close();
        }
    }
}
