using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	/// <summary>
	/// 
	/// </summary>
	public class City
	{
		/// <summary>
		/// 
		/// </summary>
		public int Id{ get; set;}
		/// <summary>
		/// 
		/// </summary>
		public string Name{ get; set;}
		/// <summary>
		/// 
		/// </summary>
		public int? ParentId{ get; set;}

        public virtual City Parent { get; set; }

        public virtual ICollection<City> Childs { get; set; }
	}
}
