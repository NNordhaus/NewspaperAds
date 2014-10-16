using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewspaperAds.Models
{
    public partial class Issue
    {
        public Issue(DateTime deadline)
        {
            Deadline = deadline;
        }

        private DateTime _Deadline;

        public DateTime Deadline
        {
            get { return _Deadline; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("Deadline must be in the future");
                }
                _Deadline = value;
            }
        }

        private int _AdPages;
        public int AdPages
        {
            get { return _AdPages; }
            set
            {
                if (value < _AdPages)
                {
                    throw new ArgumentException("Number of available ad pages must be positive");
                }
                _AdPages = value;
            }
        }

        public void AddAd(Ad ad)
        {
            var fill = Allocations.Sum(a => a.Ad.Size);
            if (_AdPages * 12  + ad.Size > fill)
            {
                throw new ArgumentException("Issue doesnt have enough room for an ad that size");
            }
            Allocations.Add(new Allocation() { IssueID = this.ID, Issue = this, Ad = ad, AdID = ad.ID });
        }
    }
}