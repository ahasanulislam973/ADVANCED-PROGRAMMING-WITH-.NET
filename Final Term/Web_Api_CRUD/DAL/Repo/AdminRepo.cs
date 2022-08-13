using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repo
{
    public class AdminRepo : IRepo<Librarian_table, int, bool>
    {
        Library_ManagementEntities db = new Library_ManagementEntities();

        public AdminRepo(Library_ManagementEntities db)
        {
            this.db = db;
        }
        //this is create
        public bool Create(Librarian_table obj)
        {
            db.Librarian_table.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

     

        public bool Delete(int id)
        {
            db.Librarian_table.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<Librarian_table> Get()
        {
            return db.Librarian_table.ToList();
        }

        public Librarian_table Get(int id)
        {
            return db.Librarian_table.SingleOrDefault(s => s.Id == id);
        }

        public bool Update(Librarian_table obj)
        {
            var exst = db.Librarian_table.FirstOrDefault(s => s.Id == obj.Id);
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
