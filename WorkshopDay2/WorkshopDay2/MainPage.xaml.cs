using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkshopDay2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnHorizontalStartClicked(object sender, EventArgs e)
        {
            target.HorizontalOptions = LayoutOptions.Start;
        }
        private void OnHorizontalCenterClicked(object sender, EventArgs e)
        {
            target.HorizontalOptions = LayoutOptions.Center;
        }
        private void OnHorizontalEndClicked(object sender, EventArgs e)
        {
            target.HorizontalOptions = LayoutOptions.End;
        }
        private void OnHorizontalFillClicked(object sender, EventArgs e)
        {
            target.HorizontalOptions = LayoutOptions.Fill;
        }


        private void OnVerticalStartClicked(object sender, EventArgs e)
        {
            target.VerticalOptions = LayoutOptions.Start;
        }

        private void OnVerticalCenterClicked(object sender, EventArgs e)
        {
            target.VerticalOptions = LayoutOptions.Center;
        }

        private void OnVerticalEndClicked(object sender, EventArgs e)
        {
            target.VerticalOptions = LayoutOptions.End;
        }

        private void OnVerticalFillClicked(object sender, EventArgs e)
        {
            target.VerticalOptions = LayoutOptions.Fill;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}
