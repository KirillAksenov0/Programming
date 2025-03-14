using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows;

/// <summary>
/// Хранит методы для сериализации и десериализации объекта.
/// </summary>
public static class ContactSerializer
{
    /// <summary>
    /// Путь к папке "Contacts".
    /// </summary>
    private static string _filePath = System.IO.Path.Combine(Environment.GetFolderPath(
    Environment.SpecialFolder.MyDoc‌​uments), "Contacts", "contacts.json");

    /// <summary>
    /// Контакт человека.
    /// </summary>
    private static Contact _contact;

    /// <summary>
    /// Возвращает и задает путь к папке "Contacts".
    /// </summary>
    public static string FilePath
    {
        get { return _filePath; }
        set { _filePath = value; }
    }

    /// <summary>
    /// Возвращает и задает контакт человека.
    /// </summary>
    public static Contact Contact
    {
        get
        {
            return _contact;
        }
        set
        {
            _contact = value;
        }
    }

    /// <summary>
    /// Сохраняет контакт в файле json.
    /// </summary>
    /// <param name="contact"></param>
    public static void SaveContact(Contact contact)
    {
        try
        {
            var json = JsonConvert.SerializeObject(contact);

            string directory = Path.GetDirectoryName(FilePath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllText(FilePath, json);
        }
        catch
        {
            MessageBox.Show("Возникла ошибка!");
        }
    }

    /// <summary>
    /// Загружает контакт из файла json.
    /// </summary>
    /// <param name="filePath"></param>
    public static void LoadContact()
    {
        if (File.Exists(FilePath))
        {
            var json = File.ReadAllText(FilePath);

            Contact = JsonConvert.DeserializeObject<Contact>(json);

        }

    }

 }