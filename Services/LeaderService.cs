using MYPROJECT2.Interface;
using MYPROJECT2.Models;

namespace MYPROJECT2.Services
{
    public class LeaderService : ILeaders
    {

        private FDFVanløseContext context;

        public LeaderService(FDFVanløseContext context)
        {
            this.context = context;
        }

        public void AddLeader(Leader leader)
        {
            context.Leaders.Add(leader);
            context.SaveChanges();
        }

        public IEnumerable<Leader> GetAllLeader()
        {
            return context.Leaders;
        }

        public Leader GetAllLeader(int id)
        {
            Leader FoundLeader = context.Leaders.FirstOrDefault(l=>l.LeaderId==id);
            return FoundLeader;
        }

        public void RemoveLeader(Leader leader)
        {
            context.Leaders.Remove(leader);
            context.SaveChanges();
        }

        public void UpgradeLeader(Leader Opdaterleader)
        {
            Leader ExistingLeader=context.Leaders.FirstOrDefault(e=>e.LeaderId==Opdaterleader.LeaderId);

            if (ExistingLeader!=null)
            {
                ExistingLeader.Name = Opdaterleader.Name;
                ExistingLeader.UserId = Opdaterleader.UserId;
                ExistingLeader.Appointed = Opdaterleader.Appointed;
            }

            context.SaveChanges();
        }
    }
}
