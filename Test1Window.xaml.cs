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
using TPSK.Class;
using TPSK.Model;

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
            products.SelectedItem = v4;

        }

        private void p4_Click(object sender, RoutedEventArgs e)
        {
            if (RB24.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            p4.Visibility = Visibility.Collapsed;
            products.SelectedItem = v5;
        }

        private void p00_Click(object sender, RoutedEventArgs e)
        {
            Journal journal = new Journal()
            {
                DateTest = DateTime.Now,
                Mark = c,
                IdStudent = ClassVariable.classman,
                IdTest = 1
            };
            App.Ent.Journal.Add(journal);
            App.Ent.SaveChanges();
            MessageBox.Show("Успешно");
        }

        private void p0_Click(object sender, RoutedEventArgs e)
        {
            TextBlock100.Text =Convert.ToString(b);

            if (b >= 20) c = 5;
            if (b > 11 && b < 20) c = 4;
            if (b > 5 && b < 12) c = 3;
            if (b < 6 && b > 0) c = 2;
            if (b ==0) c = 1;

            TextBlock101.Text = Convert.ToString(c);
        }

        private void p5_Click(object sender, RoutedEventArgs e)
        {
            if (RB25.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            p5.Visibility = Visibility.Collapsed;
            products.SelectedItem = v6;
        }

        private void p6_Click(object sender, RoutedEventArgs e)
        {
            if (RB26.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            p6.Visibility = Visibility.Collapsed;
            products.SelectedItem = v7;
        }

        private void p7_Click(object sender, RoutedEventArgs e)
        {
            if (RB27.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            p7.Visibility = Visibility.Collapsed;
            products.SelectedItem = v8;
        }

        private void p8_Click(object sender, RoutedEventArgs e)
        {
            if (RB28.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");

            p8.Visibility = Visibility.Collapsed;
            products.SelectedItem = v9;
        }
    }
}
