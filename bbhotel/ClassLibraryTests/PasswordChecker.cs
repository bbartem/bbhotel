using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryTests
{
    public class PasswordChecker
    {
        public static bool ValidatePassword(string password)
        {
            var regex = new Regex(@"([a - z])");
            var regex2 = new Regex(@"([a-zA-Z])");
            var regex1 = new Regex(@"([0 - 9])");
            var regex3 = new Regex(@"([!,@,#,$,%,^,&,*,?,_,~])");
            if (password.Length >= 8 && regex1.IsMatch(password) && regex2.IsMatch(password) && regex3.IsMatch(password))
            {
                return false;
            }
            if (password.Length >= 8 && regex1.IsMatch(password) && regex2.IsMatch(password))
            {
                return false;
            }
            if (password.Length >= 8 && regex2.IsMatch(password))
            {
                return false;
            }
            if (password.Length < 8 && regex.IsMatch(password))
            {
                return false;
            }
            return true;
        }
    }
}
