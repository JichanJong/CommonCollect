using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication1
{
	public class CityMap : EntityTypeConfiguration<City>
	{
		public CityMap()
		{
			ToTable("City");
			HasKey(m => m.Id);
			Property(m => m.Name).HasMaxLength(100);
			Property(m => m.ParentId);
            HasMany(m => m.Childs).WithOptional(m => m.Parent).HasForeignKey(m => m.ParentId);
		}
	}
}
