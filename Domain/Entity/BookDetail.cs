﻿using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class BookDetail: BaseEntity<Guid>
    {
        public DateTime ReleaseYear { get; set; }
        public int Pages { get; set; }
        public string ISBN { get; set; }
        public string Country { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
    }
}
