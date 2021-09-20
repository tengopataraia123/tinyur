using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.Domain;

namespace UrlShortener.Data.EF
{
    public interface IUrlRepository
    {
        Task<Url> GetAsync(int id);
        Task<int> AddAscync(Url url);
        Task<List<Url>> GetAllAsync();
    }
}
