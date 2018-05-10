using System;
namespace WindowsFormsApplication1
{
    /// <summary>
    /// 
    /// </summary>
    public class Rainfall
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CityId { get; set; }

        public int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int RainfallValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime PrecipitationTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual City City { get; set; }

        public virtual string Province
        {
            get
            {
                if (City != null && City.Parent != null)
                {
                    return City.Parent.Parent.Name;
                }
                return null;
            }
        }

        public virtual string CityName
        {
            get
            {
                if (City != null)
                {
                    return City.Parent.Name;
                }
                return null;
            }
        }

        public virtual string Area
        {
            get
            {
                return City.Name;
            }
        }
    }
}
