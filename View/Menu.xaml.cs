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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
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
            
        }

        private void btnSavedNews_Click(object sender, RoutedEventArgs e)
        {
            Saved win2 = new Saved(); 
            this.Close();
            win2.Show();
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

        private void btnViewNews_Click(object sender, RoutedEventArgs e)
        {
            NewsView win4 = new NewsView();
            this.Close();
            win4.Show();
        }

        private void btnMore_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
