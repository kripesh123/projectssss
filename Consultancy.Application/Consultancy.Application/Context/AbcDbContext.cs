using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Consultancy.Application.Models;

namespace Consultancy.Application.Context
{
    public class AbcDbContext:DbContext
    {
        public AbcDbContext():base("DefaultConnection")
        {

        }
        public DbSet<Consultancies> Consultancies { get; set; }

    }
}