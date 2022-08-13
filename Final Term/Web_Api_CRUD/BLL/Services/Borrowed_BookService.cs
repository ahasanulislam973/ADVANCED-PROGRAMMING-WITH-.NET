using BLL.BOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Borrowed_BookService
    {
        public static List<Borrowed_BookModel> Get()
        {
            var data = DataAccessFactory.GetBorrowed_BookDataAccess().Get();
            var rdata = new List<Borrowed_BookModel>();

            foreach (var item in data)
            {
                rdata.Add(new Borrowed_BookModel()
                {
                    Borrowed_Book_Id = item.Borrowed_Book_Id,
                    Book_Name = item.Book_Name,
                    Author = item.Author,
                    Edition = item.Edition,
                    Borrowed_By = item.Borrowed_By,
                    Date = item.Date,

                });

            }
            return rdata;
        }

        public static Borrowed_BookModel Get(int id)
        {
            var data = DataAccessFactory.GetBorrowed_BookDataAccess().Get(id);
            var rdata = new Borrowed_BookModel();
            rdata.Borrowed_Book_Id = data.Borrowed_Book_Id;
            rdata.Book_Name = data.Book_Name;
            rdata.Author = data.Author;
            rdata.Edition = data.Edition;
            rdata.Borrowed_By = data.Borrowed_By;
            rdata.Date = data.Date;

            return rdata;
        }

        public static bool Create(Borrowed_BookModel item)
        {
            var Borrowed_Book = new Borrowed_Book_Table()
            {
                Book_Name = item.Book_Name,
                Author = item.Author,
                Edition = item.Edition,
                Borrowed_By = item.Borrowed_By,
                Date = item.Date,
                // Type = 1

            };
            return DataAccessFactory.GetBorrowed_BookDataAccess().Create(Borrowed_Book);
        }

        public static bool Update(Borrowed_BookModel item)
        {
            var Borrowed_Book = new Borrowed_Book_Table()
            {
                Book_Name = item.Book_Name,
                Author = item.Author,
                Edition = item.Edition,
                Borrowed_By = item.Borrowed_By,
                Date = item.Date,
                //Type = 1

            };
            return DataAccessFactory.GetBorrowed_BookDataAccess().Update(Borrowed_Book);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetRequested_BookDataAccess().Delete(id);
            return data;
        }
    }
}
