namespace MainLine.Data;

public static class CtaTrainLineHelper
{
    public static string GetTrainLineName(this string trainLine)
        => trainLine switch
        {
            "Red"   => "Red Line",
            "Blue"  => "Blue Line",
            "Brn"   => "Brown Line",
            "G"     => "Green Line",
            "Org"   => "Orange Line",
            "P"     => "Purple Line",
            "Pink"  => "Pink Line",
            "Y"     => "Yellow Line",
            _       => throw new ArgumentException($"GetTrainLineName: Invalid train line: {trainLine}")
        };

    /// <summary>
    /// Branding colors from CTA docs - https://www.transitchicago.com/developers/branding/
    /// </summary>
    public static string GetTrainLineColor(this string trainLine) 
        => trainLine switch
        {
            "Red"   => "#C60C30",
            "Blue"  => "#00A1DE",
            "Brn"   => "#62361B",
            "G"     => "#009B3A",
            "Org"   => "#F9461C",
            "P"     => "#522398",
            "Pink"  => "#E27EA6",
            "Y"     => "#F9E300",
            _       => throw new ArgumentException($"GetTrainLineColor: Invalid train line: {trainLine}")
        };

    public static string GetLineNumberFormatted(this int lineNumber)
        => lineNumber switch
        {
            (< 10)  => $"00{lineNumber}",
            (< 100) => $"0{lineNumber}",
            _       => $"{lineNumber}"
        };

    public static string GetArrivalTime(this DateTime arrival, bool isDue)
    {
        var timeSpan = arrival - DateTime.Now;
        var minutesUntilArrival = (int)timeSpan.TotalMinutes;
        var due = isDue ? "Due" : "<1 min";
        return (minutesUntilArrival > 0 ? $"{minutesUntilArrival} min" : due);
    }
}
