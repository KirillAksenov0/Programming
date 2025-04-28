using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace Model.Services
{
    /// <summary>
    /// Хранит методы для сериализации и десериализации объекта.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Json файл, хранящий контакты.
        /// </summary>
        private static string _filePath = "contacts.json";

        /// <summary>
        /// Путь к папке "Contacts".
        /// </summary>
        private static string _directoryPath = Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.MyDoc‌​uments), "Contacts");

        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        private static ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Возвращает и задает путь к папке "Contacts".
        /// </summary>
        public static string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public static string DirectoryPath
        {
            get { return _directoryPath; }
            set { _directoryPath = value; }
        }

        /// <summary>
        /// Возвращает и задает коллекцию контактов.
        /// </summary>
        public static ObservableCollection<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
            set
            {
                _contacts = value;
            }
        }

        /// <summary>
        /// Сохраняет контакты в файле json.
        /// </summary>
        /// <param name="contact"></param>
        public static void SaveContact(ObservableCollection<Contact> contacts)
        {
            try
            {
                var json = JsonConvert.SerializeObject(contacts);

                if (!Directory.Exists(DirectoryPath))
                {
                    Directory.CreateDirectory(DirectoryPath);
                }

                File.WriteAllText(Path.Combine(DirectoryPath, FilePath), json);
            }
            catch
            {
                throw new Exception("Возникла ошибка");
            }
        }

        /// <summary>
        /// Загружает контакты из файла json.
        /// </summary>
        /// <param name="filePath"></param>
        public static ObservableCollection<Contact> LoadContact()
        {
            string fullFilePath = Path.Combine(DirectoryPath, FilePath);

            if (File.Exists(fullFilePath))
            {
                var json = File.ReadAllText(fullFilePath);

                Contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(json);

                return Contacts;
            }

            else
            {
                return null;
            }

        }

    }
}