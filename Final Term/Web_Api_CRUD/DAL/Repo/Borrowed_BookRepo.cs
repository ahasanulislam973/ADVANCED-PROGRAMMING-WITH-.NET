using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class Borrowed_BookRepo : IRepo<Borrowed_Book_Table, int, bool>
    {
        Library_ManagementEntities db = new Library_ManagementEntities();

        public Borrowed_BookRepo(Library_ManagementEntities db)
        {
            this.db = db;
        }
        //this is create
        public bool Create(Borrowed_Book_Table obj)
        {
            db.Borrowed_Book_Table.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }


        public bool Delete(int id)
        {
            db.Borrowed_Book_Table.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<Borrowed_Book_Table> Get()
        {
            return db.Borrowed_Book_Table.ToList();
        }

        public Borrowed_Book_Table Get(int id)
        {
            return db.Borrowed_Book_Table.SingleOrDefault(s => s.Borrowed_Book_Id == id);
        }

        public bool Update(Borrowed_Book_Table obj)
        {
            var exst = db.Borrowed_Book_Table.FirstOrDefault(s => s.Borrowed_Book_Id == obj.Borrowed_Book_Id);
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
