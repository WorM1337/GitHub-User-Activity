using System.Text.Json;
using Github_User_Activity.Models;
using Github_User_Activity.Models.Payloads;

namespace Github_User_Activity;

public class Program
{
    public static async Task Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: <run-string> <username>");
            return;
        }
    
        var client = new HttpClient();
        // magic words :)
        client.DefaultRequestHeaders.Add("User-Agent", "RoadmapSH-Project");
        client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
    
        client.BaseAddress = new Uri("https://api.github.com");
        var response = await client.GetAsync("users/" + args[0] + "/events");
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
                PropertyNameCaseInsensitive = true
            };

            var events = JsonSerializer.Deserialize<GitHubResponseModel[]>(json, options);

            if (events == null)
            {
                Console.WriteLine("No events found");
                return;
            }
            
            var payloadFabric = new PayloadFabric();
            var messageService = new MessageService();
            foreach (var e in events)
            {
                var payload = payloadFabric.GetPayloadByString(e.Type, e.Payload.GetRawText(), options); // TODO: прокидывать options - плохо
                if(payload == null)
                    throw new Exception("Error parsing payload");
                var msg = messageService.GetResponse(e.Type, payload, e.CreatedAt);
                
                Console.WriteLine(msg);
            }
        }
    }
}