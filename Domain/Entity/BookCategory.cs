using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class BookCategory: BaseEntity<Guid>
    {
        public Guid CategoryId { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public Category Category { get; set; }
    }
}
