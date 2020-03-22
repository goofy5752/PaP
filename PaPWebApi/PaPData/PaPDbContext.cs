using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PaPData.Models;

namespace PaPData
{
    public class PaPDbContext : IdentityDbContext<PaPUser, IdentityRole, string>
    {
        // ReSharper disable once SuggestBaseTypeForParameter
        public PaPDbContext(DbContextOptions<PaPDbContext> options)
            : base(options) { }

        public DbSet<PaPUser> PaPUsers { get; set; }
    }
}
