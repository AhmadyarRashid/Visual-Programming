//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PreReq
    {
        public int CourseNumber { get; set; }
        public Nullable<int> PreReqNumber { get; set; }
        public int Id { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Course Course1 { get; set; }
    }
}