using System.Text.Json;

namespace Github_User_Activity.Models;

public record GitHubResponseModel 
(
    string Type,
    JsonElement Payload,
    DateTime CreatedAt
);