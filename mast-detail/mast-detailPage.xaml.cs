using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace mastdetail
{
    public partial class mast_detailPage : MasterDetailPage
    {
        private readonly List<MasterItem> _namedColors = new List<MasterItem>()
        {
            new MasterItem() {Title = "Home", IconSource="icon.png" ,TargetType = typeof(TopView)},
            new MasterItem() {Title = "View1",IconSource="icon.png" ,TargetType = typeof(View1)},
            new MasterItem() {Title = "View2",IconSource="icon.png" ,TargetType = typeof(View2)},
            new MasterItem() {Title = "View3",IconSource="icon.png" ,TargetType = typeof(View3)},
        };

        public mast_detailPage(NavigationPage initPage)
        {
            InitializeComponent();

            //ListVIewに項目を追加
            listView.ItemsSource = _namedColors;

            this.Detail = initPage;
        }

        private void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var nextView = _namedColors.Where(a => a == e.SelectedItem).FirstOrDefault();
                
            //home
            if(nextView.TargetType == typeof(TopView))
            {
                Application.Current.MainPage = new TopView();
            }

            Page displayPage = (Page)Activator.CreateInstance(nextView.TargetType);
            var detail = new NavigationPage(displayPage);

            this.Detail = detail;
            // Detail Pageに戻る
            this.IsPresented = false;
        }
    }
}
