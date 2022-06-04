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

        public void ExecuteAddEdit(Citizen s, string CMND_CCCD)
        {
            if (CheckAddEdit(s.CMND_CCCD))
            {
                database.Citizens.Add(s);
                database.SaveChanges();
            }
            else
            {
                var x = database.Citizens.Where(p => p.CMND_CCCD == CMND_CCCD).FirstOrDefault();
                x.CMND_CCCD = s.CMND_CCCD;
                x.fullName = s.fullName;
                x.phone = s.phone;
                x.address = s.address;
                x.gender = s.gender;
                x.birth = s.birth;
                x.vaccination = s.vaccination;
                x.regisDay = s.regisDay;
                database.SaveChanges();
            }
        }
        public bool CheckAddEdit(string CMND_CCCD)
        {
            foreach (Citizen i in database.Citizens.ToList())
            {
                if (CMND_CCCD == i.CMND_CCCD)
                {
                    return false;
                }
            }
            return true;
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
                        vaccination = i.vaccination.ToString() + " Does Injected",
                        regisDay = i.regisDay.ToString("MM/dd/yyyy"),
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
        public List<CitizenDataAltView> Sort_BLL(string txt, string Address, string Does, int SortIndex)
        {
            List<Citizen> data = new List<Citizen>();
            if (SortIndex == 0)
            {
                var x = database.Citizens.Where(p => p.fullName.Contains(txt))
                    .OrderBy(p => p.fullName);
                data = x.ToList();
            }
            if (SortIndex == 1)
            {
                var x = database.Citizens.Where(p => p.fullName.Contains(txt))
                    .OrderBy(p => p.address);
                data = x.ToList();
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
                        vaccination = i.vaccination.ToString() + " Does Injected",
                        regisDay = i.regisDay.ToString("MM/dd/yyyy"),
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
        public void ExecuteAddEdit(Vaccine v, string name)
        {
            if (CheckAddEdit_Vaccine(v.vaccineName))
            {
                database.Vaccines.Add(v);
                database.SaveChanges();
            }
            else
            {
                var x = database.Vaccines.Where(p => p.vaccineName == name).FirstOrDefault();
                x.vaccineName = v.vaccineName;
                x.quanity = v.quanity;
                database.SaveChanges();
            }
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
                if (i.vaccineName.Contains(txt) && i.quanity.ToString().Contains(search))
                {                   
                    data.Add(new VaccineDataAltView
                    {
                        vaccineName = i.vaccineName,
                        quanity = i.quanity
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
        public List<VaccineDataAltView> Sort_BLL(string txt, int SortIndex)
        {
            List<Vaccine> data = new List<Vaccine>();
            if (SortIndex == 0)
            {
                var x = database.Vaccines.Where(p => p.vaccineName.Contains(txt))
                    .OrderBy(p => p.vaccineName);
                data = x.ToList();
            }
            if (SortIndex == 1)
            {
                var x = database.Vaccines.Where(p => p.vaccineName.Contains(txt))
                    .OrderBy(p => p.quanity);
                data = x.ToList();
            }
            List<VaccineDataAltView> data2 = new List<VaccineDataAltView>();
            foreach (Vaccine i in data)
            {
                data2.Add(new VaccineDataAltView
                {
                    vaccineName = i.vaccineName,
                    quanity = i.quanity
                }); 
            }
            return data2;
        }
    }
}
