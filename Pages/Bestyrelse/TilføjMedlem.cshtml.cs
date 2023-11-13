using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYPROJECT2.Interface;
using MYPROJECT2.Models;

namespace MYPROJECT2.Pages.Bestyrelse
{
    public class TilføjMedlemModel : PageModel
    {
        [BindProperty]
        public Leader leader { get; set; }

        private ILeaders leaders;

       

        public TilføjMedlemModel(ILeaders leaders)
        {
            this.leaders = leaders;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            leaders.AddLeader(leader);

            return RedirectToPage("/Bestyrelse/VisMedlemmer");

        }
    }
}
