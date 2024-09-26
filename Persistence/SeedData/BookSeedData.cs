using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData
{
    public class BookSeedData : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            //builder.HasData(
            //    new Book
            //    {
            //        Name = "Çalıkuşu",
            //        BookDetail = new BookDetail
            //        {
            //            Pages = 20,
            //            ISBN = "frfe",
            //            Country = "İzmir"
            //        }
            //    });
        }
    }
}
