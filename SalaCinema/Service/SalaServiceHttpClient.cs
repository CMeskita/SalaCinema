using Newtonsoft.Json;
using SalaCinema.Models;

namespace SalaCinema.Service
{
    public class SalaServiceHttpClient: ISalaServiceHttpClient
    {
        private string _endpont = "https://localhost:7183/api/v1";

   

        private readonly HttpClient _client;

        public SalaServiceHttpClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<SalaDto>> GetSalasAsync()
        {
            try
            {
                var response= _client.GetStringAsync($"{_endpont}/Room/All").Result;
                List<SalaDto> salas = JsonConvert.DeserializeObject<List<SalaDto>>(response);
                
                return salas;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task CadastrarSala() 
        {
        }
        public async Task AlterarSala()
        {
        }

    }
}
