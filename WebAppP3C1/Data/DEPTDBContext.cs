using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppP3C1.Models;

namespace WebAppP3C1.Data
{
    public class DEPTDBContext : DbContext
    {
        public DEPTDBContext (DbContextOptions<DEPTDBContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppP3C1.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<WebAppP3C1.Models.EmpProfiles>? EmpProfiles { get; set; }
    }
}
