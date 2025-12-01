using System.Text.Json;
using System.Text.Json.Serialization;
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
        // Github requires to add this headings to GET query
        client.DefaultRequestHeaders.Add("User-Agent", "RoadmapSH-Project");
        client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
    
        client.BaseAddress = new Uri("https://api.github.com");
        var response = await client.GetAsync("users/" + args[0] + "/events");
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();

            var options = ConfigService.ReadSerializerOptions;

            var events = JsonSerializer.Deserialize<GitHubResponseModel[]>(json, options);
            
            if (events == null)
            {
                Console.WriteLine("No events found");
                return;
            }
            
            foreach (var e in events)
            {
                var payload = PayloadFabric.GetPayloadByString(e.Type, e.Payload.GetRawText());
                if(payload == null)
                    throw new Exception("Error parsing payload");
                var msg = MessageService.GetResponse(e.Type, payload, e.CreatedAt);
                
                Console.WriteLine(msg);
            }
        }
    }
}