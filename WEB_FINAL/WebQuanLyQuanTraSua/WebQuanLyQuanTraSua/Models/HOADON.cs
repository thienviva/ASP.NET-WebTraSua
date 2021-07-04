﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebQuanLyQuanTraSua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.CHITIETHDs = new HashSet<CHITIETHD>();
            this.GIAOHANGs = new HashSet<GIAOHANG>();
            this.GIOHANGs = new HashSet<GIOHANG>();
        }
    
        public int MaHD { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<int> MaCN { get; set; }
        public System.DateTime NgayXuatHD { get; set; }
        public int TongGia { get; set; }
        public string TinhTrangHD { get; set; }
        public Nullable<int> MaKHLA { get; set; }
    
        public virtual CHINHANH CHINHANH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHD> CHITIETHDs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAOHANG> GIAOHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIOHANG> GIOHANGs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual KHACHHANGLA KHACHHANGLA { get; set; }
    }
}
