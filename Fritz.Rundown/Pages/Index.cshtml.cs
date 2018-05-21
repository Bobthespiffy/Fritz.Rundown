using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fritz.Rundown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fritz.Rundown.Pages
{
	public class IndexModel : PageModel
	{

		public IndexModel(Models.RundownRepository repo)
		{
			this.Repository = repo;
		}

		public RundownRepository Repository { get; private set; }

		public void OnGet()
		{

		}
	}
}
