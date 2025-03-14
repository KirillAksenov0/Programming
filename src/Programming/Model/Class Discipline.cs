/// <summary>
/// Хранит данные зачетной книжки.
/// </summary>
public class Discipline
{
    /// <summary>
    /// Название дисциплины.
    /// </summary>
    public string DisciplineName { get; set; }

    /// <summary>
    /// Количество часов.
    /// </summary>
    private int _numberOfHours;

    /// <summary>
    /// Оценка.
    /// </summary>
    private int _grade;

    /// <summary>
    /// Возвращает и задает количество часов.
    /// </summary>
    public int NumberOfHours
    {
        get
        {
            return _numberOfHours;
        }
        set
        {
            Validator.AssertOnPositiveValue(value, "NumberOfHours");
            _numberOfHours = value;
        }
    }

    /// <summary>
    /// Возвращает и задает оценку.
    /// </summary>
    public int Grade
    {
        get
        {
            return _grade;
        }
        set
        {
            Validator.AssertValueInRange(value, 2, 5, "Grade");
            _grade = value;
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Discipline"/>.
    /// </summary>
    /// <param name="disciplineName">Название дисциплины. Должно состоять только из букв.</param>
    /// <param name="numberOfHours">Количество часов.</param>
    /// <param name="grade">Оценка.</param>
    public Discipline(string disciplineName, int numberOfHours, int grade)
    {
        DisciplineName = disciplineName;
        NumberOfHours = numberOfHours;
        Grade = grade;
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Discipline"/> без инициализации полей.
    /// </summary>
    public Discipline()
    {
        DisciplineName = "none";
        NumberOfHours = 0;
        Grade = 0;
    }
}