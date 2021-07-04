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

    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.PHANCAs = new HashSet<PHANCA>();
        }
    
        public int MaNV { get; set; }
        [Required(ErrorMessage ="Không thể bỏ trống!")]
        public string TenNV { get; set; }
        [Required(ErrorMessage = "Không thể bỏ trống!")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Không thể bỏ trống!")]

        public int Tuoi { get; set; }
        [Required(ErrorMessage = "Không thể bỏ trống!")]
        public string ChucVu { get; set; }
        [Required(ErrorMessage = "Không thể bỏ trống!")]

        public string SDT { get; set; }
        [Required(ErrorMessage = "Không thể bỏ trống!")]

        public string DiaChi { get; set; }
        [Required(ErrorMessage = "Không thể bỏ trống!")]

        public Nullable<int> MaCN { get; set; }

        public int Luong { get; set; }
        [Required(ErrorMessage = "Không thể bỏ trống!")]


        public virtual CHINHANH CHINHANH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCA> PHANCAs { get; set; }
        public virtual TAIKHOANNV TAIKHOANNV { get; set; }
    }
}
