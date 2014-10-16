using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewspaperAds.Models
{
    public partial class Paper
    {
        public Paper(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new FormatException("Name cannot be null, empty, or whitespace");
            }
            Name = name;
        }
    }
}