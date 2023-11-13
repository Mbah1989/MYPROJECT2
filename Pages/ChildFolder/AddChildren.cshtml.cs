using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYPROJECT2.Interface;
using MYPROJECT2.Models;

namespace MYPROJECT2.Pages.ChildFolder
{
    public class AddChildrenModel : PageModel
    {
        [BindProperty]
        public Børn Børn { get; set; }

        private IChild child;

        public AddChildrenModel(IChild child)
        {
            this.child = child;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            { 
                return Page();
            }
            child.AddChild(Børn);
            return RedirectToPage("/ChildFolder/GetChildren");
        }
    }
}
