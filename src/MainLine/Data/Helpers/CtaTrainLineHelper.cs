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
            _       => throw new ArgumentException($"Invalid train line: {trainLine}")
        };

    public static string GetTrainLineColor(this string trainLine) 
        => trainLine switch
        {
            "Red"   => "#CC3333",
            "Blue"  => "#0099CC",
            "Brn"   => "#996633",
            "G"     => "#009933",
            "Org"   => "#FF9933",
            "P"     => "#660099",
            "Pink"  => "#FF6699",
            "Y"     => "#FFCC00",
            _       => throw new ArgumentException($"Invalid train line: {trainLine}")
        };
}
