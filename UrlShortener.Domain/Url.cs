using System;

namespace UrlShortener.Domain
{
    public class Url
    {
        public int Id { get; set; }
        public string DestinationUrl { get; set; }
    }
}
