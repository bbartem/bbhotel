using bbhotel.Model;
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

namespace bbhotel
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
            //Manager.mainWindow.number2_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            //Manager.mainWindow.number2_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            //Manager.mainWindow.number2_line.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));

            //Manager.mainWindow.number3_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            //Manager.mainWindow.number3_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            //Manager.mainWindow.number3_line.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));

            //Manager.mainWindow.number4_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            //Manager.mainWindow.number4_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));
        }

        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new RegistrationPage());
        }
        private bool authorize(string login, string password)
        {
            int errors = 0;
            try
            {
                foreach (var guest in BBHotelEntities1.getContext().Guest.ToList())
                {
                    if (login == guest.login && password == guest.password)
                    {
                        Manager.fio = guest.fio;
                        errors = 0;
                        break;
                    }
                    else
                        errors++;
                }
                if (errors == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных, " + ex.StackTrace, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(authorize(txtLogin.Text, txtPass.Password))
            {
                MessageBox.Show("Вы успешно авторизованы", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                if(txtLogin.Text == "admin")
                {
                    Manager.mainFrame.Navigate(new PersonalAccountAdminPage());
                }
                else
                    Manager.mainFrame.Navigate(new PersonalAccountPage());
            }
        }
    }
}
