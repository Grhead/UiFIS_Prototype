using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype.ViewModel
{
    public class CreateEMC : StaticViewModel
    {
        public CreateEMC()
        {
            BloodGroups = new List<BloodGroup>(Service.db.BloodGroups);
            Genders = new List<Gender>(Service.db.Genders);
            Sides = new List<Side>(Service.db.Sides);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string Police { get; set; }
        public string Phone { get; set; }
        public string Blood { get; set; }
        public List<BloodGroup> BloodGroups { get; set; }
        public string Gender { get; set; }
        public List<Gender> Genders { get; set; }
        public DateTime BirthDay { get; set; }
        public int Series { get; set; }
        public int Number { get; set; }
        public int DivisionCode { get; set; }
        public string Division { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string Side { get; set; }
        public List<Side> Sides { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }

    }
}
