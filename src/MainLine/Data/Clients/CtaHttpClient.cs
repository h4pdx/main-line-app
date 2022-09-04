namespace MainLine.Data.Clients;

public class CtaHttpClient : HttpClientBase, ICtaHttpClient
{
    private readonly CtaClientConfig _config;

    public CtaHttpClient(HttpClient httpClient, CtaClientConfig config)
        : base(httpClient)
        => _config = config ?? throw new ArgumentNullException(nameof(config));

    public async Task<CtaArrivalsResponse> GetArrivalTimeByStationId(string stationId)
        => await GetRequest<CtaArrivalsResponse>($"?key={_config.ApiKey}&mapid={stationId}&outputType=JSON");
}
