using MYPROJECT2.Interface;
using MYPROJECT2.Models;

namespace MYPROJECT2.Services
{
    public class GroupService : IGroups
    {
        private FDFVanløseContext _context;

        public GroupService(FDFVanløseContext context)
        {
            _context = context;
        }

       
        public void AddGroup(Group group)
        {
            _context.Groups.Add(group);
            _context.SaveChanges();
           
        }

        public IEnumerable<Group> GetAllGroup()
        {
            return _context.Groups;
        }

        public Group GetAllGroup(int id)
        {
            Group group = _context.Groups.FirstOrDefault(g=>g.GroupId==id);
            return group;
        }

        public void RemoveGroup(Group group)
        {
            throw new NotImplementedException();
        }

        public void UpgradeGroup(Group group)
        {
            throw new NotImplementedException();
        }
    }
}
