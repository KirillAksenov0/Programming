using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

/// <summary>
/// Хранит данные о преритетных заказах. 
/// </summary>
public class PriorityOrder : Order
{
    /// <summary>
    /// Желаемая дата доставки.
    /// </summary>
    public DateTime DesiredDeliveryDate { get; set; }

    /// <summary>
    /// Желаемое время доставки.
    /// </summary>
    private string _desiredDeliveryTime;

    /// <summary>
    /// Возвращает и задает желаемое время доставки.
    /// </summary>
    public string DesiredDeliveryTime
    {
        get
        {
            return _desiredDeliveryTime;
        }

        set
        {
            var validTimes = new List<string>
            {
                "9:00 – 11:00",
                "11:00 – 13:00",
                "13:00 – 15:00",
                "15:00 – 17:00",
                "17:00 – 19:00",
                "19:00 – 21:00"
            };

            if (validTimes.Contains(value))
            {
                _desiredDeliveryTime = value;
            }
            else
            {
                throw new ArgumentException("Неверный диапазон времени доставки.");
            }
            
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="PriorityOrder">
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <param name="deliveryAddress">Адресс доставки.</param>
    /// <param name="customerFullName">Имя покупателя.</param>
    /// <param name="itemsAmount">Стоимость товаров.</param>
    /// <param name="desiredDeliveryDate">Желаемая дата доставки.</param>
    /// <param name="desiredDeliveryTime">Желаемое время доставки.</param>
    public PriorityOrder(List<Item> items, Address deliveryAddress, string customerFullName, 
        double itemsAmount, DateTime desiredDeliveryDate, string desiredDeliveryTime)
        : base ( items, deliveryAddress, customerFullName, itemsAmount)
    {
        DesiredDeliveryDate = desiredDeliveryDate;
        DesiredDeliveryTime = desiredDeliveryTime;
    }
}

