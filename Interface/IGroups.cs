using MYPROJECT2.Models;

namespace MYPROJECT2.Interface
{
    public interface IGroups
    {
        IEnumerable<Group> GetAllGroup();

        public Group GetAllGroup(int id);

        public void AddGroup(Group group);

        public void RemoveGroup(Group group);

        public void UpgradeGroup(Group group);
    }
}

