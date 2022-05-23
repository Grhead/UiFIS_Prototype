using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UiFIS_Prototype.Models.Req
{
    public class Service
    {
        public static ECardContext db = new ECardContext();
        private static Person clientSession = new Person();
        public static Frame frame;
        public static Person ClientSession
        {
            get => clientSession;
            set => clientSession = value;

        }
    }
}
