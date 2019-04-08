using System;
using Xamarin.Forms;

namespace CarouselSample.Views
{
    public class Page1 : ContentPage
    {
        //    <!-- Initialize variables -->
        Button btn = new Button {
            Text = "Switch to Page2",
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.Start
        };
        Label lbl = new Label {
            Text = "Welcome to Page 1!",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };
        StackLayout stackLayout = new StackLayout();

        public Page1()
        {
            //    <!-- Register events -->
            btn.Clicked += Btn_Clicked;

            //    <!-- Add children to layout(s) -->
            stackLayout.Children.Add(btn);
            stackLayout.Children.Add(lbl);

            //    <!-- Place controls here -->
            Content = stackLayout;
        }

        #region Events
        void Btn_Clicked(object sender, EventArgs e)
        {
            MainPage.SwitchPages(2);
        }
        #endregion
    }
}
