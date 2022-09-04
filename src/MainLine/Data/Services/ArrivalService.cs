using MainLine.Data.Clients;

namespace MainLine.Data.Services;

public class ArrivalService : IArrivalService
{
    private readonly ICtaHttpClient _ctaHttpClient;

    public ArrivalService(ICtaHttpClient ctaHttpClient)
        => _ctaHttpClient = ctaHttpClient ?? throw new ArgumentNullException(nameof(ctaHttpClient));
    
    public async Task<CtaArrivalsResponse> GetArrivalTimeByStationId(string stationId)
        => await _ctaHttpClient.GetArrivalTimeByStationId(stationId);
}
