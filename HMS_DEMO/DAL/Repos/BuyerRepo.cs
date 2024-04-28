using DAL.EF.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BuyerRepo : Repo, IRepo<Buyer, int>
    {
        public void Create(Buyer obj)
        {
            db.Buyers.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var exobj = Get(id);
            db.Buyers.Remove(exobj);
            db.SaveChanges();
        }

        public List<Buyer> Get()
        {
            return db.Buyers.ToList();
        }

        public Buyer Get(int id)
        {
            return db.Buyers.Find(id);
        }

        public void Update(Buyer obj)
        {
            var exobj = Get(obj.Id);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            db.SaveChanges();
        }
    }
}
