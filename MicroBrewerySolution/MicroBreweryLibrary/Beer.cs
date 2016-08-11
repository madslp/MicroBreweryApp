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
    
    public partial class Beer
    {
        public Beer()
        {
            this.BeerRatings = new HashSet<BeerRating>();
        }
    
        public int Id { get; set; }
        public Nullable<double> AlcoholPercentage { get; set; }
        public string BeerDescription { get; set; }
        public int BrewedById { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
        public int BeerTypeId { get; set; }
        public Nullable<int> TotalRatingValue { get; set; }
        public Nullable<int> RatingCount { get; set; }
    
        public virtual ICollection<BeerRating> BeerRatings { get; set; }
        public virtual Beertype Beertype { get; set; }
        public virtual MicroBrewery MicroBrewery { get; set; }
    }
}