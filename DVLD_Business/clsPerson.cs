using System;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public DateTime DateOfBirth { set; get; }
        public short Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public clsCountry CountryInfo { set; get; }
        
        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.ImagePath = "";
            this.NationalityCountryID = -1;

            Mode = enMode.AddNew;
        }

        private clsPerson
            (
                int PersonID,
                string NationalNo, 
                string FirstName, 
                string SecondName, 
                string ThirdName, 
                string LastName, 
                DateTime DateOfBirth, 
                short Gender, 
                string Address,
                string Phone,
                string Email,
                string ImagePath,
                int NationalityCountryID
            )
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.ImagePath = ImagePath;
            this.NationalityCountryID = NationalityCountryID;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);

            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson
                (
                    this.FirstName,
                    this.NationalNo,
                    this.SecondName,
                    this.ThirdName,
                    this.LastName,
                    this.DateOfBirth,
                    this.Gender,
                    this.Address,
                    this.Phone,
                    this.Email,
                    this.ImagePath,
                    this.NationalityCountryID
                );

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson
                (
                    this.PersonID,
                    this.NationalNo,
                    this.FirstName,
                    this.SecondName,
                    this.ThirdName,
                    this.LastName,
                    this.DateOfBirth,
                    this.Gender,
                    this.Address,
                    this.Phone,
                    this.Email,
                    this.ImagePath,
                    this.NationalityCountryID
                );
        }

        public static clsPerson Find(int PersonID)
        {
            string
                NationalNo = "",
                FirstName = "",
                SecondName = "",
                ThirdName = "",
                LastName = "",
                Address = "",
                Phone = "",
                Email = "",
                ImagePath = "";
            
            DateTime DateOfBirth = DateTime.Now;

            short Gender = 0;

            int NationalityCountryID = -1;

            bool IsFound = clsPersonData.GetPersonInfoID
            (
                PersonID,
                ref NationalNo,
                ref FirstName,
                ref SecondName,
                ref ThirdName,
                ref LastName,
                ref DateOfBirth,
                ref Gender,
                ref Address,
                ref Phone,
                ref Email,
                ref ImagePath,
                ref NationalityCountryID
            );

            if (IsFound)
                return new clsPerson(
                    PersonID,
                    NationalNo,
                    FirstName,
                    SecondName,
                    ThirdName,
                    LastName,
                    DateOfBirth,
                    Gender,
                    Address,
                    Phone,
                    Email,
                    ImagePath,
                    NationalityCountryID
                );
            else
                return null;
        }

        public static clsPerson Find(string NationalNo)
        {
            string
                FirstName = "",
                SecondName = "",
                ThirdName = "",
                LastName = "",
                Address = "",
                Phone = "",
                Email = "",
                ImagePath = "";
            
            DateTime DateOfBirth = DateTime.Now;

            short Gender = 0;

            int
                PersonID = -1,
                NationalityCountryID = -1;

            bool IsFound = clsPersonData.GetPersonInfoNationalNo
            (
                NationalNo,
                ref PersonID,
                ref FirstName,
                ref SecondName,
                ref ThirdName,
                ref LastName,
                ref DateOfBirth,
                ref Gender,
                ref Address,
                ref Phone,
                ref Email,
                ref ImagePath,
                ref NationalityCountryID
            );

            if (IsFound)
                return new clsPerson(
                    PersonID,
                    NationalNo,
                    FirstName,
                    SecondName,
                    ThirdName,
                    LastName,
                    DateOfBirth,
                    Gender,
                    Address,
                    Phone,
                    Email,
                    ImagePath,
                    NationalityCountryID
                );
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

        public static bool IsPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }
    }
}