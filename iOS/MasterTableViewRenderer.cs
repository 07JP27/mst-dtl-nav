using System;
using mastdetail.Controls;
using mastdetail.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MasterTableView), typeof(MasterTableViewRenderer))]
namespace mastdetail.iOS
{
    public class MasterTableViewRenderer : TableViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TableView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
                return;

            var tableView = Control as UITableView;
            tableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
        }
    }
}
