using System;
using System.Windows.Input;

namespace GraphSharp.Sample.ViewModel
{
    public class RelayCommand : ICommand
    {
        private readonly Predicate<object> _canExecute;

        private readonly Action<object> _execute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null, string title = null)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
            LabelTitle = title;
        }

        public string LabelTitle { get; private set; }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}