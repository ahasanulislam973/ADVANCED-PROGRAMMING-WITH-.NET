using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class Requested_BookRepo : IRepo<Requested_Book_Table, int, bool>
    {
        Library_ManagementEntities db = new Library_ManagementEntities();

        public Requested_BookRepo(Library_ManagementEntities db)
        {
            this.db = db;
        }
        //this is create
        public bool Create(Requested_Book_Table obj)
        {
            db.Requested_Book_Table.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

    

        public bool Delete(int id)
        {
            db.Requested_Book_Table.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<Requested_Book_Table> Get()
        {
            return db.Requested_Book_Table.ToList();
        }

        public Requested_Book_Table Get(int id)
        {
            return db.Requested_Book_Table.SingleOrDefault(s => s.Book_Id == id);
        }

        public bool Update(Requested_Book_Table obj)
        {
            var exst = db.Requested_Book_Table.FirstOrDefault(s => s.Book_Id == obj.Book_Id);
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
