using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using UiFIS_Prototype.Models.Req;
using UiFIS_Prototype.Views.Pages;

namespace UiFIS_Prototype.ViewModel
{
    public class CreateEMC : StaticViewModel
    {
        public CreateEMC()
        {
            BloodGroupsx = new List<BloodGroup>(Service.db.BloodGroups);
            Gendersx = new List<Gender>(Service.db.Genders);
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
            set { _bloodx = value; OnPropertyChanged(); }
        }
        public List<BloodGroup> BloodGroupsx { get; set; }
        public Gender _genderx;
        public Gender Genderx
        {
            get { return _genderx; }
            set { _genderx = value; OnPropertyChanged(); }
        }
        public List<Gender> Gendersx { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int Series { get; set; }
        public int Number { get; set; }
        public int DivisionCode { get; set; }
        public string Division { get; set; }
        public Side Side { get; set; }
        public List<Side> Sides { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }

        private RelayCommand _createCommand;
        public RelayCommand CreateCommand => _createCommand ?? (_createCommand = new RelayCommand(x =>
        {
            if (Service.db.People.FirstOrDefault(x => x.Logins == Login) == null)
            {
                if (DateOfIssue != DateTime.Parse("01.01.0001") && Number != null && Series != null && Division != null && DivisionCode != null && Phone != null && Password != null && Side != null)
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
                    ToPush.SecondName = SecondName;

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
                    Service.frame.Navigate(new MainPageManager());
                }
            }
            else
            {
                MessageBox.Show("Login существует");
            }

        }));
        private RelayCommand _nextCommand;
        public RelayCommand NextCommand => _nextCommand ?? (_nextCommand = new RelayCommand(x =>
        {
            DateTime temp = DateTime.Parse("01.01.0001");
            if (FirstName != null && LastName != null && SecondName != null && Genderx != null && BirthDay != temp && Bloodx != null && Police != null)
            {
                Service.frame.Navigate(new SecondPage());
            }
        }));
    }
}
