//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BikeGround.Tester
{
    using System;
    using System.Collections.Generic;
    
    public partial class RouteRating
    {
        public long ID { get; set; }
        public string UserID { get; set; }
        public long RouteID { get; set; }
        public int RatingID { get; set; }
        public string Comment { get; set; }
        public System.DateTime DateAdded { get; set; }
        public bool Active { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual Route Route { get; set; }
    }
}
