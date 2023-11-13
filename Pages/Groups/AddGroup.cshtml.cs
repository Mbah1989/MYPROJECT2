using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYPROJECT2.Interface;
using MYPROJECT2.Models;

namespace MYPROJECT2.Pages.Groups
{
   
    public class AddGroupModel : PageModel
    {
        [BindProperty]
        public Group Groups { get; set; }

        private IGroups groups;

       

        public AddGroupModel(IGroups groups)
        {
            this.groups = groups;
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
            groups.AddGroup(Groups);

            return RedirectToPage("GetGroups");
        }
    }
}
