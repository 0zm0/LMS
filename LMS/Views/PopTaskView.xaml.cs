using LMS.Views;
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
    public partial class PopTaskView
    {
        public string name { get; set; }
        public string authorName { get; set; }
        public string ISBN { get; set; }
        public string year { get; set; }
        public string pages { get; set; }
        public string language { get; set; }
        public string rating { get; set; }
        public string genre { get; set; }
        public string available { get; set; }
        public PopTaskView(string name)
        {
            InitializeComponent();
            this.name = name;
            

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.dbPath))
            {
                List<Book> book1 = new List<Book>();
                book1 = connection.Table<Book>().ToList();

                foreach (var b in book1)
                {
                    if(b.bookName == name)
                    {
                        authorName = b.bookAuthor;
                        ISBN = b.ISBN;
                        year = b.year;
                        pages = b.pages;
                        language = b.language;
                        rating = b.rating;
                        genre = b.genre;
                        available = b.available;
                        break;
                    }
                }
                    
            }
            BindingContext = this;
        }

        private void addToCart(object sender, EventArgs e)
        {
            Cart_Book cart = new Cart_Book()
            {
                bookName = name,
                bookAuthor = authorName,
                ISBN = ISBN,
                year = year,
                pages = pages, 
                language = language,
                rating = rating,
                genre = genre,
                available = available
            };

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.dbPath))
            {
                connection.CreateTable<Cart_Book>();
                var numberOfRows = connection.Insert(cart);

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

        private void rent(object sender, EventArgs e)
        {
            int av = int.Parse(available);
            if (av == 0)
            {
                DisplayAlert("Error","You were not able to rent this book because it is not available","OK");
            } 
            else if (av > 0)
            {
                DisplayAlert("Successfull!", "You have successfully rented this book" ,"OK");
                av--;
                available = av.ToString();
            }
        }

        private void rate(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Rating());
        }
        
    }
}