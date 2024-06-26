﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    internal class WorkOutPlan
    {
        private string iD;
        private string memberID;
        private string trainerID;
        private string branchID;
        private TimeSpan time;
        private DateTime date;

        public WorkOutPlan() { }

        public string ID { get => iD; set => iD = value; }
        public string MemberID { get => memberID; set => memberID = value; }
        public string TrainerID { get => trainerID; set => trainerID = value; }
        public string BranchID { get => branchID; set => branchID = value; }
        public TimeSpan Time { get => time; set => time = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
