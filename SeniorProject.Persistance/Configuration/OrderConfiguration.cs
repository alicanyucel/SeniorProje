﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeniorProject.Domain.Entities;
using SeniorProject.Persistance.Constans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorProject.Persistance.Configuration
{
    public sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {

            builder.ToTable(TableNames.Orders);
            builder.HasKey(p => p.Id);

            builder
                .HasOne(p => p.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(p => p.ProductId);
        }
    }
}
