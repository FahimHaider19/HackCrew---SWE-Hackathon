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
    
    public partial class Session
    {
        public int SessionId { get; set; }
        public Nullable<int> TeacherId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<System.DateTime> SessionStart { get; set; }
        public Nullable<System.DateTime> SessionEnd { get; set; }
        public string Link { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}