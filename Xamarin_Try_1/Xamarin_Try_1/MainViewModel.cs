using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin_Try_1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double circumference;
        public double Circumference 
        { 
            get { return circumference; }
            set
            {
                if (circumference != value)
                {
                    circumference = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Circumference)));
                }
            }
        }

        private double area;
        public double Area 
        {
            get { return area; }
            set
            {
                if (area != value)
                {
                    area = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Area)));
                }
            }
        }

        private double input;
        public double Input 
        {
            get { return input; }
            set
            {
                if (input != value)
                {
                    input = value;
                    Circumference = 2 * 3.14 * input;
                    Area = 3.14 * input * input;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Input)));
                }
            }
        }
    }
}
