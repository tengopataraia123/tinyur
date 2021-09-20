using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.Domain;

namespace UrlShortener.Services.Abstractions
{
    public interface IUrlsService
    {
        Task<List<Url>> GetAllAsync();
        Task<Url> GetAsync(int id);
        Task<int> AddAsync(Url url);
    }
}
