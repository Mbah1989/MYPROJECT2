using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYPROJECT2.Interface;
using MYPROJECT2.Models;

namespace MYPROJECT2.Pages.ChildFolder
{
    public class GetChildrenModel : PageModel
    {
        public IEnumerable<Børn>children { get; set; }

        private IChild child;

        public GetChildrenModel(IChild child)
        {
            this.child = child;
        }

        public void OnGet()
        {
            children = child.GetAllChildren();
        }
    }
}
