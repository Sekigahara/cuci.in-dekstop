using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuciin_Dekstop.Model
{
    class Transaction
    {
        public bool success { get; set; }
        public List<DataTransaction> data { get; set; }
        public string message { get; set; }

        public bool getSuccess()
        {
            return success;
        }

        public List<DataTransaction> getData()
        {
            return data;
        }

        public string getMessage()
        {
            return message;
        }
    }
}
