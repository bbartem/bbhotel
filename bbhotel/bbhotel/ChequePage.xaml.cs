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
    /// Страница Чека
    /// </summary>
    public partial class ChequePage : Page
    {
        public ChequePage()
        {
            InitializeComponent();

            Manager.mainWindow.number2_circle.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number2_digit.Foreground = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number2_line.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));

            Manager.mainWindow.number3_circle.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number3_digit.Foreground = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number3_line.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));

            Manager.mainWindow.number4_circle.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number4_digit.Foreground = new SolidColorBrush(Color.FromRgb(252, 159, 29));

            roomName.Text = Manager.room;
            typeDesign.Text = Manager.typeDesign;
            DateStart.Text = Manager.dateStart.ToString();
            DateEnd.Text = Manager.dateEnd.ToString();
            price.Text = Manager.price;
            payment.Text = Manager.payment;
        }
        
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AuthorizationPage());
        }
    }
}
