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
    public partial class search : ContentPage
    {

        List<Book> name = new List<Book>();






        public search()
        {
            InitializeComponent();

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.dbPath))
            {
                conn.CreateTable<Book>();
                var names = conn.Table<Book>().ToList();
                name = names;
                
            }
        }

        private void MainSearchBar_OnSearchButtonPressed(object sender, EventArgs e)
        {
            string keyword = MainSearchBar.Text;

            List<Book> searchResult = new List<Book>();

            foreach(var n in name)
            {
                if(n.bookName == keyword)
                {
                    searchResult.Add(n);
                    
                }
            }

            if (searchResult.Count() != 0)
            {
                MainListView.ItemsSource = searchResult;
            }
            
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