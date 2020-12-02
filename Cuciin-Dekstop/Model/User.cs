using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuciin_Dekstop.Model
{
    class User
    {
        public bool success { get; set; }
        public DataUser data { get; set; }
        public string message { get; set; }

        public String getMessage()
        {
            return message;
        }

        public DataUser getData()
        {
            return data;
        }

        public bool getSuccess()
        {
            return success;
        }
    }
}
