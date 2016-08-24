using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunryManager
{
    class Staff
    {
        public Staff(int id, string staffName, string account, string password)
        {
            this.id = id;
            this.staffName = staffName;
            this.account = account;
            this.password = password;
        }

        public int id { get; set; }
        public String staffName { get; set; }
        public String account { get; set; }
        public String password { get; set; }
    }
}
