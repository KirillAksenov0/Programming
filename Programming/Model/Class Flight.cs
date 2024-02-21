public class Flight
{
    public string DeparturePoint { get; set; }
    public string DestinationPoint { get; set; }
    public int FlightTimeMinute { get; set; }

    public Flight(string departurePoint, string destinationPoint, int flightTimeMinute)
    {
        DeparturePoint = departurePoint;
        DestinationPoint = destinationPoint;
        FlightTimeMinute = flightTimeMinute;
    }
}