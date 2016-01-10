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
    
    public partial class contract
    {
        public contract()
        {
            this.adminFees = new HashSet<adminFee>();
            this.assets = new HashSet<asset>();
            this.paymenys = new HashSet<paymeny>();
        }
    
        public long contractId { get; set; }
        public Nullable<long> housingUnitId { get; set; }
        public string contractNumber { get; set; }
        public string locationReference { get; set; }
        public Nullable<int> contractTypeId { get; set; }
        public string tenantName { get; set; }
        public string emiratesId { get; set; }
        public Nullable<System.DateTime> emiratesIdExpire { get; set; }
        public string passportNumber { get; set; }
        public Nullable<System.DateTime> passportExpire { get; set; }
        public string contactNumber1 { get; set; }
        public string contactNumber2 { get; set; }
        public string POBox { get; set; }
        public string nationality { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<decimal> rentValue { get; set; }
        public Nullable<int> NoOfPayments { get; set; }
        public Nullable<int> familyMembers { get; set; }
        public string familyMembersDescription { get; set; }
        public Nullable<decimal> insuranceDeposit { get; set; }
        public Nullable<decimal> insuranceDeduction { get; set; }
        public Nullable<decimal> insuranceRefunded { get; set; }
        public string insuranceDeductionDescription { get; set; }
        public string insuranceRefundReceivedBy { get; set; }
        public Nullable<bool> checkListReportReceived { get; set; }
        public Nullable<bool> isHolded { get; set; }
        public string holdedBy { get; set; }
        public Nullable<bool> isRenewed { get; set; }
        public Nullable<bool> isEnded { get; set; }
        public string notes { get; set; }
        public Nullable<bool> active { get; set; }
    
        public virtual ICollection<adminFee> adminFees { get; set; }
        public virtual ICollection<asset> assets { get; set; }
        public virtual contractType contractType { get; set; }
        public virtual ICollection<paymeny> paymenys { get; set; }
    }
}