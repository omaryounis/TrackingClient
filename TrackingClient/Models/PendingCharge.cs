//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrackingClient.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PendingCharge
    {
        public int ID { get; set; }
        public string Data { get; set; }
        public int Issued { get; set; }
        public System.DateTime IssueDate { get; set; }
        public int UserID { get; set; }
        public long Client_ID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual InvoiceDetail InvoiceDetail { get; set; }
        public virtual User User { get; set; }
    }
}
