using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD.Controllers.Admin
{
    public class OcassionController : ApiController
    {
        Library_ManagementEntities db = new Library_ManagementEntities();

        //Ocassion Added
        public string post(Occasion_Table Ocassion)
        {
            db.Occasion_Table.Add(Ocassion);
            db.SaveChanges();
            return "Ocassion added";
        }

        // Get all Records
        public IEnumerable<Occasion_Table> Get()
        {
            return db.Occasion_Table.ToList();
        }

        //Get single Ocassion
        public Occasion_Table Get(int id)
        {
            Occasion_Table Ocassion = db.Occasion_Table.Find(id);
            return Ocassion;
        }

        //update the record
        public string Put(int id, Occasion_Table Occasion)
        {
            var Occasion1 = db.Occasion_Table.Find(id);
            Occasion1.OC_Name = Occasion.OC_Name;
            Occasion1.OC_Description =Occasion.OC_Description;
            Occasion1.OC_Date = Occasion.OC_Date;
            Occasion1.OC_Time = Occasion.OC_Time;
            

            db.Entry(Occasion1).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Occasion updated";

        }

        //Delete record

        public string Delete(int id)
        {
            Occasion_Table Occasion = db.Occasion_Table.Find(id);
            db.Occasion_Table.Remove(Occasion);
            db.SaveChanges();
            return "deleted";

        }
    }
}
