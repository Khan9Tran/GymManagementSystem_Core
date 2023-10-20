using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    public class MembershipType
    {
        private string iD;
        private float rate;
        private string rank;

        public MembershipType() { }

        public MembershipType(string iD, float rate, string rank)
        {
            this.iD = iD;
            this.rate = rate;
            this.rank = rank;
        }

        public string ID { get => iD; set => iD = value; }
        public float Rate { get => rate; set => rate = value; }
        public string Rank { get => rank; set => rank = value; }
    }
}
