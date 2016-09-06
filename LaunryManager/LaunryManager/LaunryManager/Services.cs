using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunryManager
{
    class Services
    {
        public Services(int id, String serviceName, int price)
        {
            this.id = id;
            this.serviceName = serviceName;
            this.price = price;
        }
        public int id { get; set; }
        public String serviceName { get; set; }
        public int price { get; set; }
    }
}
