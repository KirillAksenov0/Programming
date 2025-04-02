using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace View.ViewModel.Services
{
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
        /// Загружает контакты из файла json.
        /// </summary>
        /// <param name="filePath"></param>
        public static ObservableCollection<Contact> LoadContact()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);

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