//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoneyBookAPI.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Acquaintance_Transaction
    {
        public int Id { get; set; }
        public Nullable<int> AcquaintanceId { get; set; }
        public Nullable<int> TransactionId { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<int> IsDeleted { get; set; }
    
        public virtual Acquaintance Acquaintance { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}