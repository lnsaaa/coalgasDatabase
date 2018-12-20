using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coalgasOS
{
    class DataClass
    {

        private static string userAa = "ro";
        private static string userName = "xxx";
        private static string sel = "client";

        public static string userAaData
        {
            get
            {
                return userAa;
            }
            set
            {
                userAa = value;
            }
        }

        public static string userNameData
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public static string selData
        {
            get
            {
                return sel;
            }
            set
            {
                sel = value;
            }
        }

    }
}
