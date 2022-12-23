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
    /// Личный кабинета Админа
    /// </summary>
    public partial class PersonalAccountAdminPage : Page
    {
        public PersonalAccountAdminPage()
        {
            InitializeComponent();
            Manager.mainWindow.number2_circle.Stroke = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            Manager.mainWindow.number2_digit.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            Manager.mainWindow.number2_line.Stroke = new SolidColorBrush(Color.FromRgb(255, 128, 0));

            Manager.mainWindow.number2_circle.Stroke = new SolidColorBrush(Color.FromRgb(255, 255, 0));
            Manager.mainWindow.number2_digit.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 0));
            Manager.mainWindow.number2_line.Stroke = new SolidColorBrush(Color.FromRgb(128, 255, 0));

            Manager.mainWindow.number3_circle.Stroke = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            Manager.mainWindow.number3_digit.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            Manager.mainWindow.number3_line.Stroke = new SolidColorBrush(Color.FromRgb(0, 255, 255));

            Manager.mainWindow.number4_circle.Stroke = new SolidColorBrush(Color.FromRgb(0, 128, 255));
            Manager.mainWindow.number4_digit.Foreground = new SolidColorBrush(Color.FromRgb(0, 128, 255));
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new AuthorizationPage());
        }

        /// <summary>
        /// Вывод данных из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                BBHotelEntities.getContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                RoomsHotel.ItemsSource = BBHotelEntities.getContext().apartments.ToList();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.mainFrame.Navigate(new EditorPage());
        }
        /// <summary>
        /// Удаление элементов из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var hotelIsFOrRemoving = RoomsHotel.SelectedItems.Cast<apartments>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelIsFOrRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    BBHotelEntities.getContext().apartments.RemoveRange(hotelIsFOrRemoving);
                    BBHotelEntities.getContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    RoomsHotel.ItemsSource = BBHotelEntities.getContext().apartments.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
