using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuciin_Dekstop.Model
{
    class HistoryData
    {
        public String transaction_id { get; set; }
        public DateTime date { get; set; }
        public String name { get; set; }
        public String phone { get; set; }
        public double amount { get; set; }

        public HistoryData(String transaction_id, DateTime date, String name, String phone, double amount)
        {
            this.transaction_id = transaction_id;
            this.date = date;
            this.name = name;
            this.phone = phone;
            this.amount = amount;
        }

        public String getTransactionId()
        {
            return transaction_id;
        }

        public DateTime getDate()
        {
            return date;
        }

        public String getName()
        {
            return name;
        }

        public String getPhone()
        {
            return phone;
        }

        public double getAmount()
        {
            return amount;
        }
    }
}
