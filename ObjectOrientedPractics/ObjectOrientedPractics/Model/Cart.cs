/// <summary>
/// Хранит данные о корзине покупателя.
/// </summary>
public class Cart
{
    /// <summary>
    /// Список товаров покупателя.
    /// </summary>
    private List<Item> _items;

    /// <summary>
    /// Возвращает и задает список товаров покупателя.
    /// </summary>
    public List<Item> Items
    {
        get { return _items; }
        set { _items = value; }
    }

    /// <summary>
    /// Вовращает общую стоимость всех товаров в корзине. 
    /// </summary>
    public double Amount
    {
        get
        {
            double amountCostItems = 0;
            if (Items.Count == 0 || Items == null)
            {
                return 0.0;
            }
            else
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    amountCostItems += Items[i].Cost;
                }

                return amountCostItems;
            }
        }
    }

}