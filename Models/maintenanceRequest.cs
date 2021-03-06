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
    
    public partial class maintenanceRequest
    {
        public maintenanceRequest()
        {
            this.maintenanceInvoices = new HashSet<maintenanceInvoice>();
        }
    
        public long maintenanceRequestId { get; set; }
        public Nullable<System.DateTime> requestDate { get; set; }
        public Nullable<int> maintenanceTypeId { get; set; }
        public string requestedBy { get; set; }
        public string contactNumber { get; set; }
        public Nullable<long> housingUnitId { get; set; }
        public Nullable<bool> reported { get; set; }
        public Nullable<System.DateTime> reportingDate { get; set; }
        public string reportedTo { get; set; }
        public Nullable<bool> resolved { get; set; }
        public Nullable<System.DateTime> resolveDate { get; set; }
        public string resolvedBy { get; set; }
        public string problemDescription { get; set; }
        public string resolutionDescription { get; set; }
        public Nullable<bool> active { get; set; }
    
        public virtual housingUnit housingUnit { get; set; }
        public virtual ICollection<maintenanceInvoice> maintenanceInvoices { get; set; }
        public virtual maintenanceType maintenanceType { get; set; }
    }
}
