using mastdetail.Controls;
using mastdetail.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomIndicatorWebView), typeof(CustomIndicatorWebViewRenderer))]
namespace mastdetail.Droid
{
    public class CustomIndicatorWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            // 背景を透過
            this.Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}
