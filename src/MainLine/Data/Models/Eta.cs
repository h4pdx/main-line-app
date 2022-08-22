namespace MainLine.Data;

public class Eta
{
    public string StaId { get; set; }
    public string StpId { get; set; }
    public string StaNm { get; set; }
    public int StpDe { get; set; }
    public int Rn { get; set; }
    public int Rt { get; set; }
    public string DestSt { get; set; }
    public string DestNm { get; set; }
    public int TrDr { get; set; }
    public DateTime Prdt { get; set; }
    public DateTime ArrT { get; set; }
    public bool IsApp { get; set; }
    public bool IsSch { get; set; }
    public bool IsDly { get; set; }
    public bool IsFlt { get; set; }
    public string? Flags { get; set; }
    public double lat { get; set; }
    public double lon { get; set; }
    public int Heading { get; set; }
}
