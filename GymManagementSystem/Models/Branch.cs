using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    public class Branch
    {
        private string iD;
        private string name;
        private string address;

        public Branch() { }
        public Branch(string iD, string name, string address)
        {
            this.iD = iD;
            this.name = name;
            this.address = address;
        }

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
    }
}
