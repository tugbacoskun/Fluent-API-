using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Book: BaseEntity<Guid>
    {
        public string Name { get; set; }
        
        public Guid AuthorId { get; set; }
        public BookDetail BookDetail { get; set; }
        public Author Author { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
