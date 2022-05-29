using System.Linq;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype.ViewModel
{
    public class ProfileAndMoreViewModel : StaticViewModel
    {
        public ProfileAndMoreViewModel()
        {
            if (Service.DNVM.SelectedRecord != null)
            {
                PersonX = Service.db.People.FirstOrDefault(x => x.Id == Service.DNVM.SelectedRecord.Patient);
                Pass = Service.db.Passports.FirstOrDefault(x => x.Id == Service.DNVM.SelectedRecord.PatientNavigation.Passport);
            }
        }
        private Person _person;
        public Person PersonX
        {
            get { return _person; }
            set { _person = value; }
        }
        private Passport _pass;
        public Passport Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }
    }
}
