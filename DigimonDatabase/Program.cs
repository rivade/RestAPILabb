using RestSharp;
using System;
using System.Text.Json;
using DigimonFacts;

RestClient client = new RestClient("https://digimon-api.com");

Console.WriteLine("Write the name of a Digimon to get its ID, or write the ID to get its name");
string input = Console.ReadLine();

string requestUrl = $"/api/v1/digimon/{input}";
RestRequest request = new RestRequest(requestUrl);
RestResponse response = client.Get(request);

if (response.IsSuccessful)
{
    Digimon digimon = JsonSerializer.Deserialize<Digimon>(response.Content);

    if (!int.TryParse(input, out int _))
    {
        Console.WriteLine($"Digimon ID: {digimon.Id}");
    }
   
    else
    {
        Console.WriteLine($"Digimon Name: {digimon.Name}");
    }
}
else
{
    Console.WriteLine($"Error: {response.StatusCode}");
}

Console.ReadLine();