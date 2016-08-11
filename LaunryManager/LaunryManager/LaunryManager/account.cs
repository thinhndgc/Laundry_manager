using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunryManager
{
    class Global
    {
        private static String _accountType = "";
        private static String _accountName = "";

        public static string AccountType
        {
            get
            {
                return _accountType;
            }

            set
            {
                _accountType = value;
            }
        }

        public static string AccountName
        {
            get
            {
                return _accountName;
            }

            set
            {
                _accountName = value;
            }
        }
    }
}
