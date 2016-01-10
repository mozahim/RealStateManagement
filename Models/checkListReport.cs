//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealStateManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class checkListReport
    {
        public checkListReport()
        {
            this.checkListAssets = new HashSet<checkListAsset>();
            this.checkListReportDatas = new HashSet<checkListReportData>();
        }
    
        public long checkListReportId { get; set; }
        public Nullable<System.DateTime> reportDate { get; set; }
        public string performedBy { get; set; }
        public Nullable<bool> waterAndElectricityCleared { get; set; }
        public Nullable<bool> accepted { get; set; }
        public string description { get; set; }
        public Nullable<bool> active { get; set; }
        public Nullable<long> contractId { get; set; }
    
        public virtual ICollection<checkListAsset> checkListAssets { get; set; }
        public virtual ICollection<checkListReportData> checkListReportDatas { get; set; }
    }
}