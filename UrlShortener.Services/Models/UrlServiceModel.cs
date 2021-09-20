using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortener.Services.Models
{
    public class UrlServiceModel
    {
        public int Id { get; set; }
        public string DestinationUrl { get; set; }
    }
}
