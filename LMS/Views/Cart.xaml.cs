using Rg.Plugins.Popup.Services;
using LMS.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LMS.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cart : ContentPage
	{
		public Cart ()
		{
			InitializeComponent();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.dbPath))
            {
                conn.CreateTable<Cart_Book>();
                var books = conn.Table<Cart_Book>().ToList();
                booksList.ItemsSource = books;
            }
        }

        private void booksList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var message = (Cart_Book)e.Item;
            var m = message.bookName.ToString();
            PopupNavigation.PushAsync(new CartPopUp(m));
            //DisplayAlert("Item tapped", m, "ok");
        }
    }
}