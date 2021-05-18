using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewBook : ContentPage
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                bookName = EntryBookName.Text,
                bookAuthor = EntryAuthor.Text,
                ISBN = EntryISBN.Text,
                year = EntryYear.Text,
                pages = EntryPages.Text,
                language = EntryLanguage.Text,
                rating = EntryRating.Text,
                genre = EntryGenre.Text,
                available = EntryAvailable.Text,
            };

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.dbPath))
            {
                connection.CreateTable<Book>();
                var numberOfRows = connection.Insert(book);

                if (numberOfRows > 0)
                {
                    DisplayAlert("Action successful", "Book added successfully", "OK");
                }
                else
                {
                    DisplayAlert("Action failed", "Addition of the book failed", "OK");
                }
            }
        }
    }
}