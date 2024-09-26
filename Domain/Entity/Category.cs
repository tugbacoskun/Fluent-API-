using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Category: BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
