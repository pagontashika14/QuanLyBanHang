//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_TAI_KHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_TAI_KHOAN()
        {
            this.DM_KHACH_HANG = new HashSet<DM_KHACH_HANG>();
            this.DM_QUYEN_CHI_TIET = new HashSet<DM_QUYEN_CHI_TIET>();
            this.GD_CLICK_HANG_HOA = new HashSet<GD_CLICK_HANG_HOA>();
            this.GD_DANH_GIA = new HashSet<GD_DANH_GIA>();
            this.GD_HOA_DON = new HashSet<GD_HOA_DON>();
            this.GD_NHAN_XET = new HashSet<GD_NHAN_XET>();
            this.GD_PHIEU_NHAP_XUAT = new HashSet<GD_PHIEU_NHAP_XUAT>();
            this.GD_SAN_PHAM_UA_THICH = new HashSet<GD_SAN_PHAM_UA_THICH>();
        }
    
        public decimal ID { get; set; }
        public string TEN_TAI_KHOAN { get; set; }
        public string MAT_KHAU { get; set; }
        public string HO_DEM { get; set; }
        public string TEN { get; set; }
        public string EMAIL { get; set; }
        public decimal ID_LOAI_TAI_KHOAN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_KHACH_HANG> DM_KHACH_HANG { get; set; }
        public virtual DM_LOAI_TAI_KHOAN DM_LOAI_TAI_KHOAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_QUYEN_CHI_TIET> DM_QUYEN_CHI_TIET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GD_CLICK_HANG_HOA> GD_CLICK_HANG_HOA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GD_DANH_GIA> GD_DANH_GIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GD_HOA_DON> GD_HOA_DON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GD_NHAN_XET> GD_NHAN_XET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GD_PHIEU_NHAP_XUAT> GD_PHIEU_NHAP_XUAT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GD_SAN_PHAM_UA_THICH> GD_SAN_PHAM_UA_THICH { get; set; }
    }
}
