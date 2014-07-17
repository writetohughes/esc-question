using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1
{
    class MainWindowViewModel : IDataErrorInfo
    {
        public MainWindowViewModel()
        {}
        public string ValidateInputText
        { get; set; }

        public ICommand ValidateInputCommand
        {
            get { return new WpfApplication1.RelayCommand(); }
            set { }
        }

        private int age = 20;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get 
            {
                if ("ValidateInputText" == columnName)
                {
                    if (String.IsNullOrEmpty(ValidateInputText))
                    {
                        return "Please enter a name";
                    }
                }
                else if ("Age" == columnName)
                {
                    if (age < 0)
                    {
                        return "Age should be greater than zero";
                    }
                }
                return "";
            }
        }
    }

    class RelayCommand : ICommand
    {

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
        }


    }
}
