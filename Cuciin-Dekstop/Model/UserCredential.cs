using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuciin_Dekstop.Model
{
    class UserCredential
    {
        public bool success { get; set; }
        public UserCredentialData data { get; set; }
        public string message { get; set; }

        public UserCredentialData getData()
        {
            return data;
        }
    }
}
