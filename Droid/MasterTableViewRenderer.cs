using Android.Widget;
using mastdetail.Controls;
using mastdetail.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MasterTableView), typeof(MasterTableViewRenderer))]
namespace mastdetail.Droid
{
    public class MasterTableViewRenderer : TableViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TableView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
                return;

            var listView = Control as global::Android.Widget.ListView;
            listView.DividerHeight = 0;
        }
    }
}
