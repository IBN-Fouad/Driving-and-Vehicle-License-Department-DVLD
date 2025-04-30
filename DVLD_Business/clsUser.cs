using System;
using System.Data;
using DVLD_DataAccess;
using System.Runtime.InteropServices;
using System.Diagnostics.SymbolStore;
using System.Dynamic;

namespace DVLD_Business
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string Username, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.UserName = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            //call DataAccess Layer
            this.UserID = clsUserData.AddNewUser(this.UserName, this.Password, this.IsActive, this.PersonID);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            //call DataAccess Layer
            return clsUserData.UpdateUser(this.UserID, this.UserName, this.Password, this.IsActive, this.PersonID);
        }

        public static clsUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            string 
                UserName = "",
                Password = "";

            bool IsActive = false;

            if(clsUserData.GetUserInfoByUserID(UserID, ref UserName, ref Password, ref IsActive, ref PersonID))
                // We return new object of that User with the right data
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }

        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string
                UserName = "",
                Password = "";
            bool IsActive = false;

            if (clsUserData.GetUserInfoByPersonID(ref UserID, ref UserName, ref Password, ref IsActive, PersonID))
                //we return new object of that User with the right data
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
        
        public static clsUser FindByUserNameAndPassword(string UserName, string Password)
        {
            int
                UserID = -1,
                PersonID = -1;
            bool IsActive = false;

            if (clsUserData.GetUserInfoByUserNameAndPassword(ref UserID, UserName, Password, ref IsActive, ref PersonID))
                //we return new object of that User with the right data
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false; 
                    }

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            return clsUserData.IsUserExistForPersonID(PersonID);
        }

    }
}