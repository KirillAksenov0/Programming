public class Contact
{
    public string Name { get; set; }
    public string Surname { get; set; }
    private string _number;

    public string Number
    {
        get
        {
            return _number;
        }
        set
        {
            if (decimal.TryParse(value, out decimal number ) == true)
            {
                throw new ArgumentException();
            }
            _number = value;
        }
    }

    public Contact(string name, string surname, string number)
    {
        Name = name;
        Surname = surname;
        Number = number;
    }
}
