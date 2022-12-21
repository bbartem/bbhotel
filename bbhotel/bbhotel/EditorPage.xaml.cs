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
    /// Логика взаимодействия для EditorPage.xaml
    /// </summary>
    public partial class EditorPage : Page
    {
        private apartment _currentHotel = new apartment();
        public EditorPage(apartment selectedBBHotel)
        {
            InitializeComponent();
            if (selectedBBHotel != null)
                _currentHotel = selectedBBHotel;
            DataContext = _currentHotel;
            
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentHotel.name))
                errors.AppendLine("Укажите название комнаты");
            if (_currentHotel.quantity == "")
                errors.AppendLine("Укажите количество людей");
            if (_currentHotel.cost == "")
                errors.AppendLine("Укажите стоимость");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentHotel.id_apartmen == 0)
            {
                BBHotelEntities1.getContext().apartment.Add(_currentHotel);
            }

            try
            {
                BBHotelEntities1.getContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");

                Manager.mainFrame.Navigate(new PersonalAccountAdminPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        
    }
}
