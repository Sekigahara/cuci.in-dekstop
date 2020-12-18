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
        public int rating { get; set; }
        public string laundry_type { get; set; }
        public string manhours { get; set; }
        public int owner_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object deleted_at { get; set; }
    }
}
