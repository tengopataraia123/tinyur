using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Domain;

namespace UrlShortener.Persistence
{
    public class UrlConfiguration : IEntityTypeConfiguration<Url>
    {
        public void Configure(EntityTypeBuilder<Url> builder)
        {
            builder.ToTable(nameof(Url));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DestinationUrl).IsRequired().HasMaxLength(512).IsUnicode();
        }
    }
}
