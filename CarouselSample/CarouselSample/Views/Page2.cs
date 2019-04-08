using System;
using Xamarin.Forms;

namespace CarouselSample.Views
{
    public class Page2 : ContentPage
    {
        //    <!-- Initialize variables -->
        Button btn = new Button {
            Text = "Switch to Page1",
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.Start
        };
        Label lbl = new Label {
            Text = "Another page! Try swiping.",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };
        StackLayout stackLayout = new StackLayout();

        public Page2()
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
            MainPage.SwitchPages(1);
        }
        #endregion
    }
}
