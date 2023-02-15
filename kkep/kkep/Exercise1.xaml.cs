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

namespace kkep
{
    /// <summary>
    /// Логика взаимодействия для Exercise1.xaml
    /// </summary>
    public partial class Exercise1 : Page
    {
        public Exercise1()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Phone phone = (Phone)this.Resources["nexusPhone"];
            phone.Company = "LG";
        }
    }
    
}
