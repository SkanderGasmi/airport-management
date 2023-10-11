using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class FlowerConfiguration : IEntityTypeConfiguration<Flower>
    {
        public void Configure(EntityTypeBuilder<Flower> builder)
        {
   
            //One To Many
            builder.HasOne(f => f.Bouquet)
                .WithMany(p => p.Flowers)
                .HasForeignKey(f => f.BouquetFK)
                .OnDelete(DeleteBehavior.ClientSetNull); //The values of foreign key properties in dependent entities are set to null when the related principal is deleted


           // builder.HasDiscriminator<string>("IsTraveller")
            //         .HasValue<Passenger>("0")
            //         .HasValue<Traveller>("1")
            //         .HasValue<Staff>("2");
        }
    }
}
