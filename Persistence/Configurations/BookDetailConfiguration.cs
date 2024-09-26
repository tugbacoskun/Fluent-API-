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
    public class BookDetailConfiguration : CostumConfiguration<BookDetail, Guid>
    {
        public override void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.Property(x=>x.ISBN).IsRequired().HasMaxLength(4);

            builder.HasOne(b => b.Book).WithOne(bd => bd.BookDetail).HasForeignKey<BookDetail>(bd => bd.BookId);
        }
    }
}
