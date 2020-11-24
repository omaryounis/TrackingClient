﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PSMMSDBEntities : DbContext
    {
        public PSMMSDBEntities() 
          : base("name=PSMMSDBEntities")
        {

        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Alarm> Alarms { get; set; }
        public virtual DbSet<ControlCommand> ControlCommands { get; set; }
        public virtual DbSet<ControlOrder> ControlOrders { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DailyConsumption> DailyConsumptions { get; set; }
        public virtual DbSet<HistoricalDailyConsumption> HistoricalDailyConsumptions { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<MeterRead> MeterReads { get; set; }
        public virtual DbSet<MeterType> MeterTypes { get; set; }
        public virtual DbSet<PendingCharge> PendingCharges { get; set; }
        public virtual DbSet<PendingClient> PendingClients { get; set; }
        public virtual DbSet<PricePlan> PricePlans { get; set; }
        public virtual DbSet<RemovedDailyConsumption> RemovedDailyConsumptions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TariffsPrice> TariffsPrices { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TwelveMonthsConsumption> TwelveMonthsConsumptions { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}