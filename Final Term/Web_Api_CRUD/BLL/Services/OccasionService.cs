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
    public class OccasionService
    {
        public static List<OccasionModel> Get()
        {
            var data = DataAccessFactory.GetOccasionDataAccess().Get();
            var rdata = new List<OccasionModel>();

            foreach (var item in data)
            {
                rdata.Add(new OccasionModel()
                {
                    OC_Id = item.OC_Id,
                    OC_Name = item.OC_Name,
                    OC_Description = item.OC_Description,
                    OC_Date = item.OC_Date,
                    OC_Time = item.OC_Time,

                });

            }
            return rdata;
        }

        public static OccasionModel Get(int id)
        {
            var data = DataAccessFactory.GetOccasionDataAccess().Get(id);
            var rdata = new OccasionModel();
            rdata.OC_Id = data.OC_Id;
            rdata.OC_Name = data.OC_Name;
            rdata.OC_Description = data.OC_Description;
            rdata.OC_Date = data.OC_Date;
            rdata.OC_Time = data.OC_Time;


            return rdata;
        }



        public static bool Create(OccasionModel item)
        {
            var Occasion = new Occasion_Table()
            {
                OC_Name = item.OC_Name,
                OC_Description = item.OC_Description,
                OC_Date = item.OC_Date,
                OC_Time = item.OC_Time,


            };
            return DataAccessFactory.GetOccasionDataAccess().Create(Occasion);
        }

        public static bool Update(OccasionModel item)
        {
            var Occasion = new Occasion_Table()
            {
                OC_Id = item.OC_Id,
                OC_Name = item.OC_Name,
                OC_Description = item.OC_Description,
                OC_Date = item.OC_Date,
                OC_Time = item.OC_Time,


            };
            return DataAccessFactory.GetOccasionDataAccess().Update(Occasion);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetOccasionDataAccess().Delete(id);
            return data;
        }
    }
}
