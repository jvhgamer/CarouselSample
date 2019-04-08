using System;
using Xamarin.Forms;

namespace CarouselSample.Views
{
    public class MainPage : CarouselPage
    {
        public static Page1 page1;
        public static Page2 page2;

        public MainPage()
        {
            page1 = new Page1();
            page2 = new Page2();

            Children.Add(page1);
            Children.Add(page2);

            CurrentPage = page1;
        }

        public static void SwitchPages(int pageNum)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                switch (pageNum)
                {
                    default:
                    case 1:
                        ((MultiPage<ContentPage>)App.Current.MainPage)
                                    .CurrentPage = page1;
                        break;
                    case 2:
                        ((MultiPage<ContentPage>)App.Current.MainPage)
                                    .CurrentPage = page2;
                        break;
                }
            });
        }
    }
}