using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gestion_Cabinet_medicale
{
    class Command : ICommand
    {
        public Action action { get; set; }
        public Action<object> action_parameter { get; set; }
        public Command(Action<object> action) => action_parameter = action;
        public Command(Action action) => this.action = action;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter != null) action_parameter(parameter);
            else action();
        }
    }
}
