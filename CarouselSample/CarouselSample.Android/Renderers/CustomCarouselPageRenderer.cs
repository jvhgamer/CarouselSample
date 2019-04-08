using Android.Content;
using CarouselSample.Droid.Forms_Renderers;
using CarouselSample.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CarouselPage), typeof(CustomCarouselPageRenderer))]
namespace CarouselSample.Droid.Renderers
{
    public class CustomCarouselPageRenderer : MyCarouselPageRenderer
    {
        public CustomCarouselPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CarouselPage> e)
        {
            base.OnElementChanged(e);
        }
    }
}