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

namespace kkep
{
    /// <summary>
    /// Логика взаимодействия для ExampleApp.xaml
    /// </summary>
    public partial class ExampleApp : Window
    {
        public ExampleApp()
        {
            InitializeComponent();
            mainFrame.Navigate(new AuthorizationPage());
            Manager.mainFrame = mainFrame;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.GoBack();
        }

        private void mainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (Manager.mainFrame.CanGoBack)
            {
                this.ResizeMode = ResizeMode.CanResize;
                btnBack.Visibility = Visibility.Visible;
            }
            else
            {
                this.ResizeMode=ResizeMode.NoResize;
                btnBack.Visibility=Visibility.Collapsed;
            }
        }
    }
}
