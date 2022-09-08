using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UseRegistration
{
    internal class RegexClass
    {
        public Regex FirstNameRegex = new Regex(@"[A-Z]{1}[A-z a-z]{2,}");
        public Regex LastNameRegex = new Regex(@"[A-Z]{1}[A-z a-z]{2,}");
        public Regex EmailRegex = new Regex(@"^[a-z A-Z 0-9 .+_-]+@[a-z A-Z 0-9 -.]+[.][a-z A-Z 0-9 -]{2,}$");
        public Regex MobileNumberRegex = new Regex(@"[0-9]{1,2}\s[0-9]{10}");
        public Regex PasswordMin8CharRegex = new Regex(@"[A-Z a-z 0-9]{8,}");
        public Regex PasswordMin8Char2Regex = new Regex(@"(?=.*[A-Z])[A-Za-z0-9]{8,}");
        public Regex PasswordMin8Char3Regex = new Regex(@"(?=.*[0-9])[A-Za-z0-9]{8,}");
        public Regex PasswordMin8Char4Regex = new Regex(@"(?=.*[#?!@$%^&*-])[A-Za-z0-9].{8,}");

    }
}


