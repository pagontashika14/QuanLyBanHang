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
    
    public partial class DM_LOAI_TAI_KHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_LOAI_TAI_KHOAN()
        {
            this.DM_TAI_KHOAN = new HashSet<DM_TAI_KHOAN>();
        }
    
        public decimal ID { get; set; }
        public string MA_LOAI { get; set; }
        public string TEN_LOAI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_TAI_KHOAN> DM_TAI_KHOAN { get; set; }
    }
}
