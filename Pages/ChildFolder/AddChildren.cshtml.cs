using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYPROJECT2.Interface;
using MYPROJECT2.Models;

namespace MYPROJECT2.Pages.ChildFolder
{
    public class AddChildrenModel : PageModel
    {
        [BindProperty]
        public B�rn B�rn { get; set; }

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
            child.AddChild(B�rn);
            return RedirectToPage("/ChildFolder/GetChildren");
        }
    }
}
