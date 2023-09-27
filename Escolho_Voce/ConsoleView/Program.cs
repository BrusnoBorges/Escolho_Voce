using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escolho_Voce.Controller;
using Escolho_Voce.Models;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(GetPokemon());
        Console.ReadLine();
    }

    private static readonly IRestService _restService;

    //public MainPage(IRestService restService)
    //{
    //    IServiceCollection services = new ServiceCollection();
    //    services.AddTransient<IRestService, RestService>();
    //    var serviceProvider = services.BuildServiceProvider();

    //}

    private static async Task<string> GetPokemon()
    {
        Pokemon pokemon = await _restService.GetPokemon(url(1));

        return pokemon.name;
    }
    public static string url(int id)
    {
        Constants constants = new Constants();
        return constants.PokeApiEndPointPokemon + id.ToString();
    }

}