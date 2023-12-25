using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace task1.Pages.Cities
{
	public class DeleteModel : PageModel
    {
        private ICitiesRepository __db;
        public DeleteModel(ICitiesRepository db)
        {
            __db = db;
        }

        [BindProperty]
        public City City { get; set; }

        public IActionResult OnGet(int id)
        {
            City = __db.GetCity(id);
            if (City == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            City = __db.Delete(City.CityId);
            if (City == null)
            {
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Cities/Cities");
        }
    }
}
