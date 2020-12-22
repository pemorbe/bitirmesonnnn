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
    /// Interaction logic for MainCourses.xaml
    /// </summary>
    public partial class MainCourses : Window
    {
        public MainCourses()
        {
            InitializeComponent();
        }

        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Close();
        }

        private void BtnPizza_Click(object sender, RoutedEventArgs e)
        {
            Pizzas pizzas = new Pizzas();
            pizzas.Show();
            this.Close();

        }

        private void BtnBurgers_Click(object sender, RoutedEventArgs e)
        {
            Burgers burgers = new Burgers();
            burgers.Show();
            this.Close();
        }

        private void BtnPastas_Click(object sender, RoutedEventArgs e)
        {
            Pastas p = new Pastas();
            p.Show();
            this.Close();
        }

        private void BtnToast_Click(object sender, RoutedEventArgs e)
        {
            Toast t = new Toast();
            t.Show();
            this.Close();
        }

        private void BtnMeats_Click(object sender, RoutedEventArgs e)
        {
            GrilledMeats g = new GrilledMeats();
            g.Show();
            this.Close();
        }

        private void BtnSeafood_Click(object sender, RoutedEventArgs e)
        {
            SeaFood s = new SeaFood();
            s.Show();
            this.Close();
        }
    }
}
