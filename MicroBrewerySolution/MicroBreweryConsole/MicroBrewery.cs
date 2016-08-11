//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicroBreweryLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class MicroBrewery
    {
        public MicroBrewery()
        {
            this.Beers = new HashSet<Beer>();
            this.MicroBreweryRatings = new HashSet<MicroBreweryRating>();
        }
    
        public int Id { get; set; }
        public string MicroBreweryDescription { get; set; }
        public string Name { get; set; }
        public Nullable<int> TotalRatingValue { get; set; }
        public Nullable<int> RatingCount { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string Location { get; set; }
        public string OpeningHours { get; set; }
    
        public virtual ICollection<Beer> Beers { get; set; }
        public virtual ICollection<MicroBreweryRating> MicroBreweryRatings { get; set; }
    }
}
