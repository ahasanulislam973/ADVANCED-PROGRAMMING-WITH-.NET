using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class BookListRepo : IRepo<BookList_Table, int, bool>
    {
        Library_ManagementEntities db = new Library_ManagementEntities();

        public BookListRepo(Library_ManagementEntities db)
        {
            this.db = db;
        }
        //this is create
        public bool Create(BookList_Table obj)
        {
            db.BookList_Table.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        

        public bool Delete(int id)
        {
            db.BookList_Table.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<BookList_Table> Get()
        {
            return db.BookList_Table.ToList();
        }

        public BookList_Table Get(int id)
        {
            return db.BookList_Table.SingleOrDefault(s => s.BookId == id);
        }

        public bool Update(BookList_Table obj)
        {
            var exst = db.BookList_Table.FirstOrDefault(s => s.BookId == obj.BookId);
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
