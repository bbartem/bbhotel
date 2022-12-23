using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Регистрация
    /// </summary>
    public partial class RegistrationPage : Page
    {
        /// <summary>
        /// проверка пароля при регистрации
        /// </summary>
        /// <returns></returns>
        public bool PasswordVerification()
        {
            var password = txtPass.Password;
            var regex = new Regex(@"([a - z])");
            var regex2 = new Regex(@"([a-zA-Z])");
            var regex1 = new Regex(@"([0 - 9])");
            var regex3 = new Regex(@"([!,@,#,$,%,^,&,*,?,_,~])");
            if (password.Length >= 8 && regex1.IsMatch(password) && regex2.IsMatch(password) && regex3.IsMatch(password))
            {
                level.Text = "4 уровень";
                return false;
            }
            if (password.Length >= 8 && regex1.IsMatch(password) && regex2.IsMatch(password))
            {
                level.Text = "3 уровень";
                return false;
            }
            if (password.Length >= 8 && regex2.IsMatch(password))
            {
                level.Text = "2 уровень";
                return false;
            }
            if (password.Length < 8 && regex.IsMatch(password))
            {
                level.Text = "1 уровень";
                return false;
            }
            return false;
        }


        public RegistrationPage()
        {
            InitializeComponent();
            Manager.mainWindow.number2_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            Manager.mainWindow.number2_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            Manager.mainWindow.number2_line.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));

            Manager.mainWindow.number3_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            Manager.mainWindow.number3_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            Manager.mainWindow.number3_line.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));

            Manager.mainWindow.number4_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            Manager.mainWindow.number4_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));
        }

        private void btnAuthorization_Click(object sender, RoutedEventArgs e)
        {
                Manager.mainFrame.Navigate(new AuthorizationPage());
        }

        private void btnEnterReg_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordVerification() == true)
            {
                Manager.mainFrame.Navigate(new RegistrationDataPage1());
            }
        }
    }
}
