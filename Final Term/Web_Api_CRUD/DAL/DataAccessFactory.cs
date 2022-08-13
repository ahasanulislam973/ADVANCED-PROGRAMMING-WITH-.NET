using DAL.EF;
using DAL.Interfces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static Library_ManagementEntities db = new Library_ManagementEntities();

        public static IRepo<Librarian_table, int, bool> GetAdminDataAccess()
        { 
            return new AdminRepo(db);
        }

        public static object GetLibrarianDataAccess()
        {
            throw new NotImplementedException();
        }

        public static IRepo<BookList_Table, int, bool> GetBookListDataAccess()
        {
            return new BookListRepo(db);
        }

        public static IRepo<Occasion_Table, int, bool> GetOccasionDataAccess()
        {
            return new OccasionRepo(db);
        }

        public static IRepo<Student_Table, int, bool> GetStudentDataAccess()
        {
            return new StudentListRepo(db);
        }
        public static IRepo<Borrowed_Book_Table, int, bool> GetBorrowed_BookDataAccess()
        {
            return new Borrowed_BookRepo(db);
        }
        public static IRepo<Requested_Book_Table, int, bool> GetRequested_BookDataAccess()
        {
            return new Requested_BookRepo(db);
        }

    }
}
