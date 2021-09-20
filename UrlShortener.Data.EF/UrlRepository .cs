using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UrlShortener.Domain;

namespace UrlShortener.Data.EF
{
    public class UrlRepository : IUrlRepository
    {
        readonly DbContext _context;
        readonly DbSet<Url> _dbSet;

        public UrlRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Url>();
        }

        public async Task<int> AddAscync(Url url)
        {
            await _dbSet.AddAsync(url);
            await _context.SaveChangesAsync();
            return url.Id;
        }

        public async Task<List<Url>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Url> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
    }
}
