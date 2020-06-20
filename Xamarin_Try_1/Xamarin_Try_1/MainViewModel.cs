using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin_Try_1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public double Circumference { get; set; }
        public double Area { get; set; }
        public double Input 
        {
            set
            {
                    var r = value;
                    Circumference = 2 * 3.14 * r;
                    Area = 3.14 * r * r;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Circumference)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Area)));
                
            }
        }
    }
}
