using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuciin_Dekstop.Model
{
    class Owner
    {
        public bool success { get; set; }
        public List<DataOwner> data { get; set; }
        public string message { get; set; }

        public bool getSuccess()
        {
            return success;
        }

        public List<DataOwner> getData()
        {
            return data;
        }

        public String getMessage()
        {
            return message;
        }
    }
}
