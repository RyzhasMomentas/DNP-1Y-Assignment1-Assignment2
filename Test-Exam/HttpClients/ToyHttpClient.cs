using System.Net.Http.Json;
using System.Text.Json;
using Domain;

namespace HttpClients;

public class ToyHttpClient
{
    private readonly HttpClient client;

    public ToyHttpClient(HttpClient client)
    {
        this.client = client;
    }
    
    public async Task<Toy> Create(Toy creatingToy)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("/toys", creatingToy);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }

        Toy toy = JsonSerializer.Deserialize<Toy>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return toy;
    }
}