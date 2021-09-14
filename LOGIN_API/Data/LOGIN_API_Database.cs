using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LOGIN_API.Models;

namespace LOGIN_API.Data
{
    public class LOGIN_API_Database : DbContext
    {
        public LOGIN_API_Database (DbContextOptions<LOGIN_API_Database> options)
            : base(options)
        {
        }

        public DbSet<LOGIN_API.Models.Login> Login { get; set; }
    }
}
