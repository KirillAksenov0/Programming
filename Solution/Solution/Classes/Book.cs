/// <summary>
/// Хранит данные о книге.
/// </summary>
public class Book
{
    /// <summary>
    /// Название книги.
    /// </summary>
    private string _bookTitle;

    /// <summary>
    /// Год выпуска.
    /// </summary>
    private int _yearOfRelease;

    /// <summary>
    /// Автор книги.
    /// </summary>
    private string _author;

    /// <summary>
    /// Количесвто страниц.
    /// </summary>
    private int _pageCount;

    /// <summary>
    /// Жанр книги.
    /// </summary>
    public Genre Genre { get; set; }

    /// <summary>
    /// Возвращает и задает название книги. Количесвто символов в названий не должно привышать 100
    /// символов и быть пустым значением.
    /// </summary>
    public string BookTitle
    {
        get
        {
            return _bookTitle;
        }
        set
        {
            if (value.Length > 100)
            {
                throw new ArgumentException("Некоректное значение в поле Book Title. Длина книги" +
                    " не должна привышать 100 символов");
            }
            else if (value == "")
            {
                throw new ArgumentException("Заполнены не все поля");
            }
            else
            {
                _bookTitle = value;
            }
        }
    }

    /// <summary>
    /// Возвращает и задает год выпуска. Должен не превышать текущий год и не быть отрицательным числом.
    /// </summary>
    public int YearOfRelease
    {
        get
        {
            return _yearOfRelease;
        }
        set
        {
            if (value > 2024 || value < 0)
            {
                throw new ArgumentException("Некоректное значение в поле Year of Release. Год выпуска" +
                    " не должен быть больше текущего или иметь отрицательное значение");
            }
            _yearOfRelease = value;
            
        }
    }

    /// <summary>
    /// Возвращает и задает автора книги. Не должно быть пустым значением.
    /// </summary>
    public string Author
    {
        get
        {
            return _author;
        }
        set
        {
            if (value == "")
            {
                throw new ArgumentException($"Заполнены не все поля");
            }
            _author = value;
        }
    }

    /// <summary>
    /// Возвращает и задет количество страниц книги. Не должно быть отрицательным числом.
    /// </summary>
    public int PageCount
    {
        get
        {
            return _pageCount;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Некоректное значение в поле Page Count. Количество страниц " +
                    "должно быть положительным числом");
            }
            _pageCount = value;
            
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Book"/>.
    /// </summary>
    /// <param name="bookTitle">Название.</param>
    /// <param name="yearOfRelease">Год выпуска</param>
    /// <param name="author">Автор.</param>
    /// <param name="pageCount">Количество страниц.</param>
    /// <param name="genre">Жанр.</param>
    public Book(string bookTitle, int yearOfRelease, string author, int pageCount, Genre genre)
    {
        BookTitle = bookTitle;
        YearOfRelease = yearOfRelease;
        Author = author;
        PageCount = pageCount;
        Genre = genre;
    }
}