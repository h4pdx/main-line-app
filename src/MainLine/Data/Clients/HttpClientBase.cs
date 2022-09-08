using Newtonsoft.Json;

namespace MainLine.Data.Clients;

public abstract class HttpClientBase
{
    private readonly HttpClient _httpClient;

    protected HttpClientBase(HttpClient httpClient)
        => _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

    protected async Task<TResponse> GetRequest<TResponse>(string url)
    {
        using var request = new HttpRequestMessage(HttpMethod.Get, url);
        using var response = await _httpClient.SendAsync(request);
        return await ParseResponse<TResponse>(response);
    }

    private async Task<TResponse> ParseResponse<TResponse>(HttpResponseMessage response)
    {
        var content = await response.Content.ReadAsStringAsync();
        TResponse obj;
        
        try
        {
            obj = JsonConvert.DeserializeObject<TResponse>(content) ?? throw new InvalidOperationException($"JSON deserialization of HttpResponse failed");
        }
        catch (Exception ex)
        {
            throw new Exception($"Error parsing response: {content}", ex);
        }

        return obj;
    }
}