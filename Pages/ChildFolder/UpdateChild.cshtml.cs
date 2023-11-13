using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYPROJECT2.Interface;
using MYPROJECT2.Models;

namespace MYPROJECT2.Pages.ChildFolder
{
    public class UpdateChildModel : PageModel
    {
        [BindProperty]
        public Børn Child { get; set; }

        private IChild child;


        

        public UpdateChildModel(IChild child)
        {
            this.child = child;
        }

        public void OnGet(int sid)
        {
            Child=child.GetAllChildren(sid);

        }
        public IActionResult OnPost()
        {

            if(!ModelState.IsValid)
            {
                return Page();
            }
            child.Update(Child);

            return RedirectToPage("/ChildFolder/GetChildren");

        }
    }
}
