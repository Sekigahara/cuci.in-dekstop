using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuciin_Dekstop.Model
{
    class Customer
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string address { get; set; }
        public String created_at { get; set; }
        public String updated_at { get; set; }
        public String deleted_at { get; set; }

        public int getId()
        {
            return id;
        }

        public int userId()
        {
            return user_id;
        }

        public string getAddress()
        {
            return address;
        }
    }
}
