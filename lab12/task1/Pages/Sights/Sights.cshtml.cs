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
    public class SightsModel : PageModel
    {
        private ISightsRepository _db;

        public SightsModel(ISightsRepository db)
        {
            _db = db;
        }

        public IEnumerable<Sight> Sights { get; set; }

        public void OnGet()
        {
            Sights = _db.GetAllSights();
        }
    }
}
