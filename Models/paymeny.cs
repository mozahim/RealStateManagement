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
    
    public partial class paymeny
    {
        public long paymentId { get; set; }
        public Nullable<long> contractId { get; set; }
        public Nullable<bool> collected { get; set; }
        public Nullable<System.DateTime> collectedOn { get; set; }
        public Nullable<bool> deposited { get; set; }
        public Nullable<System.DateTime> depositedOn { get; set; }
        public Nullable<bool> cleared { get; set; }
        public Nullable<System.DateTime> clearedOn { get; set; }
        public Nullable<bool> active { get; set; }
    
        public virtual contract contract { get; set; }
    }
}