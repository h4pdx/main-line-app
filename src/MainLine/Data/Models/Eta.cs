namespace MainLine.Data;

/// <summary>
/// Container element (one per individual prediction)
/// </summary>
public class Eta
{
    /// <summary>
    /// Numeric GTFS parent station ID which this prediction is for (five digits in 4xxxx range) (matches “mapid” specified by requestor in query)
    /// </summary>
    public string StaId { get; set; }
    /// <summary>
    /// Numeric GTFS unique stop ID within station which this prediction is for (five digits in 3xxxx range)
    /// </summary>
    public string StpId { get; set; }
    /// <summary>
    /// Textual proper name of parent station
    /// </summary>
    public string StaNm { get; set; }
    /// <summary>
    /// Textual description of platform for which this prediction applies
    /// </summary>
      public string StpDe { get; set; }
    /// <summary>
    /// Run number of train being predicted for
    /// </summary>
    public int Rn { get; set; }
    /// <summary>
    /// Textual, abbreviated route name of train being predicted for (matches GTFS routes)
    /// </summary>
    public string Rt { get; set; }
    /// <summary>
    /// GTFS unique stop ID where this train is expected to ultimately end its service run (experimental and supplemental only—see note below)
    /// </summary>
    public string DestSt { get; set; }
    /// <summary>
    /// Friendly destination description (see note below)
    /// </summary>
    public string DestNm { get; set; }
    /// <summary>
    /// Numeric train route direction code (see appendices)
    /// </summary>
    public int TrDr { get; set; }
    /// <summary>
    /// Date-time format stamp for when the prediction was generated: yyyyMMdd HH:mm:ss (24-hour format, time local to Chicago)
    /// </summary>
    public DateTime Prdt { get; set; }
    /// <summary>
    /// Date-time format stamp for when a train is expected to arrive/depart: yyyyMMdd HH:mm:ss (24-hour format, time local to Chicago)
    /// </summary>
    public DateTime ArrT { get; set; }
    /// <summary>
    /// Indicates that Train Tracker is now declaring “Approaching” or “Due” on site for this train
    /// </summary>
    public int IsApp { get; set; }
    /// <summary>
    /// Boolean flag to indicate whether this is a live prediction or based on schedule in lieu of live data
    /// </summary>
    public int IsSch { get; set; }
    /// <summary>
    /// Boolean flag to indicate whether a potential fault has been detected (see note below)
    /// </summary>
    public int IsFlt { get; set; }
    /// <summary>
    /// Boolean flag to indicate whether a train is considered “delayed” in Train Tracker
    /// </summary>
    public int IsDly { get; set; }
    /// <summary>
    /// Train flags (not presently in use)
    /// </summary>
    public string? Flags { get; set; }
    /// <summary>
    /// Latitude position of the train in decimal degrees
    /// </summary>
    public double? lat { get; set; }
    /// <summary>
    /// Longitude position of the train in decimal degrees
    /// </summary>
    public double? lon { get; set; }
    /// <summary>
    /// Heading, expressed in standard bearing degrees (0 = North, 90 = East, 180 = South, and 270 = West; range is 0 to 359, progressing clockwise)
    /// </summary>
    public int? Heading { get; set; }
}
