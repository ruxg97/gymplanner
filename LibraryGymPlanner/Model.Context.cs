﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryGymPlanner
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Gym_PlannerEntities : DbContext
    {
        public Gym_PlannerEntities()
            : base("name=Gym_PlannerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Вправи> Вправи { get; set; }
        public virtual DbSet<Групи_м_язів> Групи_м_язів { get; set; }
        public virtual DbSet<Дні> Дні { get; set; }
        public virtual DbSet<Користувачі> Користувачі { get; set; }
        public virtual DbSet<Підходи> Підходи { get; set; }
        public virtual DbSet<Тренування> Тренування { get; set; }
    }
}
