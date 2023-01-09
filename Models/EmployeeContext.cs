using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace MatrixCRUD.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext( DbContextOptions<EmployeeContext> options) : base(options)      
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
