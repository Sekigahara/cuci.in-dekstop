using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuciin_Dekstop.Model
{
    class Outlet
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public double rating { get; set; }
        public string laundry_type { get; set; }
        public string manhours { get; set; }
        public int owner_id { get; set; }
        public String created_at { get; set; }
        public String updated_at { get; set; }
        public String deleted_at { get; set; }
    }
}
