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
    
    public partial class DM
    {
        public long id { get; set; }
        public Nullable<System.DateTime> uploadDatetime { get; set; }
        public string uploadedBy { get; set; }
        public string systemCode { get; set; }
        public Nullable<long> systemReferenceId { get; set; }
        public string fileName { get; set; }
        public string description { get; set; }
        public byte[] fileContent { get; set; }
        public Nullable<bool> active { get; set; }
    }
}