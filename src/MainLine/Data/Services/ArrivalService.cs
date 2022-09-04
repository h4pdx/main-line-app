using MainLine.Data.Clients;

namespace MainLine.Data.Services;

public class ArrivalService : IArrivalService
{
    private readonly ICtaArrivalsHttpClient _ctaArrivalsHttpClient;

    public ArrivalService(ICtaArrivalsHttpClient ctaArrivalsHttpClient)
        => _ctaArrivalsHttpClient = ctaArrivalsHttpClient ?? throw new ArgumentNullException(nameof(ctaArrivalsHttpClient));
    
    public async Task<CtaArrivalsResponse> GetArrivalTimeByStationId(string stationId)
        => await _ctaArrivalsHttpClient.GetArrivalTimeByStationId(stationId);
}
