using LMS.Icons;
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
    public partial class Rating : ContentPage
    {
        public Rating()
        {
            InitializeComponent();
            Star1.Text = MaterialIcons.Star_border_purple500;
            Star2.Text = MaterialIcons.Star_border_purple500;
            Star3.Text = MaterialIcons.Star_border_purple500;
            Star4.Text = MaterialIcons.Star_border_purple500;
            Star5.Text = MaterialIcons.Star_border_purple500;
        }
        int ratingScore = 0;

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Star1.Text = MaterialIcons.Star;
            Star2.Text = MaterialIcons.Star_border_purple500;
            Star3.Text = MaterialIcons.Star_border_purple500;
            Star4.Text = MaterialIcons.Star_border_purple500;
            Star5.Text = MaterialIcons.Star_border_purple500;
            DisplayAlert("Successful!", "You have given one star!", "OK");
            ratingScore = 1;
        }
        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Star1.Text = MaterialIcons.Star;
            Star2.Text = MaterialIcons.Star;
            Star3.Text = MaterialIcons.Star_border_purple500;
            Star4.Text = MaterialIcons.Star_border_purple500;
            Star5.Text = MaterialIcons.Star_border_purple500;
            DisplayAlert("Successful!", "You have given two stars!", "OK");
            ratingScore = 2;
        }
        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            Star1.Text = MaterialIcons.Star;
            Star2.Text = MaterialIcons.Star;
            Star3.Text = MaterialIcons.Star;
            Star4.Text = MaterialIcons.Star_border_purple500;
            Star5.Text = MaterialIcons.Star_border_purple500;
            DisplayAlert("Successful!", "You have given three stars!", "OK");
            ratingScore = 3;
        }
        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            Star1.Text = MaterialIcons.Star;
            Star2.Text = MaterialIcons.Star;
            Star3.Text = MaterialIcons.Star;
            Star4.Text = MaterialIcons.Star;
            Star5.Text = MaterialIcons.Star_border_purple500;
            DisplayAlert("Successful!", "You have given four stars!", "OK");
            ratingScore = 4;
        }
        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            Star1.Text = MaterialIcons.Star;
            Star2.Text = MaterialIcons.Star;
            Star3.Text = MaterialIcons.Star;
            Star4.Text = MaterialIcons.Star;
            Star5.Text = MaterialIcons.Star; 
            DisplayAlert("Successful!", "You have given five stars!", "OK");
            ratingScore = 5;
        }

        void ChangeRating (int ratingScore)
        {
            switch (ratingScore)
            {
                case 0:
                    {
                        Star1.Text = MaterialIcons.Star_border_purple500;
                        Star2.Text = MaterialIcons.Star_border_purple500;
                        Star3.Text = MaterialIcons.Star_border_purple500;
                        Star4.Text = MaterialIcons.Star_border_purple500;
                        Star5.Text = MaterialIcons.Star_border_purple500;
                        break;
                    }
                case 1:
                    {
                        Star1.Text = MaterialIcons.Star;
                        Star2.Text = MaterialIcons.Star_border_purple500;
                        Star3.Text = MaterialIcons.Star_border_purple500;
                        Star4.Text = MaterialIcons.Star_border_purple500;
                        Star5.Text = MaterialIcons.Star_border_purple500;
                        break;
                    }
                case 2:
                    {
                        Star1.Text = MaterialIcons.Star;
                        Star2.Text = MaterialIcons.Star;
                        Star3.Text = MaterialIcons.Star_border_purple500;
                        Star4.Text = MaterialIcons.Star_border_purple500;
                        Star5.Text = MaterialIcons.Star_border_purple500;
                        break;
                    }
                case 3:
                    {
                        Star1.Text = MaterialIcons.Star;
                        Star2.Text = MaterialIcons.Star;
                        Star3.Text = MaterialIcons.Star;
                        Star4.Text = MaterialIcons.Star_border_purple500;
                        Star4.Text = MaterialIcons.Star_border_purple500;
                        break;
                    }
                case 4:
                    {
                        Star1.Text = MaterialIcons.Star;
                        Star2.Text = MaterialIcons.Star;
                        Star3.Text = MaterialIcons.Star;
                        Star4.Text = MaterialIcons.Star;
                        Star5.Text = MaterialIcons.Star_border_purple500;
                        break;
                    }
                case 5:
                    {
                        Star1.Text = MaterialIcons.Star;
                        Star2.Text = MaterialIcons.Star;
                        Star3.Text = MaterialIcons.Star;
                        Star4.Text = MaterialIcons.Star;
                        Star5.Text = MaterialIcons.Star;
                        break;
                    }
                default:
                    {
                        Star1.Text = MaterialIcons.Star_border_purple500;
                        Star2.Text = MaterialIcons.Star_border_purple500;
                        Star3.Text = MaterialIcons.Star_border_purple500;
                        Star4.Text = MaterialIcons.Star_border_purple500;
                        Star5.Text = MaterialIcons.Star_border_purple500;
                        break;
                    }
            }
        }
    }
}