using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace kkep
{
    /// <summary>
    /// Логика взаимодействия для Exercise3.xaml
    /// </summary>
    public partial class Exercise3 : Page
    {
        private Dictionary<string, List<string>> schedule = new Dictionary<string, List<string>>()
        {
            {"Понедельник", new List<string>{"Нет", "Разработка ВЕБ приложений", "Разработка информационных систем", "Компьютерные сети"}},
            {"Вторник", new List<string>{ "Ин.язык в проф.деятельности", "Внедрение информационных систем", "Разработка ВЕБ приложений", "Нет"}},
            {"Среда", new List<string>{ "Разработка ВЕБ приложений", "Разработка информационных систем", "Тестирование информационных систем", "Нет"}},
            {"Четверг", new List<string>{ "Интеллектуальные системы и технологии", "Управление и автоматизация баз данных", "Разработка ВЕБ приложений", "Нет"}},
            {"Пятница", new List<string>{ "Разработка ВЕБ приложений", "Внедрение информационных систем", "Управление и автоматизация баз данных", "Нет"}},
            {"Суббота", new List<string>{"ИТПСИС", "Управление и автоматизация баз данных", "Интеллектуальные системы и технологии", "Нет"}}
        };
        public Exercise3()
        {
            InitializeComponent();
            PopulateDayComboBox();
        }
        private void PopulateDayComboBox()
        {
            foreach (string day in schedule.Keys)
            {
                DayComboBox.Items.Add(day);
            }
            DayComboBox.SelectedIndex = 0;
        }

        private void DayComboBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string selectedDay = DayComboBox.SelectedItem.ToString();
            ScheduleListBox.ItemsSource = schedule[selectedDay];
        }
    }
}
