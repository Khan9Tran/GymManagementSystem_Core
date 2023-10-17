using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    internal class Member
    {
        private string iD;
        private string name;
        private string gender;
        private string phoneNumber;
        private string packageID;
        private DateTime endOfPackageDate;
        private string remainingTS;
        private string membershipTypeID;
        private string address;
        private Decimal balance;

        public Member() { }
        public Member(string iD, string name, string gender, string phoneNumber, string packageID, DateTime endOfPackageDate, string remainingTS, string membershipTypeID, string address, decimal balance)
        {
            this.iD = iD;
            this.name = name;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.packageID = packageID;
            this.endOfPackageDate = endOfPackageDate;
            this.remainingTS = remainingTS;
            this.membershipTypeID = membershipTypeID;
            this.address = address;
            this.balance = balance;
        }

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string PackageID { get => packageID; set => packageID = value; }
        public DateTime EndOfPackageDate { get => endOfPackageDate; set => endOfPackageDate = value; }
        public string RemainingTS { get => remainingTS; set => remainingTS = value; }
        public string MembershipTypeID { get => membershipTypeID; set => membershipTypeID = value; }
        public string Address { get => address; set => address = value; }
        public decimal Balance { get => balance; set => balance = value; }
    }
}
