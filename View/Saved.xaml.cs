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

namespace NewsReadApp.View
{
    /// <summary>
    /// Interaction logic for Saved.xaml
    /// </summary>
    public partial class Saved : Window
    {
        public Saved()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            Menu win1 = new Menu();
            win1.Show();
        }

        private void btnSavedNews_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSetting_Click(object sender, RoutedEventArgs e)
        {
            Setting win3 = new Setting();
            win3.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            LoginForm win5 = new LoginForm();
            this.Close();
            win5.Show();
        }

        private void btnBookmark_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
