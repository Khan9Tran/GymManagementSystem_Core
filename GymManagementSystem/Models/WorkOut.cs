using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    public class WorkOut
    {
        private string iD;
        private string name;
        private string description;
        private string type;
        private int duration;

        public WorkOut(string iD, string name, string description, string type, int duration)
        {
            this.iD = iD;
            this.name = name;
            this.description = description;
            this.type = type;
            this.duration = duration;
        }

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Type { get => type; set => type = value; }
        public int Duration { get => duration; set => duration = value; }
    }
}
