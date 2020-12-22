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
    /// Interaction logic for KitchenStaff.xaml
    /// </summary>
    public partial class KitchenStaff : Window
    {
        public static bool click1 = false;
        public static bool click2 = false;
        public static bool click3 = false;
        
        public KitchenStaff()
        {
            InitializeComponent();
           
        }

        //public void KitchenGrid_Loaded(object sender, RoutedEventArgs e)
        //{
        //    DisplayGrid();
        //}
        //public void DisplayGrid()
        //{
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
        //        SqlCommand cmd = new SqlCommand();
        //        con.Open();

        //        SqlDataAdapter da = new SqlDataAdapter("Select *From ORDR", con);
        //        DataTable table = new DataTable();
        //        da.Fill(table);

        //        KitchenGrid.ItemsSource = table.DefaultView;

        //        con.Close();
        //    }

        //    catch (Exception)
        //    {
        //        MessageBox.Show("List cannot be found");
        //    }

        //}
     

       
        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            Role r = new Role();
            r.Show();
            this.Close();
        }

        public void Table1_Click(object sender, RoutedEventArgs e)
        {
            click1 = true;

            TableNum t = new TableNum();
            t.Show();
            this.Close();
        }

        private void Table2_Click(object sender, RoutedEventArgs e)
        {
            click2 = true;
            TableNum t = new TableNum();
            t.Show();
            this.Close();
        }

        private void Table3_Click(object sender, RoutedEventArgs e)
        {
            click3 = true;
            TableNum t = new TableNum();
            t.Show();
            this.Close();
        }

        private void Table4_Click(object sender, RoutedEventArgs e)
        {

            TableNum t = new TableNum();
            t.Show();
            this.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
