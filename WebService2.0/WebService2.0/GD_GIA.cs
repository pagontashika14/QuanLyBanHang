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
    
    public partial class GD_GIA
    {
        public decimal ID { get; set; }
        public decimal ID_HANG_HOA { get; set; }
        public System.DateTime NGAY_LUU_HANH { get; set; }
        public decimal GIA { get; set; }
    
        public virtual DM_HANG_HOA DM_HANG_HOA { get; set; }
    }
}
