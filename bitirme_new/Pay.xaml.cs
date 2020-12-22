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
    /// Interaction logic for Pay.xaml
    /// </summary>
    public partial class Pay : Window
    {
        
        public Pay()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            feedback f = new feedback();
            f.Show();
            this.Close();
        }
        public static string index;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            index = FIRSTLAST.Text;
            Invoice inv = new Invoice();
            feedbackscreen2 f = new feedbackscreen2();
            f.Show();
            this.Close();

        }

    }
}
