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

namespace bitirme_new
{
    /// <summary>
    /// Interaction logic for Table.xaml
    /// </summary>
    public partial class Table : Window
    {
       public static int table_id;
       
        public Table()
        {
            InitializeComponent();
        }

        public string s;

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btnclose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();

        }

        public void BtnTable_Click(object sender, RoutedEventArgs e)
        {
           
            table_id= Convert.ToInt32(table1.Text);
            Main_Menu m = new Main_Menu();
            m.Show();
            this.Close();


        }
    }
}
