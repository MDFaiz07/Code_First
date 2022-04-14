using Code_First.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_First.F_Db
{
    public class FDbContext: DbContext
    {
        public FDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<CF_Model> Emp_Table { get; set; }

    }
}
