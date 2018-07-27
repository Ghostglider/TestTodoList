using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Data.Configuration
{
	public class TodoConfiguration
	{
		public TodoConfiguration()
		{
			//HasKey(p => p.Id);

			//ToTable("ApplParametres");
			//Property(p => p.Id).HasColumnName("Id");
			//Property(p => p.Cle).HasColumnName("Cle");
			//Property(p => p.Description).HasColumnName("Description");
			//Property(p => p.Type).HasColumnName("Type");
			//Property(p => p.Valeur).HasColumnName("Valeur");
		}
	}
}
