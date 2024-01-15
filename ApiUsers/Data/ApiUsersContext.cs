using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiUsers.Domain.Model;

namespace ApiUsers.Data
{
    public class ApiUsersContext : DbContext
    {
        public ApiUsersContext (DbContextOptions<ApiUsersContext> options)
            : base(options)
        {
        }

        public DbSet<ApiUsers.Domain.Model.Users> Users { get; set; } = default!;
    }
}
