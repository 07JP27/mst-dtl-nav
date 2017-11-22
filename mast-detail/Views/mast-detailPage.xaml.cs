using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using mastdetail.Models;
using mastdetail.Constants;

namespace mastdetail.Views
{
    public partial class mast_detailPage : MasterDetailPage
    {
        public mast_detailPage(NavigationPage initPage)
        {
            InitializeComponent();

            //Masterに項目を追加
            listView.ItemsSource = MasterMenu.MasterMenuList;

            //初期画面を表示
            this.Detail = initPage;
        }

        private void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            // 選択された画面を抽出
            var nextView = MasterMenu.MasterMenuList.Where(a => a == e.SelectedItem).FirstOrDefault();
                
            //HOMEなら別遷移
            if(nextView.TargetType == typeof(TopView))
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            }

            //選択されたページをインスタンス化してNavigationPageを作成し、画面を遷移する
            Page displayPage = (Page)Activator.CreateInstance(nextView.TargetType);
            var detail = new NavigationPage(displayPage);
            this.Detail = detail;

            // Detail Pageに戻る
            this.IsPresented = false;
        }
    }
}
