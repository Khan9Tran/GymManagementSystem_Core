﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    internal static class Employee
    {
        static string userID = "";
        static string userName = "";
        static string password = "";
        static string name = "";
        static int role;
        static string branchName;
        static string branchID;
        public static string UserID { get => userID; set => userID = value; }
        public static string UserName { get => userName; set => userName = value; }
        public static string Password { get => password; set => password = value; }
        public static int Role { get => role; set => role = value; }
        public static string BranchName { get => branchName; set => branchName = value; }
        public static string BranchID { get => branchID; set => branchID = value; }
        public static string Name { get => name; set => name = value; }
    }
}
