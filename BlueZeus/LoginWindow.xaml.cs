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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new UserViewModel();


            var timer = new System.Threading.Timer((e) =>
            {
                MyMethod();
            }, null, 0, 60);


        }



        private void MyMethod()
        {
            //  textBox1.Text = "images processed";

            Task.Factory.StartNew(() =>
            {
                /// do all your logic here

                //Update Text on the UI thread 
            //    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Input,
            //   new Action(() => { textBox1.Text = DateTime.Now.ToString("h:mm:ss tt"); }));

                //continue with the rest of the logic that take a long time
            });
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "images processed";
           
            var dashboard = new ProjectDashboardWindow(); // Create new window
            dashboard.Show(); // Show the new window
            Close();
        }


        private void btn_create_Click(object sender, RoutedEventArgs e)
        {
       var dashboard = new RegWindow(); // Create new window
        dashboard.Show(); // Show the new window
            Close();
        }


        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
