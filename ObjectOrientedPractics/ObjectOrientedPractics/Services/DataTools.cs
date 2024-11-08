using System.Collections.Generic;

public delegate bool CompareValue(Item item);

public delegate bool CompareValues(Item item1, Item item2);

/// <summary>
/// Хранит методы для работы с данными.
/// </summary>
public class DataTools
{
    /// <summary>
    /// Сравнивает цену товара.
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public static bool CompareByCost(Item item)
    {
        return item.Cost > 5000.0;
    }
    
    /// <summary>
    /// Сравнивает категорию товара.
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public static bool CompareByCategory(Item item)
    {
        return item.Category == Category.Electronics;
    }

    /// <summary>
    /// Сравнивает цену двух товаров для сортировки по возрастанию.
    /// </summary>
    /// <param name="item1">Первый товар.</param>
    /// <param name="item2">Второй товар.</param>
    /// <returns>true,если цена первого товара меньше второго.</returns>
    public static bool CompareAscending(Item item1, Item item2)
    {
        return item1.Cost < item2.Cost;
    }

    /// <summary>
    /// Сравнивает цену двух товаров для сортировки по убыванию.
    /// </summary>
    /// <param name="item1">Первый товар.</param>
    /// <param name="item2">Второй товар.</param>
    /// <returns>true,если цена первого товара больше второго.</returns>
    public static bool CompareDescending(Item item1, Item item2)
    {
        return item1.Cost > item2.Cost;
    }

    /// <summary>
    /// Сравнивает названия двух товаров.
    /// </summary>
    /// <param name="item1">Первый товар.</param>
    /// <param name="item2">Второй товар.</param>
    /// <returns>true, если первый товар стоит выше по алфавиту.</returns>
    public static bool CompareAscendingByName(Item item1, Item item2)
    {
        return string.Compare(item1.Name, item2.Name, StringComparison.Ordinal) < 0;
    }

    /// <summary>
    /// Фильтрует список товаров.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <param name="compare">Делегат, по которому определяется фильтрация.</param>
    /// <returns></returns>
    public static List<Item> ItemFiltering(List<Item> items, CompareValue compare)
    {
        List<Item> filteredList = new List<Item>();

        foreach (Item item in items)
        {
            if (compare(item))
            {
                filteredList.Add(item);
            }
        }
        return filteredList;
    }

    /// <summary>
    /// Сортирует список товаров.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <param name="compare">Делегат, который определяет метод сортировки.</param>
    public static void ItemSorting(List<Item> items, CompareValues compare)
    {
       
        for(int i = 0; i < items.Count; i++)
{
            for (int j = 1; j < items.Count; j++)
            {
                if (compare(items[j], items[j-1]))
                {
                    Item temp = items[j];
                    items[j] = items[j - 1];
                    items[j - 1] = temp;
                }
            }
        }
    }
}
