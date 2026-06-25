using ContactsDataAccessLayer;
using System;
using System.Data;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;

namespace ContactsBusinessLayer
{
    public class Contacts
    {
        
        public int ID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ImagePath { get; set; }
        public int CountryID { get; set; }
        private Contacts(int ID,string firstName, string lastName, string email, string phone, string address, DateTime dateOfBirth, string imagePath, int CountryID)
        {
            this.ID = ID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
            DateOfBirth = dateOfBirth;
            ImagePath = imagePath;
            this.CountryID = CountryID;
            
        }
        public Contacts() : this(-1, "", "", "", "", "", DateTime.Now, "", -1)
        {
           
        }

        public static Contacts Find(int ID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            int CountryID = 0;
            DateTime DateOfBirth = DateTime.Now;


            if (ContactsdataAccessLayer.findContactByID(ID, ref FirstName, ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath, ref CountryID))
            {
                return new Contacts(ID, FirstName, LastName, Email, Phone, Address, DateOfBirth, ImagePath, CountryID);
            }
            else
                return null;
        }
        private bool addNewContact()
        {
            this.ID = ContactsdataAccessLayer.addNewContact(this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth, this.ImagePath, this.CountryID);

            return this.ID != -1;

        }

        private bool updateContact()
        {
            return ContactsdataAccessLayer.updateContact(this.ID, this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth, this.ImagePath, this.CountryID);
        }
        public bool saveContact()
        {
           
                if(this.ID ==-1)
                {

                    if (addNewContact())
                    {

                        return true;
                    }
                    else
                        return false;
                }
            else
                return updateContact();

        }

        public static bool isContactExist(int contactID)
        {
            return ContactsdataAccessLayer.isContactExist(contactID);
        }
        
        public static bool deleteContact(int contactID)
        {
             return ContactsdataAccessLayer.deleteContact(contactID);
  
        }
            
        public static DataTable getAllContacts()
        {
            return ContactsdataAccessLayer.listContacts();
        }

        public static DataTable getContactsByCountryID(int CountryID)
        {
            return ContactsdataAccessLayer.getContactsByCountryID(CountryID);
        }
    }
}
