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
        public string Input { get; set; }
        public ICommand Calc { get; }
        public ICommand Reset { get; }

        void CalcCircle()
        {
            if (Input != null)
            {
                var r = double.Parse(Input);
                Circumference = 2 * 3.14 * r;
                Area = 3.14 * r * r;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Circumference)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Area)));
            }
        }
        void AllReset()
        {
            Circumference = 0;
            Area = 0;
            Input = "";

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Circumference)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Area)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Input)));
        }
        public MainViewModel()
        {
            Calc = new Command(CalcCircle);
            Reset = new Command(AllReset);
        }
    }
}
