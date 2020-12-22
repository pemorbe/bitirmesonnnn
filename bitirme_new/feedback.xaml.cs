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
    /// Interaction logic for feedback.xaml
    /// </summary>
    public partial class feedback : Window
    {
        SqlConnection con = new SqlConnection();
        public feedback()
        {
            InitializeComponent();
        }



        private void BackBasket_Click(object sender, RoutedEventArgs e)
        {
            Basket basket = new Basket();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
            con.Open();
            if (Table.table_id == 1)
            {
                string totalPrice = "SELECT SUM (totalprice) FROM ORDR1";
                SqlCommand cmd = new SqlCommand(totalPrice, con);

                double total1 = Convert.ToDouble(cmd.ExecuteScalar());


                basket.totalpriceLabel.Content = total1.ToString();
             

            }
            else if (Table.table_id == 2)
            {
                string totalPrice = "SELECT SUM (totalprice) FROM ORDR2";
                SqlCommand cmd = new SqlCommand(totalPrice, con);

                double total2 = Convert.ToDouble(cmd.ExecuteScalar());


                basket.totalpriceLabel.Content = total2.ToString();
               
            }
            if (Table.table_id == 3)
            {
                string totalPrice = "SELECT SUM (totalprice) FROM ORDR3";
                SqlCommand cmd = new SqlCommand(totalPrice, con);

                double total3 = Convert.ToDouble(cmd.ExecuteScalar());


                basket.totalpriceLabel.Content = total3.ToString();
               
            }

            con.Close();
            //k.Show();

            basket.Show();
            this.Close();
        }



        private void GoPay_Click(object sender, RoutedEventArgs e)
        {
            Pay p = new Pay();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
            con.Open();
            if (Table.table_id == 1)
            {
                string totalPrice = "SELECT SUM (totalprice) FROM ORDR1";
                SqlCommand cmd = new SqlCommand(totalPrice, con);

                double total1 = Convert.ToDouble(cmd.ExecuteScalar());


                p.pay.Content = total1.ToString();
               
            }
            else if (Table.table_id == 2)
            {
                string totalPrice = "SELECT SUM (totalprice) FROM ORDR2";
                SqlCommand cmd = new SqlCommand(totalPrice, con);

                double total2 = Convert.ToDouble(cmd.ExecuteScalar());


                p.pay.Content = total2.ToString();
            }
            if (Table.table_id == 3)
            {
                string totalPrice = "SELECT SUM (totalprice) FROM ORDR3";
                SqlCommand cmd = new SqlCommand(totalPrice, con);

                double total3 = Convert.ToDouble(cmd.ExecuteScalar());


                p.pay.Content = total3.ToString();
                
            }

            con.Close();
         
            p.Show();
            this.Close();
        }

                        
           
           
        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
