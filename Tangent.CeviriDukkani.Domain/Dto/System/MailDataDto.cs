using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangent.CeviriDukkani.Domain.Dto.System
{
    public class MailDataDto
    {
        public class Register
        {
            public string UserName { get; set; }
            public string EMail { get; set; }
            public string Pass { get; set; }
        }

        public class ResetPassword
        {
            public string UserName { get; set; }
            public string ResetLink { get; set; }

        }

        public class ForgetPassword
        {
            public string UserName { get; set; }
            public string EMail { get; set; }
            public string Pass { get; set; }
        }

        public class UserActivation
        {
            public string UserName { get; set; }
            public string RegisterLink { get; set; }
            public string Comment { get; set; }
        }
    }
}
