using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class OccasionRepo : IRepo<Occasion_Table, int, bool>
    {
        Library_ManagementEntities db = new Library_ManagementEntities();

        public OccasionRepo(Library_ManagementEntities db)
        {
            this.db = db;
        }
        //this is create
        public bool Create(Occasion_Table obj)
        {
            db.Occasion_Table.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

       

        public bool Delete(int id)
        {
            db.Occasion_Table.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<Occasion_Table> Get()
        {
            return db.Occasion_Table.ToList();
        }

        public Occasion_Table Get(int id)
        {
            return db.Occasion_Table.SingleOrDefault(s => s.OC_Id == id);
        }

        public bool Update(Occasion_Table obj)
        {
            var exst = db.Occasion_Table.FirstOrDefault(s => s.OC_Id == obj.OC_Id);
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
