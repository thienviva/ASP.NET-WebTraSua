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
    
    public partial class GIAOHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAOHANG()
        {
            this.GIOHANGs = new HashSet<GIOHANG>();
        }
    
        public string MaGH { get; set; }
        public Nullable<int> MaHD { get; set; }
        public string DiaChiGiao { get; set; }
        public Nullable<int> MaKH { get; set; }
        public string PhuongThucGiao { get; set; }
        public string KieuThanhToan { get; set; }
        public string BenChuyenPhat { get; set; }
        public Nullable<int> MaKHLA { get; set; }
    
        public virtual HOADON HOADON { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIOHANG> GIOHANGs { get; set; }
        public virtual KHACHHANGLA KHACHHANGLA { get; set; }
    }
}
