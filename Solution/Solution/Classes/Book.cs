﻿public class Book
{
    private string _bookTitle;

    private int _yearOfRelease;

    private string _author;

    private int _pageCount;

    public Genre Genre { get; set; }

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

    public Book(string bookTitle, int yearOfRelease, string author, int pageCount, Genre genre)
    {
        BookTitle = bookTitle;
        YearOfRelease = yearOfRelease;
        Author = author;
        PageCount = pageCount;
        Genre = genre;
    }
}