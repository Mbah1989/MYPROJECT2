using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYPROJECT2.Interface;
using MYPROJECT2.Models;

namespace MYPROJECT2.Pages.Bestyrelse
{
    public class SletMedlemModel : PageModel
    {
        [BindProperty]
        public Leader leaders { get; set; }

        private ILeaders leader;

        public SletMedlemModel(ILeaders leader)
        {
            this.leader = leader;
        }

        public void OnGet(int sid)
        {
           leaders = leader.GetAllLeader(sid);

        }
        public IActionResult OnPost()
        {
            if(leaders!=null)
            {
                leader.RemoveLeader(leaders);
            }
            return RedirectToPage("/Bestyrelse/VisMedlemmer");

        }
    }
}
