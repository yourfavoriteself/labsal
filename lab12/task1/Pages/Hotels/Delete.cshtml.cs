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
    public class DeleteModel : PageModel
    {
        private IHotelsRepository _db;

        public DeleteModel(IHotelsRepository db)
        {
            _db = db;
        }

        [BindProperty]
        public Hotel Hotel { get; set; }

        public IActionResult OnGet(int id)
        {
            Hotel = _db.GetHotel(id);
            if (Hotel == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Hotel = _db.Delete(Hotel.HotelId);
            if (Hotel == null)
            {
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Hotels/Hotels");
        }
    }
}
