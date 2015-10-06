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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BlueZeus.ViewModels;
using BlueZeus;

using System.Windows.Threading;

namespace BlueZeus
{
    /// <summary>
    /// Interaction logic for RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
            DataContext = new UserViewModel();
             
        }

         


        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "images processed";
           
            var dashboard = new ProjectDashboardWindow(); // Create new window
            dashboard.Show(); // Show the new window
            Close();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
