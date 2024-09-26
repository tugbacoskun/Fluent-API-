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
    public class BookCategoryConfiguration : CostumConfiguration<BookCategory, Guid>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasOne(x => x.Book).WithMany(x=>x.BookCategories).HasForeignKey(x=>x.BookId);
            builder.HasOne(x=>x.Category).WithMany(x=>x.BookCategories).HasForeignKey(x=>x.CategoryId);
        }
    }
}
