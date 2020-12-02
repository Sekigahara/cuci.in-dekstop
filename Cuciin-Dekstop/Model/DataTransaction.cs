using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuciin_Dekstop.Model
{
    class DataTransaction
    {
        public int id { get; set; }
        public string po_number { get; set; }
        public string address { get; set; }
        public Double? price { get; set; }
        public Double? amount { get; set; }
        public string laundry_type { get; set; }
        public String status { get; set; }
        public int customer_id { get; set; }
        public int outlet_id { get; set; }
        public String created_at { get; set; }
        public String updated_at { get; set; }
        public String deleted_at { get; set; }
        public Customer customer { get; set; }
        public Outlet outlet { get; set; }

        public int getId()
        {
            return id;
        }

        public string getPoNumber()
        {
            return po_number;
        }

        public string getAddress()
        {
            return address;
        }

        public void setPrice(Double? price)
        {
            this.price = price;
        }

        public Double? getPrice()
        {
            return price;
        }

        public void setAmount(Double? amount)
        {
            this.amount = amount;
        }

        public Double? getAmount()
        {
            return amount;
        }

        public string getLaundryType()
        {
            return laundry_type;
        }

        public String getStatus()
        {
            return status;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }

        public void setAmount(int amount)
        {
            this.amount = amount;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getCustomerId() {
            return customer_id;
        }

        public int getOutletId()
        {
            return outlet_id;
        }

        public String getCreatedAt()
        {
            return created_at;
        }

        public Customer getCustomer()
        {
            return customer;
        }

        public Outlet getOutlet()
        {
            return outlet;
        }
    }    
}
