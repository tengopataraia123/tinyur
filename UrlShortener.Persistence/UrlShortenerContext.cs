using Microsoft.EntityFrameworkCore;
using System;
using UrlShortener.Domain;

namespace UrlShortener.Persistence
{
    public class UrlShortenerContext : DbContext
    {
        private readonly string _connectionString;

        public UrlShortenerContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public UrlShortenerContext(DbContextOptions<UrlShortenerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UrlShortenerContext).Assembly);
        }

        public DbSet<Url> Urls { get; set; }
    }
}
