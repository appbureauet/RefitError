using System;
using System.Threading.Tasks;
using Refit;

namespace RefitError.Services
{
    public interface INonsenseApi
    {
        [Get("/superapi/{meaning}")]
        Task<bool> Nonsense(string nosense);
    }
}
