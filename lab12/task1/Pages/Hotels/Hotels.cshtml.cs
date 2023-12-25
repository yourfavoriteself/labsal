using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace task1.Pages.Hotels
{
    public class HotelsModel : PageModel
    {
        private IHotelsRepository _db;

        public HotelsModel(IHotelsRepository db)
        {
            _db = db;
        }

        public IEnumerable<Hotel> Hotels { get; set; }

        public void OnGet()
        {
            Hotels = _db.GetAllHotels();
        }
    }
}
