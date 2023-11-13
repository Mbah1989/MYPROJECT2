using Microsoft.EntityFrameworkCore;
using MYPROJECT2.Interface;
using MYPROJECT2.Models;
using System.Collections.Generic;

namespace MYPROJECT2.Services
{
    public class ChildService : IChild
    {

        private FDFVanløseContext vanløseContext;

        public ChildService(FDFVanløseContext vanløseContext)
        {
            this.vanløseContext = vanløseContext;
        }

        public void AddChild(Børn child)
        {
            vanløseContext.Børns.Add(child);
            vanløseContext.SaveChanges();
        }

        public IEnumerable<Børn> GetAllChildren()
        {
            return vanløseContext.Børns;
            vanløseContext.SaveChanges();
        }

        public Børn GetAllChildren(int id)

        {

           var FoundChild= vanløseContext.Børns.FirstOrDefault(f => f.ChildId == id);
            return FoundChild;
            
        }

        public void RemoveChild(Børn child)

        {
           vanløseContext.Børns.Remove(child);
            vanløseContext.SaveChanges();

        }

        public void Update(Børn Updatedchild)
        {


            Børn ExistingChild = vanløseContext.Børns.FirstOrDefault(e => e.ChildId == Updatedchild.ChildId);

            if (ExistingChild != null)
            {
               
                ExistingChild.Name = Updatedchild.Name;
                ExistingChild.Address = Updatedchild.Address;
                ExistingChild.Age = Updatedchild.Age;
                ExistingChild.GroupId= Updatedchild.GroupId;
                ExistingChild.Start= Updatedchild.Start;

            }
            

            vanløseContext.SaveChanges();

           
            




        }

        
    }    
}
