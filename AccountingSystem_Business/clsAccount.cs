using System;
using System.Data;
using AccountingSystem_Business;
using Ebda3Soft_DataAccess;

namespace Ebda3Soft_Business
{
    public class clsAccount
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enAccountType
        {
            Customer = 0,
            Supplier = 1,
            Employee = 2,
            ServiceProvider = 3,
            Partner = 4
        };
        public int AccountID { set; get; }
        public string Name { set; get; }
        public int PersonID { set; get; }
        public byte Type { set; get; }

        // composition relation to access person information related to this account
        public clsPerson PersonInfo;
        public string GetAccountTypeText
        {
            get
            {
                switch ((enAccountType)Type)
                {
                    case enAccountType.Customer:
                        return "عميل";
                    case enAccountType.Supplier:
                        return "مورد";
                    case enAccountType.Employee:
                        return "موظف";
                    case enAccountType.ServiceProvider:
                        return "مزود خدمة";
                    case enAccountType.Partner:
                        return "شريك";
                    default:
                        return "غير محدد";
                }
            }
        }
        public clsAccount()
        {
            this.AccountID = -1;
            this.Name = "";
            this.PersonID = -1;
            this.Type = 0;

            Mode = enMode.AddNew;
        }

        private clsAccount(int AccountID, string Name, int PersonID, byte Type)
        {
            this.AccountID = AccountID;
            this.Name = Name;
            this.PersonID = PersonID;
            this.Type = Type;

            if (this.PersonID != -1)
                this.PersonInfo = clsPerson.Find(this.PersonID);

            Mode = enMode.Update;
        }

        private bool _AddNewAccount()
        {
            this.AccountID = clsAccountData.AddNewAccount(this.Name, this.PersonID, this.Type);

            return (this.AccountID != -1);
        }

        private bool _UpdateAccount()
        {
            return clsAccountData.UpdateAccount(this.AccountID, this.Name, this.PersonID, this.Type);
        }

        public static clsAccount Find(int AccountID)
        {
            string Name = "";
            int PersonID = -1;
            byte Type = 0;

            bool isFound = clsAccountData.GetAccountInfoByID(AccountID, ref Name, ref PersonID, ref Type);

            if (isFound)
                return new clsAccount(AccountID, Name, PersonID, Type);
            else
                return null;
        }
        
        public static clsAccount Find(string AccountName)
        {
            int AccountID = -1;
            int PersonID = -1;
            short AccountType = 0;

            if (clsAccountData.GetAccountInfoByName(AccountName, ref AccountID, ref PersonID, ref AccountType))
            {
                return new clsAccount(AccountID, AccountName, PersonID, (byte)AccountType);
            }
            else
            {
                return null;
            }
        }
        
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAccount())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateAccount();
            }

            return false;
        }

        public static DataTable GetAllAccounts()
        {
            return clsAccountData.GetAllAccounts();
        }

        public static bool DeleteAccount(int ID)
        {
            return clsAccountData.DeleteAccount(ID);
        }

        public static bool IsAccountExist(int ID)
        {
            return clsAccountData.IsAccountExist(ID);
        }

        public static DataTable GetStatement(int AccountID)
        {
            return clsAccountData.GetAccountStatement(AccountID);
        }
    }
}