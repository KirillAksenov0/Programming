using System.Linq.Expressions;

namespace Solution
{
    public partial class Form1 : Form
    {
        private List<Book> books;

        private Book _currentBook;
        public Form1()
        {
            InitializeComponent();
            FillingGenreComboBox();

            books = new List<Book>();
        }

        private void FillingGenreComboBox()
        {
            foreach (Genre genreName in Enum.GetValues(typeof(Genre)))

                GenreComboBox.Items.Add(genreName);
        }

        private void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedIndex != null)
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
            // Проверяем, является ли введенное значение годом в диапазоне от 0 до 2024
            if ((int.TryParse(YearOfReleaseTextBox.Text, out int year) && year >= 0 && year <= 2024))
            {
                // Если значение верное, устанавливаем цвет текстового поля в обычный
                YearOfReleaseTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                // Если значение неверное, устанавливаем красный цвет текстового поля
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
            // Проверяем, является ли введенное значение положительным целым числом
            if ((int.TryParse(PageCountTextBox.Text, out int pages) && pages > 0))
            {
                // Если значение верное, устанавливаем белый цвет фона текстового поля
                PageCountTextBox.BackColor = SystemColors.Window;

            }
            else
            {
                // Если значение неверное, устанавливаем красный цвет фона текстового поля
                PageCountTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AuthorTextBox.Text == "")
            {
                // Если значение неверное, устанавливаем красный цвет фона текстового поля
                AuthorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                // Если значение верное, устанавливаем белый цвет фона текстового поля
                AuthorTextBox.BackColor = SystemColors.Window;
            }
        }

        private void GenreComboBox_TextChanged(object sender, EventArgs e)
        {
            // Проверяем, существует ли введенное пользователем значение в списке предложенных значений ComboBox
            if (GenreComboBox.SelectedIndex == -1)
            {
                // Если введенное значение отсутствует в списке, окрашиваем ComboBox в красный
                GenreComboBox.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                // Если введенное значение совпадает с одним из предложенных, устанавливаем стандартный цвет
                GenreComboBox.BackColor = SystemColors.Window;
            }
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            if ((!int.TryParse(PageCountTextBox.Text, out int pageCount) && PageCountTextBox.Text != "") ||
                (!int.TryParse(YearOfReleaseTextBox.Text, out int year) && YearOfReleaseTextBox.Text != ""))
            {
                throw new Exception("Введено не корректное значение");
            }
            try
            {
                _currentBook = new Book(BookTitleTextBox.Text, Convert.ToInt32(YearOfReleaseTextBox.Text),
                    AuthorTextBox.Text, Convert.ToInt32(PageCountTextBox.Text), (Genre)GenreComboBox.SelectedItem);
            }

            catch (FormatException)
            {
                throw new Exception("Заполнены не все поля");
            }

            catch (NullReferenceException)
            {
                throw new Exception("Не выбран жанр книги");
            }


            books.Add(_currentBook);

            books.Sort((book1, book2) => string.Compare(book1.BookTitle, book2.BookTitle));

            BooksListBox.Items.Clear();

            foreach (Book book in books)
            {
                BooksListBox.Items.Add($"{book.BookTitle}, {book.Author}, " +
               $"{book.YearOfRelease} г.");
            }
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
                   $"{book.YearOfRelease} г.");
                }
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
                         $"{book.YearOfRelease} г.");
                    }
                }
                catch (FormatException)
                {
                    throw new Exception("Введено неккоректное значение");
                }
                catch (NullReferenceException)
                {
                    throw new Exception("Не выбран жанр книги");
                }
            }
        }


    }
}