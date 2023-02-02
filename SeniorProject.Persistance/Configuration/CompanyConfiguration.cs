using Microsoft.EntityFrameworkCore;
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
    public sealed class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable(TableNames.Companies);
            builder.HasKey(p=>p.Id);
            //builder.Property(p => p.OrderStartTime).HasColumnType("time(7)");
            //builder.Property(p => p.OrderFinishTime).HasColumnType("time(7)");
        }
    }
}
