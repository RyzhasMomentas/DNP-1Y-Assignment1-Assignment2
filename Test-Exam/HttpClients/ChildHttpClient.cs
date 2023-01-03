using System.Net.Http.Json;
using System.Text.Json;
using Domain;

namespace HttpClients;

public class ChildHttpClient
{
    private readonly HttpClient client;

    public ChildHttpClient(HttpClient client)
    {
        this.client = client;
    }
    
    public async Task<Child> Create(Child creatingChild)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("/children", creatingChild);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }

        Child child = JsonSerializer.Deserialize<Child>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return child;
    }
    public async Task<ICollection<Child>> GetAsync()
    {
        HttpResponseMessage response = await client.GetAsync("/children");
        string content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(content);
        }

        ICollection<Child> children = JsonSerializer.Deserialize<ICollection<Child>>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return children;
    }
}