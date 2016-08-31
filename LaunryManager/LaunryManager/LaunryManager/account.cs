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
        private static Staff st = null;

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

        internal static Staff St
        {
            get
            {
                return st;
            }

            set
            {
                st = value;
            }
        }
    }
}
