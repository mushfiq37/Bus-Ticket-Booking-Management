using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticket_Booking.Models
{
    public class BinderModel: DbContext
    {
        public DbSet<TripsModel> trips { get; set; }

        public DbSet<CoachModel> coach { get; set; }

        public DbSet<LocationModel> location { get; set; }

        public DbSet<BookingModel> booking { get; set; }

        public DbSet<PassengerModel> passenger { get; set; }

        public DbSet<BookingList> bookingList { get; set; }


        public DbSet<RegisterModel> register { get; set; }

        public DbSet<CounterModel> counter { get; set; }

        public DbSet<DestinationModel> destination { get; set; }

        public BinderModel()
            :base("name=TicketBookingDB")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

        }
        
    }
    public class DbInit
    {
        public void CreateDatabase()
        {
            Database.SetInitializer<BinderModel>(null);
        }
    }

 
}

public class global
{
    public static Int32 logged = 0;
    public static String starting;
    public static String destination;
}