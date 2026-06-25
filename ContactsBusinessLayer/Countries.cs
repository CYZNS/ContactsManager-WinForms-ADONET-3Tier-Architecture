using ContactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ContactsBusinessLayer
{
    public class Countries
    {
        enum enmode {AddNew =0 , update =1 };
        enmode Mode = enmode.AddNew;
        public int CountryID { get; private set; }
        public string CountryName { get; set; }
        public string Code { get; set; }
        public string PhoneCode { get; set; }
        private Countries(int CountryID, string CountryName,string code, string PhoneCode )
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            this.Code = code;
            this.PhoneCode = PhoneCode;
            Mode = enmode.update;
        }
        public Countries() : this(-1, "","","")
        {
            Mode = enmode.AddNew;
        }

        public static Countries Find(int ID)
        {
            string CountryName = "";
            string Code = "";
            string PhoneCode = "";

            if (CountrydataAccessLayer.findCountryByID(ID ,ref CountryName, ref Code , ref PhoneCode))
            {
                return new Countries(ID,CountryName,Code, PhoneCode);
            }
            else
                return null;
        }
        public static Countries Find(string countryName)
        {
           int CountryID = -1;
            string Code = "";
            string PhoneCode = "";
            if (CountrydataAccessLayer.findCountryByName(countryName, ref CountryID, ref Code , ref PhoneCode))
            {
                return new Countries(CountryID, countryName,Code , PhoneCode);
            }
            else
                return null;
        }

        private bool addNewCountry()
        {
            this.CountryID = CountrydataAccessLayer.addNewCountry(this.CountryName,this.Code,this.PhoneCode);

            return this.CountryID != -1;

        }

        private bool updateCountry()
        {
            return CountrydataAccessLayer.updateCountry(this.CountryID, this.CountryName,this.Code,this.PhoneCode);
        }
        public bool saveCountry()
        {
            switch (Mode)
            {
                case enmode.AddNew:
                    if (addNewCountry())
                    {
                        Mode = enmode.update;
                        return true;
                    }
                    else
                        return false;

                case enmode.update:
                    return updateCountry();

            }
            return false;

        }

        public static bool isCountryExist(int countryID)
        {
            return CountrydataAccessLayer.isCountryExist(countryID);
        }
        public static bool isCountryExist(string countryName)
        {
            return CountrydataAccessLayer.isCountryExist(countryName);
        }

        public static bool deleteCountry(int countryID)
        {
            return CountrydataAccessLayer.deleteCountry(countryID);

        }

        public static DataTable getAllCountries()
        {
            return CountrydataAccessLayer.listCountries();
        }

        

    }
}
