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
        {}
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

    }

}
