namespace MainLine.Data;
public class Arrival
{
    private readonly Eta _arrival;
    public Arrival(Eta eta) => _arrival = eta;

    public DateTime ArrivalTime         => _arrival.ArrT;
    public string ArrivalTimeInMinutes  => _arrival.ArrT.GetArrivalTime(_arrival.IsSch == 0 && _arrival.IsApp == 1);
    public string DestinationName       => _arrival.DestNm;
    public string RunId                 => _arrival.Rn.GetLineNumberFormatted();
    public string Route                 => _arrival.Rt.GetTrainLineName();
    public string RouteColor            => _arrival.Rt.GetTrainLineColor();
    public bool IsDue                   => _arrival.IsApp == 1;
    public bool IsScheduled             => _arrival.IsSch == 1;
    public bool IsDelayed               => _arrival.IsDly == 1;
}

public class Stop
{
    public string Id { get; set; }
    public string Description { get; set; }
    public IEnumerable<Arrival> Arrivals { get; set; }
}

public class Station
{
    public string Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<Stop> Stops { get; set; }
}
