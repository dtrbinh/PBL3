using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    internal class Provider
    {
        private static Provider _Instance;
        public static Provider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Provider();
                }
                return _Instance;
            }
            private set { }
        }
        private Provider()
        { }
        //--------------Account------------------
        public PBL3Entities database = new PBL3Entities();
        public Account currentUser = new Account();
        public Boolean isSignIn()
        {
            if (currentUser == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean isAdmin()
        {
            if (currentUser.Permission)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //--------------Account------------------


        //--------------Citizen Data-------------
        public List<Citizen> GetAll_Citizen(string txt = "")
        {
            return database.Citizens.Where(p => p.fullName.Contains(txt)).ToList();
        }
        public Citizen GetCitizen_By_CMND(string CMND_CCCD)
        {
            return database.Citizens.Where(p => p.CMND_CCCD == CMND_CCCD).FirstOrDefault();
        }

        public bool CheckDuplicateCMND(string CMND_CCCD)
        {
            foreach (string i in database.Citizens.Select(p=>p.CMND_CCCD).ToList())
            {
                if (CMND_CCCD == i)
                {
                    return false;
                }
            }
            return true;
        }
        public void ExecuteAdd(Citizen s, string CMND_CCCD)
        {
            database.Citizens.Add(s);
            database.SaveChanges();
        }
        public void ExecuteEdit(Citizen s, string CMND_CCCD)
        {
            var x = database.Citizens.Where(p => p.CMND_CCCD == CMND_CCCD).FirstOrDefault();
            x.CMND_CCCD = s.CMND_CCCD;
            x.fullName = s.fullName;
            x.phone = s.phone;
            x.address = s.address;
            x.gender = s.gender;
            x.birth = s.birth;
            x.vaccination = s.vaccination;
            database.SaveChanges();
        }
        
        public void Delete_BLL(string CMND)
        {
            try
            {
                var x = database.Citizens.Find(CMND);
                database.Citizens.Remove(x);
                database.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        // Citizen Data Alternative View
        public List<CitizenDataAltView> FilteredViews(string txt, string Address, string Does)
        {
            if(Address == "All")
            {
                Address = "";
            }
            if(Does == "All")
            {
                Does = "";
            }            
            List<CitizenDataAltView> data = new List<CitizenDataAltView>();
            foreach (Citizen i in GetAll_Citizen(txt))
            {
                if (i.address.Contains(Address) && i.vaccination.ToString().Contains(Does))
                {
                    string convertedGender = "Male";
                    if (i.gender == false)
                    {
                        convertedGender = "Female";
                    }
                    data.Add(new CitizenDataAltView
                    {
                        fullName = i.fullName,
                        CMND_CCCD = i.CMND_CCCD,
                        gender = convertedGender,
                        birth = i.birth.ToString("MM/dd/yyyy"),
                        phone = i.phone,
                        address = i.address,
                        vaccination = i.vaccination.ToString() + " Doses Injected"
                    });
                }
            }
            return data;
        }
        // CBB Filler
        public List<string> GetCBB_Address()
        {
            return database.Citizens.Select(p => p.address).Distinct().ToList();
        }
        public List<string> GetCBB_Does()
        {
            return database.Citizens.Select(p => p.vaccination.ToString()).Distinct().ToList();
        }
        public List<CitizenDataAltView> Sort_BLL(string txt, string Address, string Does, int SortIndex, bool SortingDirection)
        {
            List<Citizen> data = new List<Citizen>();
            if(SortingDirection == true)
            {
                if (SortIndex == 0)
                {
                    var x = database.Citizens.Where(p => p.fullName.Contains(txt))
                        .OrderBy(p => p.fullName);
                    data = x.ToList();
                }
                if (SortIndex == 1)
                {
                    var x = database.Citizens.Where(p => p.fullName.Contains(txt)).ToList()
                        .OrderBy(o => int.Parse(o.CMND_CCCD));
                    data = x.ToList();


                }
                if (SortIndex == 2)
                {
                    var x = database.Citizens.Where(p => p.fullName.Contains(txt))
                        .OrderBy(p => p.birth);
                    data = x.ToList();
                }
                if (SortIndex == 3)
                {
                    var x = database.Citizens.Where(p => p.fullName.Contains(txt))
                        .OrderBy(p => p.vaccination);
                    data = x.ToList();
                }
            }
            else
            {
                if (SortIndex == 0)
                {
                    var x = database.Citizens.Where(p => p.fullName.Contains(txt))
                        .OrderByDescending(p => p.fullName);
                    data = x.ToList();
                }
                if (SortIndex == 1)
                {
                    var x = database.Citizens.Where(p => p.fullName.Contains(txt)).ToList()
                        .OrderByDescending(o => int.Parse(o.CMND_CCCD));
                    data = x.ToList();
                }
                if (SortIndex == 2)
                {
                    var x = database.Citizens.Where(p => p.fullName.Contains(txt))
                        .OrderByDescending(p => p.birth);
                    data = x.ToList();
                }
                if (SortIndex == 3)
                {
                    var x = database.Citizens.Where(p => p.fullName.Contains(txt))
                        .OrderByDescending(p => p.vaccination);
                    data = x.ToList();
                }
            }
            
            List<CitizenDataAltView> data2 = new List<CitizenDataAltView>();
            if (Address == "All")
            {
                Address = "";
            }
            if (Does == "All")
            {
                Does = "";
            }
            foreach (Citizen i in data)
            {
                if (i.address.Contains(Address) && i.vaccination.ToString().Contains(Does))
                {
                    string convertedGender = "Male";
                    if (i.gender == false)
                    {
                        convertedGender = "Female";
                    }
                    data2.Add(new CitizenDataAltView
                    {
                        fullName = i.fullName,
                        CMND_CCCD = i.CMND_CCCD,
                        gender = convertedGender,
                        birth = i.birth.ToString("MM/dd/yyyy"),
                        phone = i.phone,
                        address = i.address,
                        vaccination = i.vaccination.ToString() + " Doses Injected"
                    });
                }
            }
            return data2;
        }
        


        //--------------Vaccine Data-------------
        public List<Vaccine> GetAll_Vaccine(string txt = "")
        {
            return database.Vaccines.Where(p => p.vaccineName.Contains(txt)).ToList();
        }
        public Vaccine GetVaccine_By_Name(string name)
        {
            return database.Vaccines.Where(p => p.vaccineName == name).FirstOrDefault();
        }
        public void ExecuteAdd(Vaccine v, string name)
        {
            database.Vaccines.Add(v);
            database.SaveChanges();
        }
        public void ExecuteEdit(Vaccine v, string name)
        {
            var x = database.Vaccines.Where(p => p.vaccineName == name).FirstOrDefault();
            x.vaccineName = v.vaccineName;
            x.quantity = v.quantity;
            database.SaveChanges();
        }
        public bool CheckAddEdit_Vaccine(string name)
        {
            foreach (Vaccine i in database.Vaccines.ToList())
            {
                if (name == i.vaccineName)
                {
                    return false;
                }
            }
            return true;
        }
        public void Delete_BLL_Vaccine(string name)
        {
            try
            {
                var x = database.Vaccines.Find(name);
                database.Vaccines.Remove(x);
                database.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        // Citizen Data Alternative View
        public List<VaccineDataAltView> FilteredViews(string txt, string search)
        {
            if (txt == "All")
            {
                txt = "";
            }
            List<VaccineDataAltView> data = new List<VaccineDataAltView>();
            foreach (Vaccine i in GetAll_Vaccine(txt))
            {
                if (i.vaccineName.Contains(txt) && i.quantity.ToString().Contains(search))
                {                   
                    data.Add(new VaccineDataAltView
                    {
                        vaccineName = i.vaccineName,
                        quantity = i.quantity
                    });
                }
            }
            return data;
        }
        // CBB Filler
        public List<string> GetCBB_Filter()
        {
            return database.Vaccines.Select(p => p.vaccineName).Distinct().ToList();
        }
        public List<VaccineDataAltView> Sort_BLL(string txt, int SortIndex, bool SortingDirection)
        {
            List<Vaccine> data = new List<Vaccine>();

            if (SortingDirection == true)
            {
                if (SortIndex == 0)
                {
                    var x = database.Vaccines.Where(p => p.vaccineName.Contains(txt))
                        .OrderBy(p => p.vaccineName);
                    data = x.ToList();
                }
                if (SortIndex == 1)
                {
                    var x = database.Vaccines.Where(p => p.vaccineName.Contains(txt))
                        .OrderBy(p => p.quantity);
                    data = x.ToList();
                }
            }
            else
            {
                if (SortIndex == 0)
                {
                    var x = database.Vaccines.Where(p => p.vaccineName.Contains(txt))
                        .OrderByDescending(p => p.vaccineName);
                    data = x.ToList();
                }
                if (SortIndex == 1)
                {
                    var x = database.Vaccines.Where(p => p.vaccineName.Contains(txt))
                        .OrderByDescending(p => p.quantity);
                    data = x.ToList();
                }
            }
            List<VaccineDataAltView> data2 = new List<VaccineDataAltView>();
            foreach (Vaccine i in data)
            {
                data2.Add(new VaccineDataAltView
                {
                    vaccineName = i.vaccineName,
                    quantity = i.quantity
                }); 
            }
            return data2;
        }

        public bool CheckDuplicate_VaccineName(string name)
        {
            foreach (string i in database.Vaccines.Select(p => p.vaccineName).ToList())
            {
                if (name == i)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
