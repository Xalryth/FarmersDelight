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

namespace FarmersDelight
{
    public class FarmContext : DbContext
    {
        public FarmContext()
        {
        }

        public FarmContext(DbContextOptions options) : base(options)
        {

        }

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
    }
}