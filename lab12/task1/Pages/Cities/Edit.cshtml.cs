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
    public class EditModel : PageModel
    {
        private readonly ICitiesRepository citiesRepository;

        public EditModel(ICitiesRepository citiesRepository)
        {
            this.citiesRepository = citiesRepository;
        }

        [BindProperty]
        public City City { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                City = citiesRepository.GetCity(id.Value);
            }
            else
            {
                City = new City();
            }

            if (City == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }

        public IActionResult OnPost(City city)
        {
            if (City.CityId > 0)
            {
                City = citiesRepository.Update(city);
            }
            else
            {
                City = citiesRepository.Add(city);
            }

            return RedirectToPage("/Cities/Cities");
        }
    }
}
