namespace MainLine.Data.Clients;

public class CtaArrivalsHttpClient : HttpClientBase, ICtaArrivalsHttpClient
{
    private const string ApiKey = "09676717a2834e8bb7bb2debb65304ac";

    public CtaArrivalsHttpClient(HttpClient httpClient) : base(httpClient) {}

    public async Task<CtaArrivalsResponse> GetArrivalTimeByStationId(string stationId)
        => await GetRequest<CtaArrivalsResponse>($"?key={ApiKey}&mapid={stationId}&outputType=JSON");
}
