using mastdetail.Controls;
using mastdetail.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomIndicatorWebView), typeof(CustomIndicatorWebViewRenderer))]
namespace mastdetail.iOS
{
    public class CustomIndicatorWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            // 背景を透過
            this.Opaque = false;
            this.BackgroundColor = UIColor.Clear;
        }
    }
}