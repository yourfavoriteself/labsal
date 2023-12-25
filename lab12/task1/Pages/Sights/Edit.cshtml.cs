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
    public class EditModel : PageModel
    {
        private readonly ISightsRepository sightsRepository;

        public EditModel(ISightsRepository sightsRepository)
        {
            this.sightsRepository = sightsRepository;
        }

        [BindProperty]
        public Sight Sight { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Sight = sightsRepository.GetSight(id.Value);
            }
            else
            {
                Sight = new Sight();
            }

            if (Sight == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }

        public IActionResult OnPost(Sight sight)
        {
            if (Sight.SightId > 0)
            {
                Sight = sightsRepository.Update(sight);
            }
            else
            {
                Sight = sightsRepository.Add(sight);
            }

            return RedirectToPage("/Sights/Sights");
        }
    }
}
