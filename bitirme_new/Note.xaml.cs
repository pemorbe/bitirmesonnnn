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
    /// Interaction logic for Note.xaml
    /// </summary>
    public partial class Note : Window
    {
        public static string note1;
        public static string note2;
        public static string note3;
        Basket basketNote = new Basket();
        TableNum t = new TableNum();
        public Note()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            if (Table.table_id == 1)
            {
                note1 = notes.Text;
               
            }
            if (Table.table_id == 2)
            {
                note2 = notes.Text;
               
            }
            if (Table.table_id == 3)
            {
                note3 = notes.Text;
              
            }

            this.Close();
           
            //if (basketNote.returnTableNum() == 1)
            //{
            //    note1 = notes.Text;
            //    t.CustomerNote.Text = note1;
            //}

        }

      
    }
}