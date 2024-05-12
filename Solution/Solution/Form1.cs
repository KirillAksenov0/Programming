using System.Linq.Expressions;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using System.IO;

namespace Solution
{
    public partial class Form1 : Form
    {
        private List<Book> books;

        public List<string[]> booksInfo;
        private string filePath;

        private Book _currentBook;
        public Form1()
        {

            InitializeComponent();
            FillingGenreComboBox();
            filePath = @"C:\Users\HONOR01\source\repos\Programming\Solution\Solution\books.txt";
            books = new List<Book>();
            LoadBooksFromFile();



            booksInfo = new List<string[]>();

        }

        private void FillingGenreComboBox()
        {
            foreach (Genre genreName in Enum.GetValues(typeof(Genre)))

                GenreComboBox.Items.Add(genreName);
        }

        private void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedIndex != -1)
            {
                UpdateTextBox();

            }
            else
            {
                ClearTextBox();
            }
        }

        private void UpdateTextBox()
        {
            _currentBook = books[BooksListBox.SelectedIndex];
            BookTitleTextBox.Text = _currentBook.BookTitle;
            YearOfReleaseTextBox.Text = _currentBook.YearOfRelease.ToString();
            AuthorTextBox.Text = _currentBook.Author;
            PageCountTextBox.Text = _currentBook.PageCount.ToString();
            GenreComboBox.SelectedItem = _currentBook.Genre;

        }

        private void ClearTextBox()
        {
            BookTitleTextBox.Text = "";
            YearOfReleaseTextBox.Text = "";
            AuthorTextBox.Text = "";
            PageCountTextBox.Text = "";
            GenreComboBox.SelectedItem = null;
        }

        private void YearOfReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            // ���������, �������� �� ��������� �������� ����� � ��������� �� 0 �� 2024
            if ((int.TryParse(YearOfReleaseTextBox.Text, out int year) && year >= 0 && year <= 2024))
            {
                // ���� �������� ������, ������������� ���� ���������� ���� � �������
                YearOfReleaseTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                // ���� �������� ��������, ������������� ������� ���� ���������� ����
                YearOfReleaseTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void BookTitleTextBox_TextChanged(object sender, EventArgs e)
        {

            if (BookTitleTextBox.TextLength > 100 || BookTitleTextBox.Text == "")
            {
                BookTitleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {

                BookTitleTextBox.BackColor = SystemColors.Window;

            }

        }
        private void PageCountTextBox_TextChanged(object sender, EventArgs e)
        {
            // ���������, �������� �� ��������� �������� ������������� ����� ������
            if ((int.TryParse(PageCountTextBox.Text, out int pages) && pages > 0))
            {
                // ���� �������� ������, ������������� ����� ���� ���� ���������� ����
                PageCountTextBox.BackColor = SystemColors.Window;

            }
            else
            {
                // ���� �������� ��������, ������������� ������� ���� ���� ���������� ����
                PageCountTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AuthorTextBox.Text == "")
            {
                // ���� �������� ��������, ������������� ������� ���� ���� ���������� ����
                AuthorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                // ���� �������� ������, ������������� ����� ���� ���� ���������� ����
                AuthorTextBox.BackColor = SystemColors.Window;
            }
        }

        private void GenreComboBox_TextChanged(object sender, EventArgs e)
        {
            // ���������, ���������� �� ��������� ������������� �������� � ������ ������������ �������� ComboBox
            if (GenreComboBox.SelectedIndex == -1)
            {
                // ���� ��������� �������� ����������� � ������, ���������� ComboBox � �������
                GenreComboBox.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                // ���� ��������� �������� ��������� � ����� �� ������������, ������������� ����������� ����
                GenreComboBox.BackColor = SystemColors.Window;
            }
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            if ((!int.TryParse(PageCountTextBox.Text, out int pageCount) && PageCountTextBox.Text != "") ||
                (!int.TryParse(YearOfReleaseTextBox.Text, out int year) && YearOfReleaseTextBox.Text != ""))
            {
                throw new Exception("������� �� ���������� ��������");
            }
            try
            {
                _currentBook = new Book(BookTitleTextBox.Text, Convert.ToInt32(YearOfReleaseTextBox.Text),
                    AuthorTextBox.Text, Convert.ToInt32(PageCountTextBox.Text), (Genre)GenreComboBox.SelectedItem);
            }

            catch (FormatException)
            {
                throw new Exception("��������� �� ��� ����");
            }

            catch (NullReferenceException)
            {
                throw new Exception("�� ������ ���� �����");
            }

            books.Add(_currentBook);

            books.Sort((book1, book2) => string.Compare(book1.BookTitle, book2.BookTitle));

            BooksListBox.Items.Clear();

            foreach (Book book in books)
            {
                BooksListBox.Items.Add($"{book.BookTitle}, {book.Author}, " +
               $"{book.YearOfRelease} �.");
            }
            SaveBooksToFile();
        }

        private void DelPictureBox_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedIndex != -1)
            {
                books.RemoveAt(BooksListBox.SelectedIndex);
                BooksListBox.Items.Remove(BooksListBox.SelectedIndex);
                ClearTextBox();
                books.Sort((book1, book2) => string.Compare(book1.BookTitle, book2.BookTitle));

                BooksListBox.Items.Clear();

                foreach (Book book in books)
                {
                    BooksListBox.Items.Add($"{book.BookTitle}, {book.Author}, " +
                   $"{book.YearOfRelease} �.");
                }
                SaveBooksToFile();
            }

        }

        private void EditPictureBox_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedIndex != -1)
            {
                try
                {
                    books[BooksListBox.SelectedIndex].PageCount = Convert.ToInt32(PageCountTextBox.Text);
                    books[BooksListBox.SelectedIndex].BookTitle = BookTitleTextBox.Text;
                    books[BooksListBox.SelectedIndex].YearOfRelease = Convert.ToInt32(YearOfReleaseTextBox.Text);
                    books[BooksListBox.SelectedIndex].Author = AuthorTextBox.Text;
                    books[BooksListBox.SelectedIndex].Genre = (Genre)GenreComboBox.SelectedItem;
                    books.Sort((book1, book2) => string.Compare(book1.BookTitle, book2.BookTitle));

                    BooksListBox.Items.Clear();

                    foreach (Book book in books)
                    {
                        BooksListBox.Items.Add($"{book.BookTitle}, {book.Author}, " +
                         $"{book.YearOfRelease} �.");
                    }
                    SaveBooksToFile();
                }
                catch (FormatException)
                {
                    throw new Exception("������� ������������ ��������");
                }
                catch (NullReferenceException)
                {
                    throw new Exception("�� ������ ���� �����");
                }
            }
        }
        private void SaveBooksToFile()
        {
            File.WriteAllText(filePath, string.Empty);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (Book book in books)
                {
                    string line = $"{book.BookTitle};{book.YearOfRelease};{book.Author};{book.PageCount};{book.Genre}";
                    writer.WriteLine(line);
                }
            }
        }

        private void LoadBooksFromFile()
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] info = line.Split(";");
                if (info.Length >= 5)
                {
                    Book book = new Book(info[0], Convert.ToInt32(info[1]), info[2],
                     Convert.ToInt32(info[3]), (Genre)Enum.Parse(typeof(Genre), info[4]));

                    books.Add(book);
                }
            }

            books.Sort((book1, book2) => string.Compare(book1.BookTitle, book2.BookTitle));

            foreach (Book book in books)
            {
                BooksListBox.Items.Add($"{book.BookTitle}, {book.Author}, " +
               $"{book.YearOfRelease} �.");
            }

        }


    }
}