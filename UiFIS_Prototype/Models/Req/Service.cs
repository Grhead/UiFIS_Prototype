using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UiFIS_Prototype.ViewModel;

namespace UiFIS_Prototype.Models.Req
{
    public class Service
    {
        public static ECardContext db = new ECardContext();
        private static Person clientSession = new Person();
        private static CreateEMC cemc = new CreateEMC();
        public static Frame frame;
        public static Person ClientSession
        {
            get => clientSession;
            set => clientSession = value;

        }
        public static CreateEMC CEMC
        {
            get => cemc;
            set => cemc = value;
        }
    }
}
