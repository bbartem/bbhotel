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
    /// Авторизация
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new RegistrationPage());
        }
        /// <summary>
        /// авторизация пользователя, проверка из БД
        /// </summary>
        /// <param name="login">логин из Button_Click</param>
        /// <param name="password">пароль из Button_Click</param>
        /// <returns></returns>
        private bool authorize(string login, string password)
        {
            int errors = 0;
            try
            {
                foreach (var guest in BBHotelEntities.getContext().Guest.ToList())
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
        /// <summary>
        /// Кнопка входа в систему с проверкой пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    Manager.mainFrame.Navigate(new RegistrationDataPage1());
            }
        }
    }
}
