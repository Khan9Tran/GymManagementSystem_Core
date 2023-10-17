using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    internal static class Employee
    {
        static string userName = "";
        static string password = "";
        static int role;

        public static string UserName { get => userName; set => userName = value; }
        public static string Password { get => password; set => password = value; }
        public static int Role { get => role; set => role = value; }
    }
}
