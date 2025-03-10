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

namespace TPSK
{
    /// <summary>
    /// Логика взаимодействия для Test1Window.xaml
    /// </summary>
    public partial class Test1Window : Window
    {
        int b = 0;
        int c = 0;
        public Test1Window()
        {
            InitializeComponent();
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text=="5")
            {
                MessageBox.Show("Правильно");
                b=b+1;
            }
            else MessageBox.Show("Неправильно");

                p1.Visibility = Visibility.Collapsed;
                products.SelectedItem = v2;
            
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            if (RB2.IsChecked==true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            p2.Visibility = Visibility.Collapsed;
            products.SelectedItem = v3;
        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {
            if (ChB1.IsChecked == false && ChB2.IsChecked == false && ChB3.IsChecked == false && ChB4.IsChecked == false && ChB5.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            p3.Visibility = Visibility.Collapsed;
           
        }
    }
}
