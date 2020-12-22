//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoanquanlysachV3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    [MetadataType(typeof(Models.CSach))]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            this.PHIEUMUONs = new HashSet<PHIEUMUON>();
            this.TACGIAs = new HashSet<TACGIA>();
        }
    
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string MaTheLoai { get; set; }
        public string MaNhaXuatBan { get; set; }
    
        public virtual NHAXUATBAN NHAXUATBAN { get; set; }
        public virtual THELOAI THELOAI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUON> PHIEUMUONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TACGIA> TACGIAs { get; set; }
    }
}
