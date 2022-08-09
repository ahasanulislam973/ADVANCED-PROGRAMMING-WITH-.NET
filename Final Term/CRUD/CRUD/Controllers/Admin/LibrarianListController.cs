using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD.Controllers.Admin
{
    public class LibrarianListController : ApiController
    {
        Library_ManagementEntities db = new Library_ManagementEntities();

        //Librarian Added
        public string post(Librarian_table Librarian)
        {
            db.Librarian_table.Add(Librarian);
            db.SaveChanges();
            return "Librarian added";
        }

        // Get all Records
        public IEnumerable<Librarian_table> Get()
        {
            return db.Librarian_table.ToList();
        }

        //Get single student
        public Librarian_table Get(int id)
        {
            Librarian_table Librarian = db.Librarian_table.Find(id);
            return Librarian;
        }

        //update the record
        public string Put(int id, Librarian_table student)
        {
            var Librarian = db.Librarian_table.Find(id);
            Librarian.Name = student.Name;
            Librarian.Dob = student.Dob;
            Librarian.Gender = student.Gender;
            Librarian.JoiningDate = student.JoiningDate;
            Librarian.BloodGroup = Librarian.BloodGroup;
            Librarian.Address = Librarian.Address;

            db.Entry(Librarian).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Librarian updated";

        }

        //Delete record

        public string Delete(int id)
        {
            Librarian_table Librarian = db.Librarian_table.Find(id);
            db.Librarian_table.Remove(Librarian);
            db.SaveChanges();
            return "deleted";

        }
    }
}
