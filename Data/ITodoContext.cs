using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.Entity;

namespace Data
{
	public interface ITodoContext
	{
		Database database { get; }
		DbSet<Todo> Todos { get; set; }
	}
}
