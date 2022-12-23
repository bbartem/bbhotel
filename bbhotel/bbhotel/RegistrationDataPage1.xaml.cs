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
    /// Форма 1
    /// </summary>
    public partial class RegistrationDataPage1 : Page
    {
        public RegistrationDataPage1()
        {
            InitializeComponent();
            foreach(var i in BBHotelEntities.getContext().apartments.ToList())
            {
                ComboBBHotel.Items.Add(i.name);
            }
            Manager.mainWindow.number2_circle.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number2_digit.Foreground = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            Manager.mainWindow.number2_line.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));

            Manager.mainWindow.number3_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            Manager.mainWindow.number3_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            Manager.mainWindow.number3_line.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));

            Manager.mainWindow.number4_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            Manager.mainWindow.number4_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));
        }
        /// <summary>
        /// Страница(форма) бранирование комнаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBBHotel.Text == "" || ComboBBHotelType.Text == "" || TextBlockTotal.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //BBHotelEntities.getContext().booking.Add(new booking {id_apartment = Manager.nameId, id_guest = 1, rent_type = ComboBBHotelType.Text, check_in = Manager.dateStart, check_out = Manager.dateEnd, date=null});
                //BBHotelEntities.getContext().SaveChanges();
                Manager.room = ComboBBHotel.Text;
                Manager.typeDesign = ComboBBHotelType.Text;
                Manager.price = TextBlockTotal.Text;
                MessageBox.Show("Информация сохранена!");
                Manager.mainFrame.Navigate(new RegistrationDataPage2());
            }
        }
        /// <summary>
        /// вывод название комнат в combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBBHotel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selected = ComboBBHotel.Text;

            foreach(var  i in BBHotelEntities.getContext().apartments.ToList())
            {
                if(selected == i.name)
                {
                    costField.Text = i.cost;
                    quantityField.Text = i.quantity;
                }

                Manager.nameId = Convert.ToInt32(i.id);
            }
        }
        /// <summary>
        /// Калькулятор Общая стоимость = (дата2 - дата1) * цена\сутки 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatePickerStart_CalendarClosed(object sender, RoutedEventArgs e)
        {
            DateTime dt1;
            DateTime dt2;
            if (DatePickerEnd.SelectedDate == null || DatePickerEnd.SelectedDate == null)
            {
                dt1 = DateTime.Now;
                dt2 = DateTime.Now;
            }
            else
            {
                dt1 = (DateTime)DatePickerStart.SelectedDate;
                dt2 = (DateTime)DatePickerEnd.SelectedDate;
                TimeSpan x = dt2 - dt1;
                TextBlockDifference.Text = x.TotalDays.ToString();
                TextBlockTotal.Text = Convert.ToString(Convert.ToInt32(costField.Text) * x.TotalDays);
                Manager.dateStart = dt1;
                Manager.dateEnd = dt2;
            }
        }
        /// <summary>
        /// Калькулятор Общая стоимость = (дата2 - дата1) * цена\сутки 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatePickerEnd_CalendarClosed(object sender, RoutedEventArgs e)
        {
            DateTime dt1;
            DateTime dt2;
            if (DatePickerEnd.SelectedDate == null || DatePickerEnd.SelectedDate == null)
            {
                dt1 = DateTime.Now;
                dt2 = DateTime.Now;
            }
            else
            {
                dt1 = (DateTime)DatePickerStart.SelectedDate;
                dt2 = (DateTime)DatePickerEnd.SelectedDate;
                TimeSpan x = dt2 - dt1;
                TextBlockDifference.Text = x.TotalDays.ToString();
                TextBlockTotal.Text = Convert.ToString(Convert.ToInt32(costField.Text) * x.TotalDays);
                Manager.dateStart = dt1;
                Manager.dateEnd = dt2;
            }
        }
    }
}
