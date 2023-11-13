using MYPROJECT2.Models;

namespace MYPROJECT2.Interface
{
    public interface ITickets
    {
        IEnumerable<Ticket> GetTickets();

        public Ticket GetAllChildren(int id);

        public void AddTicket(Ticket ticket);

        public void RemoveTicket(Ticket ticket);

        public void Update(Ticket ticket);
    }
}
