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
                //new Account{Username = "admin", Password = "admin", Fullname = "Nguyen Admin", Permission = true},
                //new Account{Username = "user", Password = "user", Fullname = "Nguyen User", Permission = false}
            });
            context.Citizens.AddRange(new Citizen[]
            {
                //new Citizen{fullName = "Nguyen Van A", CMND_CCCD = "2001", address = "Da Nang", gender = true, phone = "911", birth = DateTime.Now, regisDay = DateTime.Now, vaccination = 1},

            });
            context.Vaccines.AddRange(new Vaccine[]
            {
                //new Vaccine{vaccineName = "astra", quanity = 101},
                //new Vaccine{vaccineName = "verocell", quanity = 202}
            });
        }
    }
}
