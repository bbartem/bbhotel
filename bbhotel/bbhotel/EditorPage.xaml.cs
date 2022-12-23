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
    /// Создание новых элементов
    /// </summary>
    public partial class EditorPage : Page
    {
        public EditorPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Сохранение новых элементов в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (nameField.Text == "" || quantityField.Text == "" || costField.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                BBHotelEntities.getContext().apartments.Add(new apartments { name = nameField.Text, cost = costField.Text, quantity = quantityField.Text });
                BBHotelEntities.getContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.mainFrame.Navigate(new PersonalAccountAdminPage());
            }
        }
    }
}