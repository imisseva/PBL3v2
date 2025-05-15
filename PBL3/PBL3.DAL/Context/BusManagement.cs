using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using PBL3.DAL.Entities;
namespace PBL3.DAL.Context
{
    public partial class BusManagement : DbContext
    {
        public BusManagement()
            : base("name=BusManagement")
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<Bus_Location_History> Bus_Location_History { get; set; }
        public virtual DbSet<Route_SubRoute> Route_SubRoute { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Schedule_Stop> Schedule_Stop { get; set; }
        public virtual DbSet<SEAT> SEATs { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasOptional(e => e.Admin)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Account>()
                .HasOptional(e => e.Staff)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Route>()
                .Property(e => e.distance)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Schedule>()
                .Property(e => e.ID_Schedule)
                .IsUnicode(false);

            

            modelBuilder.Entity<Schedule>()
                .HasMany(e => e.Schedule_Stop)
                .WithRequired(e => e.Schedule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Schedule_Stop>()
                .Property(e => e.ID_Schedule)
                .IsUnicode(false);

            modelBuilder.Entity<SEAT>()
                .Property(e => e.ID_seat)
                .IsUnicode(false);

            modelBuilder.Entity<SEAT>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.SEAT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Station>()
                .HasMany(e => e.Bus_Location_History)
                .WithRequired(e => e.Station)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Station>()
                .HasMany(e => e.Routes)
                .WithRequired(e => e.Station)
                .HasForeignKey(e => e.ID_Station_end)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Station>()
                .HasMany(e => e.Routes1)
                .WithRequired(e => e.Station1)
                .HasForeignKey(e => e.ID_Station_start)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Station>()
                .HasMany(e => e.Schedule_Stop)
                .WithRequired(e => e.Station)
                .HasForeignKey(e => e.IDStation_stop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Station>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Station)
                .HasForeignKey(e => e.ID_Station_end)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Station>()
                .HasMany(e => e.Tickets1)
                .WithRequired(e => e.Station1)
                .HasForeignKey(e => e.ID_Station_start)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.ID_Schedule)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.ID_seat)
                .IsUnicode(false);
        }
    }
}
