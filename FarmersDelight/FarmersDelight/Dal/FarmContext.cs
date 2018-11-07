using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmersDelight.Classes.Measurements;
using FarmersDelight.Classes.Farms;
using FarmersDelight.Classes.FarmBuilding;
using FarmersDelight.Classes.Sensors;
using FarmersDelight.Classes.Feed;
using FarmersDelight.Classes.Animal;
using FarmersDelight.Classes.Schedule;

namespace FarmersDelight.Dal
{
    public class FarmContext : DbContext
    {
        public FarmContext() : base()
        {
        }

        public FarmContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<Pig> pigs { get; set; }
        public DbSet<PigType> pigtypes { get; set; }
        public DbSet<TagType> tagtypes { get; set; }
        public List<Building> buildings
        {
            get
            {
                List<Building> buildings = new List<Building>();
                buildings.AddRange(pens);
                buildings.AddRange(stables);
                buildings.AddRange(silos);
                return buildings;
            }

        }
        public DbSet<Pen> pens { get; set; }
        public DbSet<Silo> silos { get; set; }
        public DbSet<Stable> stables { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<City> citys { get; set; }
        public DbSet<Country> countrys { get; set; }
        public DbSet<Farm> farms { get; set; }
        public DbSet<FeedBlend> feedblends { get; set; }
        public DbSet<FeedDistribution> feeddistributions { get; set; }
        public DbSet<FeedType> feedtypes { get; set; }
        public DbSet<Measurement> measurements { get; set; }
        public DbSet<DataCollectionSchedule> datacollectionschedules { get; set; }
        public DbSet<ScheduleElement> scheduleelements { get; set; }
        public DbSet<Sensor> sensors { get; set; }
        public DbSet<SensorType> sensortypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //populate type tables with enum data
            modelBuilder.Entity<PigType>().HasData(PigTypeEnum.Pig, PigTypeEnum.Sow, PigTypeEnum.Boar, PigTypeEnum.Piglet);
            modelBuilder.Entity<TagType>().HasData(TagTypeEnum.Red, TagTypeEnum.Green, TagTypeEnum.Grey);
            modelBuilder.Entity<FeedType>().HasData(FeedTypeEnum.Wheat, FeedTypeEnum.Peas, FeedTypeEnum.Soja, FeedTypeEnum.Barley);
            modelBuilder.Entity<SensorType>().HasData(TagTypeEnum.Red, TagTypeEnum.Green, TagTypeEnum.Grey);

            modelBuilder
                .Entity<Measurement>()
                .Property(b => b.TimeOfMeasurement)
                .HasDefaultValueSql("getdate()");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=10.108.146.4;Initial Catalog=FarmersDelight;Integrated Security=SSPI;Username=FD;Password=123Abc");
        }
    }
}