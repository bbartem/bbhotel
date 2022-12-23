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
    /// Форма 2
    /// </summary>
    public partial class RegistrationDataPage2 : Page
    {
        public RegistrationDataPage2()
        {
            InitializeComponent();
            Manager.mainWindow.number2_circle.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number2_digit.Foreground = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number2_line.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));

            Manager.mainWindow.number3_circle.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number3_digit.Foreground = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number3_line.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));

            Manager.mainWindow.number4_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            Manager.mainWindow.number4_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));
        }
        /// <summary>
        /// Страница(форма) выбор оплаты, заполнение паспортных данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Manager.payment = ComboPayment.Text;
            if (ComboPayment.Text == "" || PassportSeries.Text == "" || PassportIssued.Text == "" || PassportNumber.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Manager.payment = ComboPayment.Text;
                Manager.mainFrame.Navigate(new ChequePage());
            }
        }
    }
}
