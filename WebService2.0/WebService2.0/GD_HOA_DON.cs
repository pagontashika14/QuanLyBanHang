//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService2._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class GD_HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GD_HOA_DON()
        {
            this.GD_HOA_DON_CHI_TIET = new HashSet<GD_HOA_DON_CHI_TIET>();
        }
    
        public decimal ID { get; set; }
        public string MA_HOA_DON { get; set; }
        public decimal ID_CUA_HANG { get; set; }
        public System.DateTime THOI_GIAN_TAO { get; set; }
        public Nullable<decimal> ID_TAI_KHOAN { get; set; }
        public string LOAI_THANH_TOAN { get; set; }
    
        public virtual DM_CUA_HANG DM_CUA_HANG { get; set; }
        public virtual DM_TAI_KHOAN DM_TAI_KHOAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GD_HOA_DON_CHI_TIET> GD_HOA_DON_CHI_TIET { get; set; }
    }
}
