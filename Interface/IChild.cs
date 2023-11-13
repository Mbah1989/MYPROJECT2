using MYPROJECT2.Models;

namespace MYPROJECT2.Interface
{
    public interface IChild
    {
        IEnumerable<Børn> GetAllChildren();

        public Børn GetAllChildren(int id);

        public void AddChild( Børn child);

        public void RemoveChild( Børn child );

        public void Update(Børn Updatedchild);
    }
}
