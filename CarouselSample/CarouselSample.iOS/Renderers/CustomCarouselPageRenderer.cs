using CarouselSample.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CarouselPage), typeof(CustomCarouselPageRenderer))]
namespace CarouselSample.iOS.Renderers
{
    public class CustomCarouselPageRenderer : CarouselPageRenderer
    {
        // Override the OnElementChanged method so we can tweak this renderer post-initial setup
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            UIView view = this.NativeView;
            UIScrollView scrollView = (UIKit.UIScrollView)view.Subviews[0];
            scrollView.ScrollEnabled = false;
        }
    }
}