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
    public class CitiesModel : PageModel
    {
        private ICitiesRepository _db;

        public CitiesModel(ICitiesRepository db)
        {
            _db = db;
        }

        public IEnumerable<City> Cities { get; set; }

        public void OnGet()
        {
            Cities = _db.GetAllCities();
        }
    }
}
