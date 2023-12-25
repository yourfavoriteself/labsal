/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorModels;
using RazorServices;

namespace task1.Pages.Hotels
{
    public class EditModel : PageModel
    {
        private readonly IHotelsRepository hotelsRepository;

        public EditModel(IHotelsRepository hotelsRepository)
        {
            this.hotelsRepository = hotelsRepository;
        }

        [BindProperty]
        public Hotel Hotel { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Hotel = hotelsRepository.GetHotel(id.Value);
            }
            else
            {
                Hotel = new Hotel();
            }

            if (Hotel == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }

        public IHotelsRepository GetHotelsRepository()
        {
            return hotelsRepository;
        }

        public IActionResult OnPost(Hotel hotel, IHotelsRepository hotelsRepository)
        {
            if (Hotel.HotelId > 0)
            {
                Hotel = hotelsRepository.Update(hotel);
            }
            else
            {
                Hotel = hotelsRepository.Add(hotel);
            }

            return RedirectToPage("/Hotels/Hotels");
        }
    }
}
*/
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
    public class EditModel : PageModel
    {
        private readonly IHotelsRepository hotelsRepository;

        public EditModel(IHotelsRepository hotelsRepository)
        {
            this.hotelsRepository = hotelsRepository;
        }

        [BindProperty]
        public Hotel Hotel { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Hotel = hotelsRepository.GetHotel(id.Value);
            }
            else
            {
                Hotel = new Hotel();
            }

            if (Hotel == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }

        public IActionResult OnPost(Hotel hotel)
        {
            if (Hotel.HotelId > 0)
            {
                hotelsRepository.Update(hotel);
            }
            else
            {
                //hotelsRepository.Add(hotel);
            }

            return RedirectToPage("/Hotels/Hotels");
        }
    }
}
