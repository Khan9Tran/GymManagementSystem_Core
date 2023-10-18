using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    internal class PlanDetails
    {
        private string workOutPlanID;
        private string workOutID;

        public PlanDetails() { }

        public string WorkOutPlanID { get => workOutPlanID; set => workOutPlanID = value; }
        public string WorkOutID { get => workOutID; set => workOutID = value; }
    }
}
