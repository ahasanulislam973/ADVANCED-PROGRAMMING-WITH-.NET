using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD.Controllers.Admin
{
    public class BookListController : ApiController
    {
        Library_ManagementEntities db = new Library_ManagementEntities();

        //Book Added
        public string post(BookList_Table Book)
        {
            db.BookList_Table.Add(Book);
            db.SaveChanges();
            return "Book added";
        }

        // Get all Records
        public IEnumerable<BookList_Table> Get()
        {
            return db.BookList_Table.ToList();
        }

        //Get single Book
        public BookList_Table Get(int id)
        {
            BookList_Table Book = db.BookList_Table.Find(id);
            return Book;
        }

        //update the record
        public string Put(int id, BookList_Table Book)
        {
            var Book1 = db.BookList_Table.Find(id);
            Book1.BookName = Book.BookName;
            Book1.AuthorName = Book.AuthorName;
            Book1.Edition = Book.Edition;
           

            db.Entry(Book1).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Book updated";

        }

        //Delete record

        public string Delete(int id)
        {
            BookList_Table Book = db.BookList_Table.Find(id);
            db.BookList_Table.Remove(Book);
            db.SaveChanges();
            return "deleted";

        }
    }
}
