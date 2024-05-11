using System.Reflection.Metadata.Ecma335;

static public class Validator
{
    public static bool AssertValueInRange(double value, double min, double max)
    {
        if (value < min || value > max)
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }

    public static bool AssertOnPositiveValue(double value)
    {
        if (value <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static void ValidationTextBox(TextBox textBox, ListBox BooksListBox, List<Book> books)
    {
        try
        {
            double pageCount = Convert.ToInt32(textBox.Text);
            if (Validator.AssertOnPositiveValue(pageCount) == false)
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }

            else
            {
                textBox.BackColor = SystemColors.Window;
            }

            if (BooksListBox.SelectedIndex != -1)
            {
                books[BooksListBox.SelectedIndex].PageCount = Convert.ToInt32(textBox.Text);
            }
        }

        catch (FormatException)
        {
            if (!int.TryParse(textBox.Text, out int page))
            {
                // Если не удалось преобразовать, окрашиваем фон в красный
                textBox.BackColor = System.Drawing.Color.LightPink;
            }

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BackColor = SystemColors.Window;
            }

        }
    }
}