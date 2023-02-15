
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new Exercise1());
            Kkep.mainFrame = mainFrame;
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void Navigation_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void btnNumber1_Click(object sender, RoutedEventArgs e)
        {
            Kkep.mainFrame.Navigate(new Exercise1());

            number1_circle.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            number1_digit.Foreground = new SolidColorBrush(Color.FromRgb(252, 159, 29));

            number2_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            number2_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));

            number3_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            number3_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));

        }
        private void btnNumber2_Click(object sender, RoutedEventArgs e)
        {
            Kkep.mainFrame.Navigate(new Exercise2());

            number1_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            number1_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));

            number2_circle.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            number2_digit.Foreground = new SolidColorBrush(Color.FromRgb(252, 159, 29));

            number3_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            number3_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));
        }
        private void btnNumber3_Click(object sender, RoutedEventArgs e)
        {
            Kkep.mainFrame.Navigate(new Exercise3());

            number1_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            number1_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));

            number2_circle.Stroke = new SolidColorBrush(Color.FromRgb(201, 115, 0));
            number2_digit.Foreground = new SolidColorBrush(Color.FromRgb(201, 115, 0));

            number3_circle.Stroke = new SolidColorBrush(Color.FromRgb(252, 159, 29));
            number3_digit.Foreground = new SolidColorBrush(Color.FromRgb(252, 159, 29));
        }
    }
}
