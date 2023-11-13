using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYPROJECT2.Interface;
using MYPROJECT2.Models;

namespace MYPROJECT2.Pages.Bestyrelse
{
    public class VisMedlemmerModel : PageModel
    {
        ILeaders leaders;

        [BindProperty]

        public IEnumerable<Leader> Leaders { get; set; }

        public VisMedlemmerModel(ILeaders leaders)
        {
            this.leaders = leaders;
        }

        public void OnGet()
        {
            Leaders = leaders.GetAllLeader();
        }
    }
}
