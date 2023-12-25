using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace task1.Pages.Sights
{
    public class DeleteModel : PageModel
    {
        private ISightsRepository _db;

        public DeleteModel(ISightsRepository db)
        {
            _db = db;
        }

        [BindProperty]
        public Sight Sight { get; set; }

        public IActionResult OnGet(int id)
        {
            Sight = _db.GetSight(id);
            if (Sight == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Sight = _db.Delete(Sight.SightId);
            if (Sight == null)
            {
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Sights/Sights");
        }
    }
}
