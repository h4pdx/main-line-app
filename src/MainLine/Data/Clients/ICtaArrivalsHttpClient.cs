namespace MainLine.Data.Clients;

public interface ICtaArrivalsHttpClient
{
    public Task<CtaArrivalsResponse> GetArrivalTimeByStationId(string stationId);
}