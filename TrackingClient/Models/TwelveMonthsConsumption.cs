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
    
    public partial class TwelveMonthsConsumption
    {
        public long ClientID { get; set; }
        public short Year { get; set; }
        public int January { get; set; }
        public decimal JanuaryMoney { get; set; }
        public int February { get; set; }
        public decimal FebruaryMoney { get; set; }
        public int March { get; set; }
        public decimal MarchMoney { get; set; }
        public int April { get; set; }
        public decimal AprilMoney { get; set; }
        public int May { get; set; }
        public decimal MayMoney { get; set; }
        public int June { get; set; }
        public decimal JuneMoney { get; set; }
        public int July { get; set; }
        public decimal JulyMoney { get; set; }
        public int August { get; set; }
        public decimal AugustMoney { get; set; }
        public int September { get; set; }
        public decimal SeptemberMoney { get; set; }
        public int October { get; set; }
        public decimal OctoberMoney { get; set; }
        public int November { get; set; }
        public decimal NovemberMoney { get; set; }
        public int December { get; set; }
        public decimal DecemberMoney { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
