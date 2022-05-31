using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    internal class CreateDB : CreateDatabaseIfNotExists<PBL3Entities>
    {
        protected override void Seed(PBL3Entities context)
        {
            context.Accounts.AddRange(new Account[]
            {
                new Account{CMND = "191919", Fullname = "Nguyen Van Admin" , Username = "admin", Password = "admin" ,  Permission = true},
                new Account{CMND = "202020", Fullname = "Le Thi User", Username = "user", Password = "user" ,  Permission = false}
            });
            context.Vaccines.AddRange(new Vaccine[]
            {
                new Vaccine{VaccineName = "Verocell", Quantity = 200},
                new Vaccine{VaccineName = "SuperCovid", Quantity = 100}
            });
            
        }
    }
}
