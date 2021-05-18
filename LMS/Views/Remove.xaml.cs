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
    public partial class Remove : ContentPage
    {
        Book book = new Book();
        public Remove()
        {
            InitializeComponent();
        }
        private void listViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            book = (Book)e.SelectedItem;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.dbPath))
            {

                conn.CreateTable<Book>();
                conn.Table<Book>().Delete(x => x.id == book.id);
                DisplayAlert("Removal was successfull", book.bookName + " was removed", "OK");
                var books = conn.Table<Book>().ToList();
                removeList.ItemsSource = books;
            }
            
        }
       
        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.dbPath))
            {
                conn.CreateTable<Book>();
                var books = conn.Table<Book>().ToList();
                removeList.ItemsSource = books;
            }
        }
    }
}