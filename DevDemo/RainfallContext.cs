using System.Data.Entity;
using System.Data.Entity.Infrastructure;
namespace WindowsFormsApplication1
{
	public class RainfallContext : DbContext
	{
		public RainfallContext():base("name=DefaultConnection")
		{
		}
		public DbSet<Rainfall> Rainfalls  {get;set;}
        public DbSet<City> Ctiys { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer<RainfallContext>(null);
			modelBuilder.Configurations.Add(new RainfallMap());
            modelBuilder.Configurations.Add(new CityMap());
            base.OnModelCreating(modelBuilder);
		}
	}
}
