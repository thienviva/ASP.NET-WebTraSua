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

    public partial class TAIKHOANQL
    {
        public string UserName { get; set; }
        [Required(ErrorMessage = "Không thể bỏ trống!")]

        public string Pass { get; set; }
        [Required(ErrorMessage = "Không thể bỏ trống!")]

        public int MaQL { get; set; }
    
        public virtual QUANLY QUANLY { get; set; }
    }
}
