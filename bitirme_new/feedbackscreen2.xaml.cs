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
    /// Interaction logic for feedbackscreen2.xaml
    /// </summary>
    public partial class feedbackscreen2 : Window
    {
        SqlConnection con;
       
        public feedbackscreen2()
        {
            InitializeComponent();
        }

        private void GoInvoice_Click(object sender, RoutedEventArgs e)
        {
            Invoice inv = new Invoice();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
            con.Open();
            if (Table.table_id == 1)
            {
                string totalPrice = "SELECT SUM (totalprice) FROM ORDR1";
                SqlCommand cmd = new SqlCommand(totalPrice, con);

                double total1 = Convert.ToDouble(cmd.ExecuteScalar());


                inv.invoice.Content = total1.ToString();

            }
            else if (Table.table_id == 2)
            {
                string totalPrice = "SELECT SUM (totalprice) FROM ORDR2";
                SqlCommand cmd = new SqlCommand(totalPrice, con);

                double total2 = Convert.ToDouble(cmd.ExecuteScalar());


                inv.invoice.Content = total2.ToString();
            }
            if (Table.table_id == 3)
            {
                string totalPrice = "SELECT SUM (totalprice) FROM ORDR3";
                SqlCommand cmd = new SqlCommand(totalPrice, con);

                double total3 = Convert.ToDouble(cmd.ExecuteScalar());


                inv.invoice.Content = total3.ToString();

            }

            con.Close();

            inv.Show();
            this.Close();
        }


    
        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Pay p = new Pay();
            p.Show();
            this.Close();
        }
    }
}
