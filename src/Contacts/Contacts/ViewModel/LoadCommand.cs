using System.Windows.Input;
using System;

/// <summary>
/// Хранит команду для загрузки контакта из файла.
/// </summary>
public class LoadCommand : ICommand
{
    /// <summary>
    /// Ссылка на MainVM.
    /// </summary>
    private readonly MainVM _viewModel;

    /// <summary>
    /// Вызывается при изминении состояния команды.
    /// </summary>
    public event EventHandler CanExecuteChanged;

    /// <summary>
    /// Проверяет включена ли команда.
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
    /// <param name="filePath">Путь к файлу.</param>
    public void Execute(object parameter)
    {
        try
        {
            ContactSerializer.LoadContact();

            Contact contact = ContactSerializer.Contact;

            if (contact != null)
            {
                _viewModel.Name = contact.Name;
                _viewModel.Email = contact.Email;
                _viewModel.PhoneNumber = contact.PhoneNumber;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Ошибка при загрузке файла");
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="LoadCommand">.
    /// </summary>
    /// <param name="contact">Контакт человека.</param>
    public LoadCommand( MainVM viewModel)
    {
        _viewModel = viewModel;
    }
}
