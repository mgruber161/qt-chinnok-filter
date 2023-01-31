//@CodeCopy
//MdStart
using System;
using System.Windows.Input;

namespace QTChinnok.MvvMApp.ViewModels
{
    public partial class RelayCommand : ICommand
    {
        private readonly Action<object?> execute;
        private readonly Predicate<object?>? canExecute;

        public event EventHandler? CanExecuteChanged;

        private RelayCommand(Action<object?> execute, Predicate<object?>? canExecute)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }

        #region Factory mothods
        public static ICommand Create(ref ICommand? command, Action<object?> execute)
        {
            return Create(ref command, execute, null);
        }
        public static ICommand Create(ref ICommand? command, Action<object?> execute, Predicate<object?>? canExecute)
        {
            if (command == null)
            {
                command = new RelayCommand(execute, canExecute);
            }
            return command;
        }
        #endregion Factory methods
    }
}
//MdEnd
