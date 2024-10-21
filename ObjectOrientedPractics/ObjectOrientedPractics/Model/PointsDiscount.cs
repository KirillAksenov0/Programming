public class PointsDiscount
{
    private int _pointsCount;

    public int PointsCount
    {
        get { return _pointsCount; }
        private set
        {
            _pointsCount = value;
        }
    }

    public double Calculate(List<Item> items)
    {
        double totalCost = 0;
        foreach (var item in items)
        {
            totalCost += item.Cost;
        }

        double maxDiscount = totalCost * 0.3;
        double discount = Math.Min(PointsCount, maxDiscount);

        return discount;
    }

    public double Apply(List<Item> items)
    {
        double discount = Calculate(items);
        if (discount > 0)
        {
            PointsCount -= (int)discount;
            return discount;
        }
        return 0;
    }

    public void Update(List<Item> items)
    {
        double totalCost = 0;
        foreach (var item in items)
        {
            totalCost += item.Cost;
        }

        int earnedPoints = (int)Math.Ceiling(totalCost * 0.1);
        PointsCount += earnedPoints;
    }

    public string Info => $"Накопительная – {PointsCount} баллов";
}
