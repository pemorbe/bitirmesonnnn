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
    /// Interaction logic for Update_Menu.xaml
    /// </summary>
    public partial class Update_Menu : Window
    {
        public Update_Menu()
        {
            InitializeComponent();
            Display_UpdateMenuGrid();
        }
        private void UpdateMenuGrid_Loaded(object sender, RoutedEventArgs e)
        {
            Display_UpdateMenuGrid();
            //UpdateMenuGrid.Columns[0].Header = "Product Number";
            //UpdateMenuGrid.Columns[1].Header = "Product";
            //UpdateMenuGrid.Columns[2].Header = "Product Description";
            //UpdateMenuGrid.Columns[3].Header = "Price";

        }
        public void Display_UpdateMenuGrid()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select *From PRODUCT", con);
                DataTable table = new DataTable();
                da.Fill(table);

                UpdateMenuGrid.ItemsSource = table.DefaultView;

                con.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("List cannot be found");
            }

        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dv = (DataRowView)UpdateMenuGrid.SelectedItem;
            if (dv != null)
            {
                productNameText.Text = dv.Row.ItemArray[1].ToString();
                productDescText.Text = dv.Row.ItemArray[2].ToString();
                productPriceText.Text = dv.Row.ItemArray[4].ToString();
            }
        }
        bool st;
        void recurring()
        {

            SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True"); ;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from PRODUCT where product_name=@product_name", con);
            cmd.Parameters.AddWithValue("@product_name", productNameText.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                st = false;
            }
            else
            {
                st = true;
            }
            con.Close();

        }

        private void InsertProduct_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True"); ;
            SqlCommand cmd = new SqlCommand();

            con.Open();
            string r = @"Insert Into PRODUCT(product_name,product_description,price,cat_name,sub_name) values (@product_name,@product_description,@price,@cat_name,@sub_name) ";


            cmd = new SqlCommand(r, con);
            recurring();

            if (st == true && productNameText.Text != "")
            {

                cmd.Parameters.AddWithValue("@product_name", productNameText.Text);
                cmd.Parameters.AddWithValue("@product_description", productDescText.Text);
                //cmd.Parameters.AddWithValue("@product_image", Image);
                //cmd.Parameters.AddWithValue("@product_number", ProductNumber.Text);
                cmd.Parameters.AddWithValue("@price", productPriceText.Text);

                cmd.Parameters.AddWithValue("@cat_name", CatCombo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@sub_name", SubCombo.SelectedItem.ToString());



                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product Inserted.");
            }
            else if (st == false)
            {
                MessageBox.Show("The Product Already Exist", "Warning");

            }
            else if (productNameText.Text == "")
            {

                MessageBox.Show("Product Name Can Not Be Empty!", "ERROR");
            }
            Display_UpdateMenuGrid();

        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True"); ;
            SqlCommand cmd = new SqlCommand();

            while (UpdateMenuGrid.SelectedItems.Count >= 1)
            {
                DataRowView row = (DataRowView)UpdateMenuGrid.SelectedItem;

                string r = @"DELETE FROM PRODUCT WHERE product_name=@product_name ";

                cmd = new SqlCommand(r, con);


                cmd.Parameters.AddWithValue("@product_name", row.Row.ItemArray[1].ToString());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                row.Row.Delete();

            }
        }

        private void UpdateProduct_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True"); ;
            SqlCommand cmd = new SqlCommand();

            string q = "Update PRODUCT Set product_name=@product_name,product_description=@product_description,price=@price,cat_name=@cat_name,sub_name=@sub_name Where product_name=@product_name ";
            cmd = new SqlCommand(q, con);


            cmd.Parameters.AddWithValue("@product_name", productNameText.Text);
            cmd.Parameters.AddWithValue("@product_description", productDescText.Text);
            //cmd.Parameters.AddWithValue("@product_image", Image);           
            cmd.Parameters.AddWithValue("@price", productPriceText.Text);
            cmd.Parameters.AddWithValue("@cat_name", CatCombo.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@sub_name", SubCombo.SelectedItem.ToString());

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Display_UpdateMenuGrid();
        }
        public void FillCatcombobox()
        {
            SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True"); ;
            SqlCommand cmd = new SqlCommand();
            string query = "SELECT category_name FROM CATEGORY";      //query the database
            cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())   //loop reader and fill the combobox
            {
                CatCombo.Items.Add(reader["category_name"].ToString());
            }


            con.Close();

        }

        private void CatCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True"); ;
            SqlCommand cmd = new SqlCommand();


            if (CatCombo.SelectedIndex == 0)
            {
                con.Open();
                string query1 = "SELECT subcategory_name FROM SUB_CATE where cat_id=10";      //query the database
                cmd = new SqlCommand(query1, con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())   //loop reader and fill the combobox
                {
                    SubCombo.Items.Add(reader["subcategory_name"].ToString());
                }

                con.Close();

            }
            else if (CatCombo.SelectedIndex == 1)
            {
                SubCombo.Items.Clear();
                con.Open();

                string query2 = "SELECT subcategory_name FROM SUB_CATE where cat_id=11";      //query the database
                cmd = new SqlCommand(query2, con);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())   //loop reader and fill the combobox
                {
                    SubCombo.Items.Add(reader["subcategory_name"].ToString());
                }
                con.Close();
            }
            else if (CatCombo.SelectedIndex == 2)
            {
                SubCombo.Items.Clear();
                con.Open();

                string query2 = "SELECT subcategory_name FROM SUB_CATE where cat_id=12";      //query the database
                cmd = new SqlCommand(query2, con);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())   //loop reader and fill the combobox
                {
                    SubCombo.Items.Add(reader["subcategory_name"].ToString());
                }
                con.Close();
            }
            else if (CatCombo.SelectedIndex == 3)
            {
                SubCombo.Items.Clear();
                con.Open();
                string query = "SELECT subcategory_name FROM SUB_CATE where cat_id=13";      //query the database
                cmd = new SqlCommand(query, con);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())   //loop reader and fill the combobox
                {
                    SubCombo.Items.Add(reader["subcategory_name"].ToString());
                }
                con.Close();
            }
        }


        public void FillSubcombobox()
        {





        }






        private void CatCombo_Initialized(object sender, EventArgs e)
        {
            FillCatcombobox();
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            Role r = new Role();
            r.Show();
            this.Close();
        }

     

        private void ListView_Click(object sender, RoutedEventArgs e)
        {
            Display_UpdateMenuGrid();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
            DataTable tbl = new DataTable();
            string st = "Select * from PRODUCT where product_name like '%" + searchText.Text + "%'";
            SqlDataAdapter search = new SqlDataAdapter(st, con);
            search.Fill(tbl);

            con.Close();
            UpdateMenuGrid.ItemsSource = tbl.DefaultView;

        }
    }
}
