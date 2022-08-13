using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BOs
{
    public class Borrowed_BookModel
    {
        public int Borrowed_Book_Id { get; set; }
        public string Book_Name { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }
        public string Borrowed_By { get; set; }
        public string Date { get; set; }
    }
}
