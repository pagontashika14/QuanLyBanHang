﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TKHTQuanLyBanHangEntities : DbContext
    {
        public TKHTQuanLyBanHangEntities()
            : base("name=TKHTQuanLyBanHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DM_CUA_HANG> DM_CUA_HANG { get; set; }
        public virtual DbSet<DM_HANG_HOA> DM_HANG_HOA { get; set; }
        public virtual DbSet<DM_KHACH_HANG> DM_KHACH_HANG { get; set; }
        public virtual DbSet<DM_LINK_ANH> DM_LINK_ANH { get; set; }
        public virtual DbSet<DM_LOAI_TAG> DM_LOAI_TAG { get; set; }
        public virtual DbSet<DM_LOAI_TAI_KHOAN> DM_LOAI_TAI_KHOAN { get; set; }
        public virtual DbSet<DM_NHA_CUNG_CAP> DM_NHA_CUNG_CAP { get; set; }
        public virtual DbSet<DM_QUYEN> DM_QUYEN { get; set; }
        public virtual DbSet<DM_QUYEN_CHI_TIET> DM_QUYEN_CHI_TIET { get; set; }
        public virtual DbSet<DM_TAI_KHOAN> DM_TAI_KHOAN { get; set; }
        public virtual DbSet<GD_CLICK_HANG_HOA> GD_CLICK_HANG_HOA { get; set; }
        public virtual DbSet<GD_DANH_GIA> GD_DANH_GIA { get; set; }
        public virtual DbSet<GD_GIA> GD_GIA { get; set; }
        public virtual DbSet<GD_HANG_HOA_TAG> GD_HANG_HOA_TAG { get; set; }
        public virtual DbSet<GD_HOA_DON> GD_HOA_DON { get; set; }
        public virtual DbSet<GD_HOA_DON_CHI_TIET> GD_HOA_DON_CHI_TIET { get; set; }
        public virtual DbSet<GD_KHUYEN_MAI> GD_KHUYEN_MAI { get; set; }
        public virtual DbSet<GD_KHUYEN_MAI_CHI_TIET> GD_KHUYEN_MAI_CHI_TIET { get; set; }
        public virtual DbSet<GD_NHAN_XET> GD_NHAN_XET { get; set; }
        public virtual DbSet<GD_PHIEU_NHAP_XUAT> GD_PHIEU_NHAP_XUAT { get; set; }
        public virtual DbSet<GD_PHIEU_NHAP_XUAT_CHI_TIET> GD_PHIEU_NHAP_XUAT_CHI_TIET { get; set; }
        public virtual DbSet<GD_SAN_PHAM_UA_THICH> GD_SAN_PHAM_UA_THICH { get; set; }
        public virtual DbSet<GD_TAG> GD_TAG { get; set; }
        public virtual DbSet<GD_TAG_CHI_TIET> GD_TAG_CHI_TIET { get; set; }
        public virtual DbSet<GD_TON_KHO> GD_TON_KHO { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
