using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDDOTNET6.Models;

namespace CRUDDOTNET6.Data
{
    public class CRUDDOTNET6Context : DbContext
    {
        public CRUDDOTNET6Context (DbContextOptions<CRUDDOTNET6Context> options)
            : base(options)
        {
        }

        public DbSet<CRUDDOTNET6.Models.Usuario> Usuario { get; set; } = default!;
    }
}
