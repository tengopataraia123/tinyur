using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.Data.EF;
using UrlShortener.Domain;
using UrlShortener.Services.Abstractions;

namespace UrlShortener.Services.Implementations
{
    public class UrlService : IUrlsService
    {
        private IUrlRepository _repo;

        public UrlService(IUrlRepository repo)
        {
            _repo = repo;
        }

        public async Task<int> AddAsync(Url url)
        {
            return await _repo.AddAscync(url);
        }

        public async Task<List<Url>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Url> GetAsync(int id)
        {
            return await _repo.GetAsync(id);
        }
    }
}
