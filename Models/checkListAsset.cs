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
    
    public partial class checkListAsset
    {
        public long checkListAssetId { get; set; }
        public Nullable<long> assetId { get; set; }
        public Nullable<long> checkListReportId { get; set; }
        public string condition { get; set; }
        public string notes { get; set; }
    
        public virtual asset asset { get; set; }
        public virtual checkListReport checkListReport { get; set; }
    }
}