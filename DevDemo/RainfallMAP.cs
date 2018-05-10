using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication1
{
	public class RainfallMap : EntityTypeConfiguration<Rainfall>
	{
		public RainfallMap()
		{
			ToTable("Rainfall");
			HasKey(m => m.Id);
			Property(m => m.CityId);
			Property(m => m.RainfallValue);
            HasRequired(m => m.City).WithMany().HasForeignKey(m => m.CityId);
            Property(m => m.Count);
            Property(m => m.PrecipitationTime);
            Ignore(m => m.Province);
            Ignore(m => m.CityName);
            Ignore(m => m.Area);
        }
	}
}
