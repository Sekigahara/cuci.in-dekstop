using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuciin_Dekstop.Model
{
    class DataOwner
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object deleted_at { get; set; }

        public int getId()
        {
            return id;
        }

        public int getUserid()
        {
            return user_id;
        }
    }
}
