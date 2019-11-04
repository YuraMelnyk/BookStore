﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Abstract;

namespace Domain.Concrete
{
    public class EFBookRepository : IBookRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Book> Books
        {
            get { return context.Books; }
        }
    }
}
