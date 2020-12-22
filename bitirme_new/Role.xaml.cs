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
    /// Interaction logic for Role.xaml
    /// </summary>
    public partial class Role : Window
    {
        public Role()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void BtnStaff_Click(object sender, RoutedEventArgs e)
        {
            StaffSelection s = new StaffSelection();
            s.Show();
            this.Close();
        }

        private void BtnKitStaff_Click(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            KitchenStaff k = new KitchenStaff();
            k.Show();
            this.Close();
            //this.Close();
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
