using RestSharp;

namespace MTGVault.Data;

public class ScryfallService
{
    private MtgCard? card;
    private RestClient _client;

    public Task<MtgCard?> GetRandomCard()
    {
        _client = new RestClient("https://api.scryfall.com/");
        card = _client.GetJsonAsync<MtgCard>("/cards/random").Result;

        return Task.FromResult(card);
    }
}