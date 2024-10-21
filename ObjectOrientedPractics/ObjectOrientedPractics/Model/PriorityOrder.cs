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
    private DeliveryTime _desiredDeliveryTime;

    /// <summary>
    /// Возвращает и задает желаемое время доставки.
    /// </summary>
    public DeliveryTime DesiredDeliveryTime
    {
        get
        {
            return _desiredDeliveryTime;
        }

        set
        {
            _desiredDeliveryTime = value; 
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
        double itemsAmount, DateTime desiredDeliveryDate, DeliveryTime desiredDeliveryTime)
        : base ( items, deliveryAddress, customerFullName, itemsAmount)
    {
        DesiredDeliveryDate = desiredDeliveryDate;
        DesiredDeliveryTime = desiredDeliveryTime;
    }
}

