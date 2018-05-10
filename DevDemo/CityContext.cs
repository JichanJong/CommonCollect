using System.Data.Entity;
using System.Data.Entity.Infrastructure;
namespace WindowsFormsApplication1
{
	public class CityContext : DbContext
	{
		public CityContext():base("name=DefaultConnection")
		{
		}
		public DbSet<City> Citys  {get;set;}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer<CityContext>(null);
			modelBuilder.Configurations.Add(new CityMap());
			base.OnModelCreating(modelBuilder);
		}
	}
}
