using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Invoice.xaml
    /// </summary>
    public partial class Invoice : Window
    {
        public Invoice()
        {
            InitializeComponent();
            DisplayGrid();
        }

        private void DataGridInvoice_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayGrid();

            dataGridInvoice.Columns[0].Header = "Table Number";
            dataGridInvoice.Columns[1].Header = "Order Name";
            dataGridInvoice.Columns[2].Header = "Price";
            dataGridInvoice.Columns[3].Header = "Count";
            dataGridInvoice.Columns[4].Header = "Total Price";
           
        }
        public void DisplayGrid()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                con.Open();
                if (Table.table_id == 1)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select tablenum,order_name,price,count1,totalprice From ORDR1", con);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    dataGridInvoice.ItemsSource = table.DefaultView;
                }
                else if (Table.table_id == 2)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select tablenum,order_name,price,count2,totalprice From ORDR2", con);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    dataGridInvoice.ItemsSource = table.DefaultView;
                }
                else if (Table.table_id == 3)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select tablenum,order_name,price,count3,totalprice From ORDR3", con);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    dataGridInvoice.ItemsSource = table.DefaultView;
                }
                con.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("List cannot be found");
            }
        }

        private void Customer_Loaded(object sender, RoutedEventArgs e)
        {
            Customer.Content = Pay.index;
        }

        private void OrderDate_Loaded(object sender, RoutedEventArgs e)
        {
            OrderDate.Content = DateTime.Now.ToShortDateString();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Main_Menu m = new Main_Menu();;
            m.Show();
            this.Close();
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            feedbackscreen2 f = new feedbackscreen2();
            f.Show();
            this.Close();
        }
    }
}
