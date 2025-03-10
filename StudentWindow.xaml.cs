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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace TPSK
{
    /// <summary>
    /// Логика взаимодействия для StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public StudentWindow()
        {
            InitializeComponent();
            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.Ent.Group.ToList();

            StudentCmb.SelectedValuePath = "ID";
            StudentCmb.DisplayMemberPath = "Name";
            StudentCmb.ItemsSource = App.Ent.Student.ToList();

            TestCmb.SelectedValuePath = "ID";
            TestCmb.DisplayMemberPath = "Name";
            TestCmb.ItemsSource = App.Ent.Test.ToList();
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectGroup = Convert.ToInt32(GroupCmb.SelectedValue);
            StudentCmb.ItemsSource = App.Ent.Student.Where(x => x.IdGroup == selectGroup).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TestCmb.Text=="Общие основы функционирования субъектов хозяйствования")
            {
                Test1Window test1Window = new Test1Window();
                test1Window.Show();
                this.Close();
            }
        }
    }
}
