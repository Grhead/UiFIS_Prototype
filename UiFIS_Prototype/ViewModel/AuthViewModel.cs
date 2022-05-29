using System.Linq;
using UiFIS_Prototype.Models.Req;
using UiFIS_Prototype.Views;
using UiFIS_Prototype.Views.Pages;
using UiFIS_Prototype.Views.Pages.Doctor;

namespace UiFIS_Prototype.ViewModel
{
    public class AuthViewModel : StaticViewModel
    {

        public string Login { get; set; }
        public string Password { get; set; }
        private RelayCommand _loginCommand;
        public RelayCommand LoginCommand => _loginCommand ?? (_loginCommand = new RelayCommand(x =>
        {
            Person user = Service.db.People.FirstOrDefault(q => q.Logins == Login && q.Passwords == Password);
            if (user != null)
            {
                Service.ClientSession = user;
                if (user.Side == 1)
                {
                    new MainManagerWindow().Show();
                    Service.frame.Navigate(new MainPageManager());
                }
                else if (user.Side == 3)
                {
                    new MainDoctorWindow().Show();
                    Service.frame.Navigate(new MenuPage());
                }
            }
        }));
    }
}
