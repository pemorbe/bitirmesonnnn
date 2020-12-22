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
    /// Interaction logic for TableNum.xaml
    /// </summary>
    public partial class TableNum : Window
    {
        KitchenStaff k = new KitchenStaff();
        public TableNum()
        {
            InitializeComponent();
            DisplayCurrentTable();

        }

        private void UniqueTable_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayCurrentTable();
          
        }

        protected void DisplayCurrentTable()
        {
            
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                con.Open();
                if (KitchenStaff.click1)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select tablenum,order_name,price,count1,totalprice From ORDR1", con);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    UniqueTable.ItemsSource = table.DefaultView;
                    CustomerNote.Text = Note.note1;

                }
                else { KitchenStaff.click1 = false; }
               

                if (KitchenStaff.click2)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select tablenum,order_name,price,count2,totalprice From ORDR2", con);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    UniqueTable.ItemsSource = table.DefaultView;
                    CustomerNote.Text = Note.note2;
                }
                else { KitchenStaff.click2 = false; }

                if (KitchenStaff.click3)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select tablenum,order_name,price,count3,totalprice From ORDR3", con);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    UniqueTable.ItemsSource = table.DefaultView;
                    CustomerNote.Text = Note.note3;
                }
                else { KitchenStaff.click3 = false; }
                con.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("List cannot be found");
            }

        }

        private void RemoveTheOrder_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection con1 = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True"); 
            SqlCommand cmd1 = new SqlCommand();

            while (UniqueTable.SelectedItems.Count >= 1)
            {
                DataRowView row = (DataRowView)UniqueTable.SelectedItem;

                if (Table.table_id == 1)
                {
                    string r = @"DELETE FROM ORDR1 WHERE order_id=@order_id ";

                    cmd1 = new SqlCommand(r, con1);

                    cmd1.Parameters.AddWithValue("@order_id", row.Row.ItemArray[0].ToString());
                }

                else if (Table.table_id == 2)
                {
                    string r = @"DELETE FROM ORDR2 WHERE order_id=@order_id ";

                    cmd1 = new SqlCommand(r, con1);

                    cmd1.Parameters.AddWithValue("@order_id", row.Row.ItemArray[0].ToString());
                }
                else if (Table.table_id == 3)
                {
                    string r = @"DELETE FROM ORDR3 WHERE order_id=@order_id ";

                    cmd1 = new SqlCommand(r, con1);

                    cmd1.Parameters.AddWithValue("@order_id", row.Row.ItemArray[0].ToString());
                }


                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
                row.Row.Delete();

            }
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            KitchenStaff k = new KitchenStaff();
            k.Show();
            this.Close();
        }

    
    }
}
