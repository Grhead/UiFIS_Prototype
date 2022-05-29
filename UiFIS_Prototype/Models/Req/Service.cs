using System.Windows.Controls;
using UiFIS_Prototype.ViewModel;

namespace UiFIS_Prototype.Models.Req
{
    public class Service
    {
        public static ECardContext db = new ECardContext();
        private static Person clientSession = new Person();
        private static CreateEMC cemc = new CreateEMC();
        private static DoctorNavigationViewModel dnvm = new DoctorNavigationViewModel();
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
        public static DoctorNavigationViewModel DNVM
        {
            get => dnvm;
            set => dnvm = value;
        }
    }
}
