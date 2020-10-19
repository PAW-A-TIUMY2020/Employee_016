using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 1017pertemuan2.Models
{
    public class EmployeeContext
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) :
       base(options)
        { }
        public DbSet<Employees> Employees { get; set; }
    }
}
}
