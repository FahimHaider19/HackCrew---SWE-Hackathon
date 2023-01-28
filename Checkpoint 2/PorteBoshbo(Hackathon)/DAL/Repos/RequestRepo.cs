using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RequestRepo : IRepo<Request>
    {
        private PorteBoshboEntities db = new PorteBoshboEntities();

        public bool Add(Request obj)
        {
            db.Requests.Add(obj);
            return db.SaveChanges() > 0;
        }

        public Request Get(int id)
        {
            return db.Requests.Find(id);
        }

        public List<Request> GetAll()
        {
            return db.Requests.ToList();
        }

        public bool Remove(int id)
        {
            db.Requests.Remove(Get(id));
            return db.SaveChanges() > 0;
        }

        public bool Update(Request obj)
        {
            db.Entry(Get(obj.RequestId)).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}

