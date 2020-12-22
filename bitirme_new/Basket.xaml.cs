using System;
using System.Collections.Generic;
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

using System.Data.SqlClient;
using System.Data;

namespace bitirme_new
{
    /// <summary>
    /// Interaction logic for Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {
        Table t = new Table();
      
        public Basket()
        {
            
            InitializeComponent();
            DisplayGrid();

        }
        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Main_Menu n = new Main_Menu();
            n.Show();
            this.Close();
        }

        private void DataGridBasket_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayGrid();

            dataGridBasket.Columns[0].Header = "Table Number";
            dataGridBasket.Columns[1].Header = "Order Name";
            dataGridBasket.Columns[2].Header = "Price";
            dataGridBasket.Columns[3].Header = "Count";
            dataGridBasket.Columns[4].Header = "Total Price";



        }
        public void DisplayGrid()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                con.Open();
                if (Table.table_id == 1) { 
                SqlDataAdapter da = new SqlDataAdapter("Select tablenum,order_name,price,count1,totalprice From ORDR1", con);
                DataTable table = new DataTable();
                da.Fill(table);

                dataGridBasket.ItemsSource = table.DefaultView;
                }
                else if (Table.table_id == 2)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select tablenum,order_name,price,count2,totalprice From ORDR2", con);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    dataGridBasket.ItemsSource = table.DefaultView;
                }
                else if (Table.table_id == 3)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select tablenum,order_name,price,count3,totalprice From ORDR3", con);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    dataGridBasket.ItemsSource = table.DefaultView;
                }
                con.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("List cannot be found");
            }
        }

       

        private void Button_Click(object sender, RoutedEventArgs e) //complete order button
        {                     
            Pay p = new Pay();
            string payment= totalpriceLabel.Content.ToString();
            p.pay.Content =payment;
            feedback f = new feedback();
            f.Show();
            this.Close();
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True"); ;
            SqlCommand cmd1 = new SqlCommand();

            SqlCommand totalPriceControl = new SqlCommand();

            while (dataGridBasket.SelectedItems.Count >= 1)
            {

                con1.Open();
                DataRowView row = (DataRowView)dataGridBasket.SelectedItem;
                double totalSelected = Convert.ToDouble(row.Row.ItemArray[4].ToString());
                totalpriceLabel.Content = ((Convert.ToDouble(totalpriceLabel.Content) - totalSelected)).ToString();
                if (Table.table_id == 1)
                {

                    string r = @"DELETE FROM ORDR1 WHERE order_name=@order_name";
                    cmd1 = new SqlCommand(r, con1);
                    cmd1.Parameters.AddWithValue("@order_name", row.Row.ItemArray[1].ToString());

                }

                else if (Table.table_id == 2)
                {
                    string r = @"DELETE FROM ORDR2 WHERE order_name=@order_name ";

                    cmd1 = new SqlCommand(r, con1);

                    cmd1.Parameters.AddWithValue("@order_name", row.Row.ItemArray[1].ToString());
                }
                else if (Table.table_id == 3)
                {
                    string r = @"DELETE FROM ORDR3 WHERE order_name=@order_name ";

                    cmd1 = new SqlCommand(r, con1);

                    cmd1.Parameters.AddWithValue("@order_name", row.Row.ItemArray[1].ToString());
                }

                //cmd1.Parameters.AddWithValue("@Price", dataGridBasket.CurrentItem ?? (object)DBNull.Value);
                //cmd1.Parameters.AddWithValue("@Count", dataGridBasket.CurrentItem ?? (object)DBNull.Value);

                cmd1.ExecuteNonQuery();
                con1.Close();
                row.Row.Delete();

            }

        }



        private void Note_Click(object sender, RoutedEventArgs e)
        {
            Note n = new Note();
            n.Show();
        }
    }
}
       
