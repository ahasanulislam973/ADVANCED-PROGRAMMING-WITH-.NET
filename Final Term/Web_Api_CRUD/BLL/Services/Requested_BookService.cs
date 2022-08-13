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
    public class Requested_BookService
    {
        public static List<Requested_BookModel> Get()
        {
            var data = DataAccessFactory.GetRequested_BookDataAccess().Get();
            var rdata = new List<Requested_BookModel>();

            foreach (var item in data)
            {
                rdata.Add(new Requested_BookModel()
                {
                    Book_Id = item.Book_Id,
                    Book_Name = item.Book_Name,
                    Author = item.Author,
                    Edition = item.Edition,
                    ReqBy = item.ReqBy,

                });

            }
            return rdata;
        }

        public static Requested_BookModel Get(int id)
        {
            var data = DataAccessFactory.GetRequested_BookDataAccess().Get(id);
            var rdata = new Requested_BookModel();
            rdata.Book_Id = data.Book_Id;
            rdata.Book_Name = data.Book_Name;
            rdata.Author = data.Author;
            rdata.Edition = data.Edition;
            rdata.ReqBy = data.ReqBy;

            return rdata;
        }

        public static bool Create(Requested_BookModel item)
        {
            var Requested_Book = new Requested_Book_Table()
            {
                Book_Name = item.Book_Name,
                Author = item.Author,
                Edition = item.Edition,
                ReqBy = item.ReqBy,
                // Type = 1

            };
            return DataAccessFactory.GetRequested_BookDataAccess().Create(Requested_Book);
        }

        public static bool Update(Requested_BookModel item)
        {
            var Requested_Book = new Requested_Book_Table()
            {
                Book_Name = item.Book_Name,
                Author = item.Author,
                Edition = item.Edition,
                ReqBy = item.ReqBy,
                //Type = 1

            };
            return DataAccessFactory.GetRequested_BookDataAccess().Update(Requested_Book);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetRequested_BookDataAccess().Delete(id);
            return data;
        }
    }
}
