//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int RequestId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> TopicId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Status { get; set; }
    
        public virtual Topic Topic { get; set; }
        public virtual User User { get; set; }
    }
}