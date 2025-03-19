using System;
using System.Windows.Input;

/// <summary>
/// Хранит команду для сохранения контакта.
/// </summary>
public class SaveCommand : ICommand
{
    /// <summary>
    /// Логика команды.
    /// </summary>
    private Action<object> _execute;

    /// <summary>
    /// Условие выполнения команды.
    /// </summary>
    private Func<object, bool> _canExecute;

    /// <summary>
    /// Вызывается при изминении состояния команды.
    /// </summary>
    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="SaveCommand">.
    /// </summary>
    /// <param name="contact">Контакт человека.</param>
    public SaveCommand(Action<object> execute, Func<object, bool> canExecute = null)
    {
        this._execute = execute;
        this._canExecute = canExecute;
    }

    /// <summary>
    ///  Проверяет включена ли команда.
    /// </summary>
    /// <param name="parameter">входной параметр.</param>
    /// <returns>true, если команда включена. false, если не включена.</returns>
    public bool CanExecute(object parameter)
    {
        return true;
    }

    /// <summary>
    /// Хранит логику команды.
    /// </summary>
    /// <param name="contact">контакт человека.</param>
    public void Execute(object parameter)
    {
        this._execute(parameter);
    }
}