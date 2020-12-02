using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuciin_Dekstop.Model
{
    class DataUser
    {
        public string token { get; set; }
        public int id { get; set; }

        public String getToken()
        {
            return token;
        }

        public int getId()
        {
            return id;
        }
    }
}
