//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demoTMDT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int ID { get; set; }
        public string TenKH { get; set; }
        public string Email { get; set; }
        public string TenSP { get; set; }
        public string Comment1 { get; set; }
        public Nullable<int> Parent { get; set; }
        public Nullable<System.DateTime> NgayCMT { get; set; }
    }
}
