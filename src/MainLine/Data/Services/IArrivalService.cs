namespace MainLine.Data.Services;

public interface IArrivalService
{
    public Task<CtaArrivalsResponse> GetArrivalTimeByStationId(string stationId);
}
