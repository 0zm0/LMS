using LMS.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LMS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegisteredUsers>();

            DatePicker EntryUserBirthDate = new DatePicker();

            var item = new RegisteredUsers()
            {
                UserName = EntryUserName.Text,
                FirstName = EntryUserFirstName.Text,
                LastName = EntryUserLastName.Text,
                Password = EntryUserPassword.Text,
                Address = EntryUserAddress.Text,
                Email = EntryUserEmail.Text,
                MemberID = EntryUserMemberID.Text,
                PhoneNumber = EntryUserPhoneNumber.Text,

            };

            db.Insert(item);
            /*
            var email = EntryUserEmail.Text;
            var emailPattern ="^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
            if (!String.IsNullOrWhiteSpace(email) && !(Regex.IsMatch(email, emailPattern)))
            {
                EntryUserEmail.Text = "";
                EntryUserEmail.Placeholder = "EmailVerification Failed";
            }
            else
            {
                EntryUserEmail.Placeholder = "Email Verification Success";
            }
            */
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Congratulations", "Registration successful", "Continue", "Cancel");

                if (result)
                {
                    await Navigation.PushAsync(new LoginScreen());
                }
            });
        }
    }
}