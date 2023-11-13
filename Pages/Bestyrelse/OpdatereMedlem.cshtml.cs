using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYPROJECT2.Interface;
using MYPROJECT2.Models;

namespace MYPROJECT2.Pages.Bestyrelse
{
    public class OpdatereMedlemModel : PageModel
    {

        [BindProperty]
        public Leader Leader { get; set; }

        private ILeaders Leaders;

        public OpdatereMedlemModel(ILeaders leaders)
        {
            Leaders = leaders;
        }

        public void OnGet(int sid)
        {
            Leader = Leaders.GetAllLeader(sid);
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            Leaders.UpgradeLeader(Leader);
            return RedirectToPage("/Bestyrelse/VisMedlemmer");
            
        }
    }
}
