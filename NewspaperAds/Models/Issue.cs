//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewspaperAds.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Issue
    {
        public Issue()
        {
            this.Allocations = new HashSet<Allocation>();
        }
    
        public int ID { get; set; }
        public int PaperID { get; set; }
    
        public virtual ICollection<Allocation> Allocations { get; set; }
        public virtual Paper Paper { get; set; }
    }
}