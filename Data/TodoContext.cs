using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using Models;
using Data.Configuration;

namespace Data
{
	public class TodoContext : DbContext
	{

		static TodoContext()
		{
			Database.SetInitializer<DbContext>(null);
		}
		public TodoContext() : base("TodoContext")
		{
			Configuration.LazyLoadingEnabled = false;
		}
		public DbSet<Todo> Todos { get; set; }

		//public new Database Database => throw new NotImplementedException();

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//modelBuilder.Configurations.Add(new TodoConfiguration());
		}
	}
}
