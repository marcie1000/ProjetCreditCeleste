using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculeNeufOccasion
    {
    static class PasswordHelper
    {
        public static string hashPassword(string plainTextPassword)
        {
            string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(plainTextPassword, 13);
            return passwordHash;
        }
    }
}
