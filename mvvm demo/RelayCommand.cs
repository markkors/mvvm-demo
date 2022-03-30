using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mvvm_demo
{
    public class RelayCommand : ICommand

    {

        private Action<object> execute;
        bool canExecute;
       
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }

        }

        public RelayCommand(Action<object> execute, bool canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;

        }

        public bool CanExecute(object parameter)
        {
            //return this.CanExecute(parameter);
            return true;
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
