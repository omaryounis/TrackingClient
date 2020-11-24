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
    
    public partial class MeterRead
    {
        public long ID { get; set; }
        public long ClientID { get; set; }
        public int UserID { get; set; }
        public long TotalConsumption { get; set; }
        public long CurrentMonthlyConsumption { get; set; }
        public decimal CurrentsliceConsumption { get; set; }
        public decimal TotalBalance { get; set; }
        public decimal RemainMoney { get; set; }
        public int OpenTrials { get; set; }
        public string Battery { get; set; }
        public int EarthFrauds { get; set; }
        public long Cardreads { get; set; }
        public System.DateTime SaveReadDate { get; set; }
        public decimal Overload { get; set; }
        public int RemainKW { get; set; }
        public int SliceNo { get; set; }
        public int Consum1 { get; set; }
        public int Consum2 { get; set; }
        public int Consum3 { get; set; }
        public int Consum4 { get; set; }
        public int Consum5 { get; set; }
        public int Consum6 { get; set; }
        public int Consum7 { get; set; }
        public int Consum8 { get; set; }
        public int Consum9 { get; set; }
        public int Consum10 { get; set; }
        public int Consum11 { get; set; }
        public int Consum12 { get; set; }
        public int MeterState { get; set; }
        public int ChargeCount { get; set; }
        public int RemainInDays { get; set; }
        public System.DateTime MeterReadDate { get; set; }
        public int EarthFraudDuration { get; set; }
        public int AvergeDailyConsum { get; set; }
        public long PrevMonthConsum { get; set; }
        public System.DateTime OpenCoverDate { get; set; }
        public decimal PowerFactor { get; set; }
        public decimal DebitsInMeter { get; set; }
        public int ControlCardId1 { get; set; }
        public int ControlCardId2 { get; set; }
        public int ControlCardId3 { get; set; }
        public decimal SumOfAllCharges { get; set; }
        public int PH1_Failure { get; set; }
        public int PH1_Duration { get; set; }
        public int PH2_Failure { get; set; }
        public int PH2_Duration { get; set; }
        public int PH3_Failure { get; set; }
        public int PH3_Duration { get; set; }
        public int Meter_Failure { get; set; }
        public int TotalConsumVAR { get; set; }
        public int CurrMonthConsumVAR { get; set; }
        public int PreviousMonthConsumVAR { get; set; }
        public int OpenKiloWatt { get; set; }
        public int DebitConsum { get; set; }
        public decimal DebitsInMeterPrevious { get; set; }
        public decimal MaxLoadKw { get; set; }
        public decimal MaxLoadAm { get; set; }
        public int MeterReadSource { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
    }
}
