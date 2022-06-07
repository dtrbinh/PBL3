using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class CreateDatabase : CreateDatabaseIfNotExists<PBL3Entities>
    {
        protected override void Seed(PBL3Entities context)
        {
            context.Accounts.AddRange(new Account[]
            {
                //new Account{CMND_CCCD = "0", Username = "admin", Password = "admin123", Fullname = "Quản trị viên", Permission = true},
                //new Account{Username = "user", Password = "user", Fullname = "Nguyen User", Permission = false}
            });
            context.Citizens.AddRange(new Citizen[]
            {
                //new Citizen{CMND_CCCD = "212884000",fullName = "Nguyen Van A",  address = "Da Nang", gender = true, phone = "911", birth = DateTime.Now.Date, regisDay = DateTime.Now.Date, vaccination = 1},

            });
            context.Vaccines.AddRange(new Vaccine[]
            {
               //new Vaccine{vaccineName = "astra", quantity = 101},
               //new Vaccine{vaccineName = "verocell", quantity = 202}
            });
        }
    }
}
