using Escolho_Voce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escolho_Voce.Controller
{
    public interface IRestService
    {   
        Task<Pokemon> GetPokemon(string query);
    }
}
