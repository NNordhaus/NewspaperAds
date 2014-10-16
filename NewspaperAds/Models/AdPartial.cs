using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewspaperAds.Models
{
    public partial class Ad
    {
        private int _Size;
        public int Size
        {
            get { return _Size; }
            set
            {
                var sizes = new int[]{12,8,6,4,3};
                if(!sizes.Contains(value))
                {
                    throw new ArgumentException("Must be a valid size");
                }
                _Size = value;
            }
        }
    }

    public enum AdSizes
    {
        Full = 12,
        ThreeQuarter = 8,
        Half = 6,
        Third = 4,
        Quarter = 3
    }
}