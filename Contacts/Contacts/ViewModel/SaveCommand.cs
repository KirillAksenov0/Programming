using System;
using System.Windows.Input;

/// <summary>
/// Хранит команду для сохранения контакта.
/// </summary>
public class SaveCommand : RoutedCommand
{
    /// <summary>
    /// Вызывается при изминении состояния команды.
    /// </summary>
    event EventHandler CanExecuteChanged;

    /// <summary>
    /// Хранит логику команды.
    /// </summary>
    /// <param name="contact">контакт человека.</param>
    void Execute(Contact contact)
    {
        ContactSerializer.SaveContact(contact);
    }

    /// <summary>
    ///  Проверяет включена ли команда.
    /// </summary>
    /// <param name="parameter">входной параметр.</param>
    /// <returns>true, если команда включена. false, если не включена.</returns>
    bool CanExecute(object parameter)
    {
        return true;
    }
}