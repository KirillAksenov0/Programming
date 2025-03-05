using Newtonsoft.Json;
using System.IO;
using System.Windows.Media;

/// <summary>
/// Хранит методы для сериализации и десериализации объекта.
/// </summary>
static class ContactSerializer
{
    /// <summary>
    /// Путь к файлу.
    /// </summary>
    static private string _filePath = @"C:\Documents\Contacts\contacts.json";

    /// <summary>
    /// Возвращает и задает путь к файлу.
    /// </summary>
    static public string FilePath
    {
        get { return _filePath; }
        set { _filePath = value; }
    }

    /// <summary>
    /// Сохраняет контакт в файле json.
    /// </summary>
    /// <param name="contact"></param>
    static public void SaveContact(Contact contact)
    {
        var json = JsonConvert.SerializeObject(contact);

        File.WriteAllText(FilePath, json);
    }

    /// <summary>
    /// Загружает контакт из файла json.
    /// </summary>
    /// <param name="filePath"></param>
    static public void LoadContact(string filePath)
    {
        var json = File.ReadAllText(filePath);

        
        var data = JsonConvert.DeserializeObject<Contact>(json);
    }

}