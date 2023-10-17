using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    public class Trainer
    {

        private string iD;
        private string name;
        private string address;
        private string phoneNumber;
        private string gender;
        private string branchID;

        public Trainer()
        {

        }
        public Trainer(string iD, string name, string address, string phoneNumber, string gender, string branchID)
        {
            this.ID = iD;
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Gender = gender;
            this.BranchID = branchID;
        }

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Gender { get => gender; set => gender = value; }
        public string BranchID { get => branchID; set => branchID = value; }
    }
}
