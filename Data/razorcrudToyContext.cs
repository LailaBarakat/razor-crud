using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razor_crud.Models;

    public class razorcrudToyContext : DbContext
    {
        public razorcrudToyContext (DbContextOptions<razorcrudToyContext> options)
            : base(options)
        {
        }

        public DbSet<razor_crud.Models.Toy> Toy { get; set; }
    }
