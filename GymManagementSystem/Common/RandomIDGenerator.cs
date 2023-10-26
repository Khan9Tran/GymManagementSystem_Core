using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem
{
    internal static class RandomIDGenerator
    {

        public static string GenerateRandomID(string tableName, string allowedChars)
        {
            int remaining = 6 - allowedChars.Length;
            string randomID = GenerateRandomString(remaining); // Tạo chuỗi ngẫu nhiên với độ dài remaining
            DBConnection conn = new DBConnection();
            conn.openConnection();

            string checkQuery = "SELECT COUNT(*) FROM " + tableName + " WHERE ID = @randomID";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn.GetConnection()))
            {
                checkCommand.Parameters.AddWithValue("@randomID", randomID);
                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0)
                {
                    randomID = GenerateRandomID(tableName, allowedChars);
                }
            }
            conn.closeConnection();

            return allowedChars + randomID;
        }

        private static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Các ký tự cho ID
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
