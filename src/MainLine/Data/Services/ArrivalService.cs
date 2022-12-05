using MainLine.Data.Clients;
using MainLine.Data.Models;

namespace MainLine.Data.Services;

public class ArrivalService : IArrivalService
{
    private readonly ICtaHttpClient _ctaHttpClient;

    public ArrivalService(ICtaHttpClient ctaHttpClient)
        => _ctaHttpClient = ctaHttpClient ?? throw new ArgumentNullException(nameof(ctaHttpClient));
    
    public async Task<CtaArrivalsResponse> GetArrivalTimeByStationId(string stationId)
        => await _ctaHttpClient.GetArrivalTimeByStationId(stationId);
    
    public async Task<IEnumerable<Station>> GetMappedArrivalTimeByStationId(string stationId)
        => MapResponse(await _ctaHttpClient.GetArrivalTimeByStationId(stationId));

    private static IEnumerable<Station> MapResponse(CtaArrivalsResponse response)
        => (response?.Ctatt?.Eta?.Any() is true)
        ? response.Ctatt.Eta
            .GroupBy(x => x.StaId)
            .OrderBy(x => x.Key)
            .Select(x => new Station
            {
                Id      = x.Key,
                Name    = x.FirstOrDefault()?.StaNm ?? string.Empty,
                Stops   = x.GroupBy(y => y.StpId)
                .OrderBy(y => y.Key)
                .Select(y => new Stop
                {
                    Id          = y.Key,
                    Description = y.FirstOrDefault()?.StpDe ?? string.Empty,
                    Arrivals    = y.Select(z => new Arrival(z))
                })
            })
            .ToList()
        : Enumerable.Empty<Station>();
}
