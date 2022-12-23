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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new AuthorizationPage());
            Manager.mainFrame = mainFrame;
            Manager.mainWindow = this;
        }

        /// <summary>
        /// кнопка навигации для сварачивание окна
        /// </summary>
        /// <param name="sender">вызов сворачивание окна</param>
        /// <param name="e">Событие</param>
        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        /// <summary>
        /// кнопка навигации для закрытие окна
        /// </summary>
        /// <param name="sender">вызов закрытие окна</param>
        /// <param name="e">Событие</param>
        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// кнопка навигации для закрытие окна
        /// </summary>
        /// <param name="sender">вызов закрытие окна</param>
        /// <param name="e">Событие</param>
        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        /// <summary>
        /// навигация для перемещение окна
        /// </summary>
        /// <param name="sender">вызов перемещение окна</param>
        /// <param name="e">Событие</param>
        private void Navigation_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
