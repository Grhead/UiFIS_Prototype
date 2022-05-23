using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiFIS_Prototype.Models.Req;
using UiFIS_Prototype.Views.Pages;

namespace UiFIS_Prototype.ViewModel
{
    public class CreateEMC : StaticViewModel
    {
        public CreateEMC()
        {
            BloodGroupsx = new List<BloodGroup>(Service.db.BloodGroups);
            Gendersx  = new List<Gender>(Service.db.Genders);
            Sides = new List<Side>(Service.db.Sides);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string Police { get; set; }
        public string Phone { get; set; }
        private BloodGroup _bloodx;
        public BloodGroup Bloodx
        {
            get { return _bloodx; }
            set { _bloodx = value; }
        }
        public List<BloodGroup> BloodGroupsx { get; set; }
        public Gender _genderx;
        public Gender Genderx
        {
            get { return _genderx; }
            set { _genderx = value; }
        }
        public List<Gender> Gendersx { get; set; }
        public DateTime BirthDay { get; set; }
        public int Series { get; set; }
        public int Number { get; set; }
        public int DivisionCode { get; set; }
        public string Division { get; set; }
        public DateTime DateOfIssue { get; set; }
        public Side Side { get; set; }
        public List<Side> Sides { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }

        private RelayCommand _createCommand;
        public RelayCommand CreateCommand => _createCommand ?? (_createCommand = new RelayCommand(x =>
        {
            Passport ToPushPass = new Passport();
            ToPushPass.DateOfIssue = DateOfIssue;
            ToPushPass.Number = Number;
            ToPushPass.Series = Series;
            ToPushPass.Division = Division;
            ToPushPass.DivisionCode = DivisionCode;
            Service.db.Add(ToPushPass);
            Service.db.SaveChanges();
            Person ToPush = new Person();
            ToPush.Adress = Adress;
            ToPush.Phone = "+" + Phone;
            ToPush.FirstName = FirstName;
            ToPush.LastName = LastName;
            ToPush.LastName = LastName;
            ToPush.Logins = Login;
            ToPush.Passwords = Password;
            ToPush.Polices = Police;
            ToPush.Passport = Service.db.Passports.First(x => x.Number == Number && x.Series == Series).Id;
            ToPush.Side = Service.db.Sides.First(x => x.Title == Side.Title).Id;
            ToPush.Blood = Service.db.BloodGroups.First(x => x.Groups == Bloodx.Groups).Id;
            ToPush.BirthdayDate = BirthDay;
            ToPush.Gender = Service.db.Genders.First(x => x.Gender1 == Genderx.Gender1).Id;
            Service.db.Add(ToPush);
            Service.db.SaveChanges();
            
        }));
        private RelayCommand _nextCommand;
        public RelayCommand NextCommand => _nextCommand ?? (_nextCommand = new RelayCommand(x =>
        {
            Service.frame.Navigate(new SecondPage());
        }));
    }
}
