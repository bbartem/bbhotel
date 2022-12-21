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
    /// Логика взаимодействия для RegistrationDataPage1.xaml
    /// </summary>
    public partial class RegistrationDataPage1 : Page
    {
        public RegistrationDataPage1()
        {
            InitializeComponent();
            ComboBBHotel.ItemsSource = BBHotelEntities1.getContext().apartment.ToList();
            Manager.mainWindow.number2_circle.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number2_digit.Foreground = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number2_line.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));

            Manager.mainWindow.number3_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            Manager.mainWindow.number3_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            Manager.mainWindow.number3_line.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));

            Manager.mainWindow.number4_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            Manager.mainWindow.number4_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
