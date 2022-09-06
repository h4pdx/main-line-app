namespace MainLine.Data.Services;

public interface IArrivalService
{
    public Task<CtaArrivalsResponse> GetArrivalTimeByStationId(string stationId);
    public Task<IEnumerable<Station>> GetMappedArrivalTimeByStationId(string stationId);
}
