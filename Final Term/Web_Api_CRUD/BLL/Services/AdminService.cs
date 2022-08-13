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
    public class AdminService
    {
        public static List<AdminModel> Get()
        {
            var data = DataAccessFactory.GetAdminDataAccess().Get();
            var rdata = new List<AdminModel>();

            foreach (var item in data)
            {
                rdata.Add(new AdminModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Dob = item.Dob,
                    Gender = item.Gender,
                    JoiningDate = item.JoiningDate,
                    BloodGroup = item.BloodGroup,
                    Address = item.Address,

                });
                
            }
            return rdata;
        }

        public static AdminModel Get(int id)
        {
            var data = DataAccessFactory.GetAdminDataAccess().Get(id);
            var rdata = new AdminModel();
            rdata.Id = data.Id;
            rdata.Name = data.Name;
            rdata.Dob = data.Dob;
            rdata.Gender = data.Gender;
            rdata.JoiningDate = data.JoiningDate;
            rdata.BloodGroup = data.BloodGroup;
            rdata.Address = data.Address;

            return rdata;
        }

        public static bool Create(AdminModel item)
        {
            var admin = new Librarian_table()
            {
                Name = item.Name,
                Dob = item.Dob,
                Gender = item.Gender,
                JoiningDate = item.JoiningDate,
                Address = item.Address,
               // Type = 1
                
            };
            return DataAccessFactory.GetAdminDataAccess().Create(admin);    
        }

        public static bool Update(AdminModel item)
        {
            var admin = new Librarian_table()
            {
                Id = item.Id,
                Name = item.Name,
                Dob = item.Dob,
                Gender = item.Gender,
                JoiningDate = item.JoiningDate,
                BloodGroup =item.BloodGroup,
                Address=item.Address,
                //Type = 1

            };
            return DataAccessFactory.GetAdminDataAccess().Update(admin);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetAdminDataAccess().Delete(id);
            return data;
        }


    }
}
