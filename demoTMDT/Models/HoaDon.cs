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
    
    public partial class HoaDon
    {
        public int IdHoaDon { get; set; }
        public Nullable<int> IdPM { get; set; }
        public string TenKH { get; set; }
        public Nullable<int> IdDT { get; set; }
        public string TenDT { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> Gia { get; set; }
        public string SĐT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
    
        public virtual DienThoai DienThoai { get; set; }
        public virtual PhieuMua PhieuMua { get; set; }
    }
}
