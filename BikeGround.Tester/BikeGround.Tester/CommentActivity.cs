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
    
    public partial class CommentActivity
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public long CommentID { get; set; }
        public int ProfileActivityID { get; set; }
        public int PositiveComment { get; set; }
        public int NegativeComment { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual ProfileActivity ProfileActivity { get; set; }
    }
}
