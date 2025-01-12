using System.Net.Http.Headers;

public class Program
{
    public static Main(string[] args)
    {
        using HttpClient client = new();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
        client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
       await ProcessRepositoriesAsync(client);
    }
    
    
await ProcessRepositoriesAsync();

static async Task ProcessRepositoriesAsync(HttpClient client)
{
}
 

}