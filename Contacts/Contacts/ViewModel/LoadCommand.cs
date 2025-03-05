using System.Windows.Input;
using System;

/// <summary>
/// Хранит команду для загрузки контакта из файла.
/// </summary>
public class LoadCommand : RoutedCommand
{
    /// <summary>
    /// Вызывается при изминении состояния команды.
    /// </summary>
    event EventHandler CanExecuteChanged;

    /// <summary>
    /// Хранит логику команды.
    /// </summary>
    /// <param name="filePath">Путь к файлу.</param>
    void Execute(string filePath)
    {
        ContactSerializer.LoadContact(filePath);
    }

    /// <summary>
    /// Проверяет включена ли команда.
    /// </summary>
    /// <param name="parameter">входной параметр.</param>
    /// <returns>true, если команда включена. false, если не включена.</returns>
    bool CanExecute(object parameter)
    {
        return true;
    }
}
