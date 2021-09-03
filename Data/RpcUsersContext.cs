using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rpc.Models;

namespace RpcUsers.Data
{
    public class RpcUsersContext : DbContext
    {
        public RpcUsersContext (DbContextOptions<RpcUsersContext> options)
            : base(options)
        {
        }

        public DbSet<Rpc.Models.User> User { get; set; }
    }
}
