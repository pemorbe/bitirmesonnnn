﻿using System;
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
    /// Interaction logic for Main_Menu.xaml
    /// </summary>
    public partial class Main_Menu : Window
    {
        
 
       
        public Main_Menu()
        {
            InitializeComponent();
          
        }
       
       
    private void BtnMainCourses_Click(object sender, RoutedEventArgs e)
        {
            MainCourses mainCourses = new MainCourses();
            mainCourses.Show();
            this.Close();
        }

        private void BtnInterMeals_Click(object sender, RoutedEventArgs e)
        {
            i_Meal i_Meal = new i_Meal();
            i_Meal.Show();
            this.Close();
        }

        private void BtnDesserts_Click(object sender, RoutedEventArgs e)
        {
            MainDessert mainDessert = new MainDessert();
            mainDessert.Show();
            this.Close();
        }

        private void BtnDrinks_Click(object sender, RoutedEventArgs e)
        {
            MainDrinks mainDrinks = new MainDrinks();
            mainDrinks.Show();
            this.Close();
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
