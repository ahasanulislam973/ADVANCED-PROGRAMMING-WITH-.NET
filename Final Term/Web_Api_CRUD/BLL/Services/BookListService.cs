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
    public class BookListService
    {
        public static List<BookListModel> Get()
        {
            var data = DataAccessFactory.GetBookListDataAccess().Get();
            var rdata = new List<BookListModel>();

            foreach (var item in data)
            {
                rdata.Add(new BookListModel()
                {
                    BookId = item.BookId,
                    BookName = item.BookName,
                    AuthorName = item.AuthorName,
                    Edition = item.Edition,
                   
                });

            }
            return rdata;
        }

        public static BookListModel Get(int id)
        {
            var data = DataAccessFactory.GetBookListDataAccess().Get(id);
            var rdata = new BookListModel();
            rdata.BookId= data.BookId;
            rdata.BookName = data.BookName;
            rdata.AuthorName = data.AuthorName;
            rdata.Edition = data.Edition;
            

            return rdata;
        }

        

        public static bool Create(BookListModel item)
        {
            var BookList = new BookList_Table()
            {
                BookName = item.BookName,
                AuthorName = item.AuthorName,
                Edition = item.Edition,
                

            };
            return DataAccessFactory.GetBookListDataAccess().Create(BookList);
        }

        public static bool Update(BookListModel item)
        {
            var BookList = new BookList_Table()
            {
                BookId = item.BookId,
                BookName = item.BookName,
                AuthorName = item.AuthorName,
                Edition = item.Edition,
                

            };
            return DataAccessFactory.GetBookListDataAccess().Update(BookList);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetBookListDataAccess().Delete(id);
            return data;
        }
    }
}
