using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    internal class BMI
    {
        private string iD;
        private string memberID;
        private int height;
        private decimal weight;
        private DateTime date;
        private string status;

        public BMI() { }

        public string ID { get => iD; set => iD = value; }
        public string MemberID { get => memberID; set => memberID = value; }
        public int Height { get => height; set => height = value; }
        public decimal Weight { get => weight; set => weight = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Status { get => status; set => status = value; }
    }
}
