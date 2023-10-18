using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    internal class MembershipType
    {
        private string iD;
        private double rate;
        private string rank;

        public MembershipType() { }

        public string ID { get => iD; set => iD = value; }
        public double Rate { get => rate; set => rate = value; }
        public string Rank { get => rank; set => rank = value; }
    }
}
