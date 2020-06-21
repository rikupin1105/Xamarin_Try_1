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
            get => circumference;
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
            get => area;
            set
            {
                if (area != value)
                {
                    area = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Area)));
                }
            }
        }

        private string input;
        public string Input
        {
            get => input;
            set
            {
                if (input != value)
                {
                    if (value == "")
                    {
                        Area = 0;
                        Circumference = 0;
                    }
                    else
                    {
                        input = value;
                        var radius = double.Parse(input);
                        Circumference = 2 * 3.14 * radius;
                        Area = 3.14 * radius * radius;
                    }
                }
            }
        }
    }
}
