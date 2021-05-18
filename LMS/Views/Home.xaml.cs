using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LMS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, true);
            InitializeComponent();
        }

        async void Logout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginScreen());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.dbPath))
            {
                conn.CreateTable<Book>();
                var books = conn.Table<Book>().ToList();
                booksList.ItemsSource = books;
            }
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNewBook());
        }

        private void ToolbarItem_Activated_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Remove());
        }
        
        private void ToolbarItem_Activated_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cart());
        }

        private void ToolbarItem_Activated_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new search());
        }

        private void OnPopupTask(object sender, ItemTappedEventArgs e)
        {
            var message = (Book)e.Item;
            var m = message.bookName.ToString();
            PopupNavigation.PushAsync(new PopTaskView(m));
            //DisplayAlert("Item tapped", m, "ok");
        }
    }
}