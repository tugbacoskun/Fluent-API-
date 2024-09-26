using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
    public class AuthorConfiguration : CostumConfiguration<Author, Guid>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(x=>x.FirstName).IsRequired().HasMaxLength(10);
            builder.Property(x => x.DateOfBirth).IsRequired();

            builder.HasMany(x => x.Books).WithOne(x => x.Author).HasForeignKey(x => x.AuthorId);
        }
    }
}
