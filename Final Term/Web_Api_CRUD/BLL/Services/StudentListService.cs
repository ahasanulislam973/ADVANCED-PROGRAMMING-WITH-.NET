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
    public class StudentListService
    {
        public static List<StudentListModel> Get()
        {
            var data = DataAccessFactory.GetStudentDataAccess().Get();
            var rdata = new List<StudentListModel>();

            foreach (var item in data)
            {
                rdata.Add(new StudentListModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Dob = item.Dob,
                    Gender = item.Gender,
                    Address = item.Address,

                });

            }
            return rdata;
        }

        public static StudentListModel Get(int id)
        {
            var data = DataAccessFactory.GetStudentDataAccess().Get(id);
            var rdata = new StudentListModel();
            rdata.Id = data.Id;
            rdata.Name = data.Name;
            rdata.Dob = data.Dob;
            rdata.Gender = data.Gender;
            rdata.Address = data.Address;

            return rdata;
        }

        public static bool Create(StudentListModel item)
        {
            var Student = new Student_Table()
            {
                Name = item.Name,
                Dob = item.Dob,
                Gender = item.Gender,
                Address = item.Address,
                // Type = 1

            };
            return DataAccessFactory.GetStudentDataAccess().Create(Student);
        }

        public static bool Update(StudentListModel item)
        {
            var Student = new Student_Table()
            {
                Id = item.Id,
                Name = item.Name,
                Dob = item.Dob,
                Gender = item.Gender,
                Address = item.Address,
                //Type = 1

            };
            return DataAccessFactory.GetStudentDataAccess().Update(Student);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetStudentDataAccess().Delete(id);
            return data;
        }
    }
}
