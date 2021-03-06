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
    
    public partial class ControlOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ControlOrder()
        {
            this.ControlCommands = new HashSet<ControlCommand>();
        }
    
        public int ID { get; set; }
        public long ControlOrderNumber { get; set; }
        public long ClientID { get; set; }
        public System.DateTime IssueDate { get; set; }
        public int UserID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlCommand> ControlCommands { get; set; }
    }
}
