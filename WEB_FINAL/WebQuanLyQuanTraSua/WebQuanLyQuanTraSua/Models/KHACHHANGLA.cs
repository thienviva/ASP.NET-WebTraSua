//------------------------------------------------------------------------------
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
    
    public partial class KHACHHANGLA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANGLA()
        {
            this.GIAOHANGs = new HashSet<GIAOHANG>();
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public int MaKHLA { get; set; }
        
        public string HoTen { get; set; }
        public string EmailKH { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChiKH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAOHANG> GIAOHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
