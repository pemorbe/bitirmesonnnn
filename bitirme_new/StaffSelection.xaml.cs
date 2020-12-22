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
    /// Interaction logic for StaffSelection.xaml
    /// </summary>
    public partial class StaffSelection : Window
    {
        public StaffSelection()
        {
            InitializeComponent();
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            Role r = new Role();
            r.Show();
            this.Close();
        }

        private void BtnTables_Click(object sender, RoutedEventArgs e)
        {
            KitchenStaff k = new KitchenStaff();
            k.Show();
            this.Close();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update_Menu u = new Update_Menu();
            u.Show();
            this.Close();
        }
    }
}
