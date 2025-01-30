using SalaCinema.Models;
using System.Drawing;

namespace SalaCinema.Service
{
    public interface ISalaServiceHttpClient
    {
        Task<List<SalaDto>> GetSalasAsync();
    }
}
