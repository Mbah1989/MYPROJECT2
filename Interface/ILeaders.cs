using MYPROJECT2.Models;

namespace MYPROJECT2.Interface
{
    public interface ILeaders
    {
        IEnumerable<Leader> GetAllLeader();

        public Leader GetAllLeader(int id);

        public void AddLeader(Leader leader);

        public void RemoveLeader(Leader leader);

        public void UpgradeLeader(Leader leader);
    }
}
