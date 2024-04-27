namespace Solution
{
    public partial class Form1 : Form
    {
        private List<Book> books;

        private Book _currentBook;
        public Form1()
        {
            InitializeComponent();
            JFJF();

            books = new List<Book>();
        }

        private void JFJF()
        {
            foreach (Genre genreName in Enum.GetValues(typeof(Genre)))

                GenreComboBox.Items.Add(genreName);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentBook = new Book(BookTitleTextBox.Text, Convert.ToInt32(YearOfReleaseTextBox.Text),
                AuthorTextBox.Text, Convert.ToInt32(PageCountTextBox.Text), (Genre)GenreComboBox.SelectedItem);
            
            //_currentBook.Genre = (Genre)GenreComboBox.SelectedItem;

            books.Add(_currentBook);
            BooksListBox.Items.Add(_currentBook.BookTitle);
        }
    }
}