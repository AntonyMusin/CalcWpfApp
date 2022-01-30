using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalcWpfApp.ViewModels
{
    class CalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private double display;
        public double Display
        {
            get => display;
            set
            {
                display = value;
                OnPropertyChanged();
            }
        }
        public ICommand ButtonPressCommand { get; }
        private void OnButtonPressCommandExecute(object p)
        {
            switch ()// Хочу передавать значение кнопок из разметки XAML с помощью конструкции swtich-case
                //До конца не понимаю как это реализовать
                
            {
                default:
                    break;
            }
        }
        private bool CanButtonPressCommandExecuted(object p)
        {
            return true;
        }
        public CalculatorViewModel()
        {
            ButtonPressCommand = new RelayCommand(OnButtonPressCommandExecute, CanButtonPressCommandExecuted);
        }

    }
}
