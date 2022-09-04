namespace MainLine.Data.Clients;

public interface ICtaHttpClient
{
    public Task<CtaArrivalsResponse> GetArrivalTimeByStationId(string stationId);
}