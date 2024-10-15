using Izzet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izzet.DataAccess.Configurations
{
    internal class ToDoConfiguration : IEntityTypeConfiguration<TodoModel>
    {
        public void Configure(EntityTypeBuilder<TodoModel> builder)
        {
            builder.Property(x=>x.OwnName).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.OwnNumber).IsRequired().HasMaxLength(30);
            builder.Property(x=>x.CustomerName).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.CustomerNumber).IsRequired().HasMaxLength(30);
            builder.Property(x=>x.HomePrice).IsRequired().HasDefaultValue<int>(0);
            builder.Property(x=>x.Kod).HasDefaultValue<int>(0);
        }
    }
}
