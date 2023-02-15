using System.Collections.ObjectModel;

namespace kkep
{
    public class Student 

    {
        private string _name;
        private ObservableCollection<int> _grades = new ObservableCollection<int>();
        private double _average;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
              
            }
        }

        public ObservableCollection<int> Grades
        {
            get { return _grades; }
            set
            {
                _grades = value;
                
            }
        }

        public double Average
        {
            get { return _average; }
            set
            {
                _average = value;
                
            }
        }

       
    }
}
