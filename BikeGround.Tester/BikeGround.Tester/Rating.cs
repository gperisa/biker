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
    
    public partial class Rating
    {
        public Rating()
        {
            this.RouteRating = new HashSet<RouteRating>();
            this.UserEquipment = new HashSet<UserEquipment>();
        }
    
        public int ID { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    
        public virtual ICollection<RouteRating> RouteRating { get; set; }
        public virtual ICollection<UserEquipment> UserEquipment { get; set; }
    }
}
