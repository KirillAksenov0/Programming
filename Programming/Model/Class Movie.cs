public class Movie
{
    public string Name { get; set; }
    public int DurationMinute { get; set; }
    private int _year;
    public string Genre { get; set; }
    private double _rating;

    public int Year
    {
        get
        {
            return _year;
        }
        set 
        {
            if (value < 1900 || value > 2024)
            {
                throw new ArgumentException();
            }
            _year = value;
        }
    }

    public double Rating
    {
        get
        {
            return _rating;
        }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException();
            }
            _rating = value;
        }
    }

    public Movie(string name, int durationminute, int year, string genre, double rating)
    {
        Name = name;
        DurationMinute = durationminute;
        Year = year;
        Genre = genre;
        Rating = rating;
    }

    public Movie()
    {
        Name = "none";
        DurationMinute = 0;
        Year = 0;
        Genre = "none";
        Rating= 0;
    }
}