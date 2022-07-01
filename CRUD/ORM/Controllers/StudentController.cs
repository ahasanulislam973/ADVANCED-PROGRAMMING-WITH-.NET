using ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORM.Controllers
{
    public class StudentController : Controller
    {
       // private object db;

        public int Id { get; private set; }

        // GET: Student
        public ActionResult Index()
        {
            UMS_AEntities2 db = new UMS_AEntities2();
            var data = from st in db.Students
                       select st;
            return View(data.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            UMS_AEntities2 db = new UMS_AEntities2();
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

                public ActionResult Edit(int Id)
                {
                    using (UMS_AEntities2 db = new UMS_AEntities2())
                    {
                        var student = (from st in db.Students
                                       where st.Id == Id
                                       select st).First();
             return View(student);
            //return RedirectToAction("Index");
        }

                }
        
        
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            using (UMS_AEntities2 db = new UMS_AEntities2())
            {
                Student entity = (from st in db.Students
                                  where st.Id == s.Id
                                  select st).FirstOrDefault();
                entity.Name = s.Name;
                entity.Dob = s.Dob;
                entity.Gender = s.Gender;
                entity.Cgpa = s.Cgpa;
                // db.Entry(entity).CurrentValues.SetValues(s);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
        } 



        public ActionResult Details(int Id)
        {
            UMS_AEntities2 db = new UMS_AEntities2();
            var student = (from st in db.Students
                           where st.Id == Id
                           select st).First();
            return View(student);
        }


        /*
                public ActionResult Details()
                {
                     UMS_AEntities db = new UMS_AEntities();
                     var data = from st in db.Students
                                select st;
                     return View(data.ToList());
                 }
                */
        /*
                    using (UMS_AEntities db = new UMS_AEntities())
                    {
                        var student = (from st in db.Students
                                       where st.Id == Id
                                       select st).First();
                        return View(student);

                    }
                    */
        //  }



        public ActionResult Delete(int Id)
        {
            using (UMS_AEntities2 db = new UMS_AEntities2())
            {
                Student s = (from st in db.Students
                             where st.Id == Id
                             select st).FirstOrDefault();
                return View(s);
            }
        }
        [HttpPost]
        public ActionResult Delete(Student s)
        {
            using (UMS_AEntities2 db = new UMS_AEntities2())
            {
                Student entity = (from st in db.Students
                                  where st.Id == s.Id
                                  select st).FirstOrDefault();
                db.Students.Remove(entity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}