using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StudentListRepo : IRepo<Student_Table, int, bool>
    {
        Library_ManagementEntities db = new Library_ManagementEntities();

        public StudentListRepo(Library_ManagementEntities db)
        {
            this.db = db;
        }
        //this is create
        public bool Create(Student_Table obj)
        {
            db.Student_Table.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }


        public bool Delete(int id)
        {
            db.Student_Table.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<Student_Table> Get()
        {
            return db.Student_Table.ToList();
        }

        public Student_Table Get(int id)
        {
            return db.Student_Table.SingleOrDefault(s => s.Id == id);
        }

        public bool Update(Student_Table obj)
        {
            var exst = db.Student_Table.FirstOrDefault(s => s.Id == obj.Id);
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
