using System;
using System.Windows.Input;

namespace OfflineQuiz.Commands
{
    public class DelegateCommand: ICommand, IDisposable
    {
        private Predicate<object> _canExecute;
        private Action<object> _execute;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
        
        public DelegateCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        public DelegateCommand(Action<object> execute,
            Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public void Dispose()
        {
            _execute = null;
            _canExecute = null;
        }
    }
}
