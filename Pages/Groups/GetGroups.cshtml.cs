using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYPROJECT2.Interface;
using MYPROJECT2.Models;

namespace MYPROJECT2.Pages.Groups
{
    public class GetGroupsModel : PageModel
    {
        private IGroups groups;

        public IEnumerable<Group> Groups { get; set; }

        public GetGroupsModel(IGroups groups)
        {
            this.groups = groups;
        }

        public void OnGet()
        {
            Groups = groups.GetAllGroup();
        }
    }
}
