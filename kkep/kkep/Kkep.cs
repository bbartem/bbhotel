using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace kkep
{
    class Kkep
    {
        public static Frame mainFrame { get; set; }
        public static MainWindow mainWindow { get; set; }
    }
    public class Phone : INotifyPropertyChanged
    {
        private string title;
        private string company;
        private string price;

        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged("Title"); }
        }
        public string Company
        {
            get { return company; }
            set { company = value; OnPropertyChanged("Company"); }
        }
        public string Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged("Password"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }



    }
}
