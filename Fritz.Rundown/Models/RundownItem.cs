using System;
using System.Linq;
using System.Threading.Tasks;

namespace Fritz.Rundown.Models
{
	public class RundownItem
	{

		public int ID { get; set; }

		public string Text { get; set; }

		public bool IsCompleted { get; set; }

	}
}
