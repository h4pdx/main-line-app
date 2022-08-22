namespace MainLine.Data;

public class Ctatt
{
    DateTime Tmst { get; set; }
    public int ErrCd { get; set; }
    public string ErrNm { get; set; }
    public IEnumerable<Eta> ErrDsc { get; set; }
}
