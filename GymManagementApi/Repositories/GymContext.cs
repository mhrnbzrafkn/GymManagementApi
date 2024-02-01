using Microsoft.EntityFrameworkCore;

namespace KalCulate.Api.Repositories
{
    public class GymContext : DbContext
    {
        public GymContext() : this(new DbContextOptionsBuilder<GymContext>()
            .UseSqlServer("server=.;database=Gym;trusted_connection=true;").Options)
        {
        }

        private GymContext(DbContextOptions<GymContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GymContext).Assembly);
        }
    }
}
