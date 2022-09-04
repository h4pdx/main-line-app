namespace MainLine.Data;

/// <summary>
/// CTA API response Root element
/// </summary>
public class Ctatt
{
    /// <summary>
    /// Shows time when response was generated in format: yyyyMMdd HH:mm:ss (24-hour format, time local to Chicago)
    /// </summary>
    DateTime Tmst { get; set; }
    /// <summary>
    /// Numeric error code (see appendices)
    /// </summary>
    public int ErrCd { get; set; }
    /// <summary>
    /// Textual error description/message (see appendices)
    /// </summary>
    public string ErrNm { get; set; }
    /// <summary>
    /// Container element (one per individual prediction)
    /// </summary>
    public IEnumerable<Eta> Eta { get; set; }
}
