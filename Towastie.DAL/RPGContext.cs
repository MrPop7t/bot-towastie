using Towastie.DAL.Models.Items;
using Towastie.DAL.Models.Profiles;
using Microsoft.EntityFrameworkCore;

namespace Towastie.DAL
{
    public class RPGContext : DbContext
    {
        public RPGContext(DbContextOptions<RPGContext> options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ProfileItem> ProfileItems { get; set; }
    }
}