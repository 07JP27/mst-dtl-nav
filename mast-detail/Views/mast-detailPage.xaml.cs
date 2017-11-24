using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using mastdetail.Models;

namespace mastdetail.Views
{
    public partial class mast_detailPage : MasterDetailPage
    {
        public mast_detailPage(Type initPage)
        {
            InitializeComponent();

            //初期画面を表示
            Page displayPage = Activator.CreateInstance(initPage) as Page;

            if (displayPage != null)
            {
                var detail = new NavigationPage(displayPage);
                this.Detail = detail;
            }
        }

        void HomeTapped(object sender, System.EventArgs e)
        {
            Handle_ItemSelected(typeof(TopView));
        }

        void View1Tapped(object sender, System.EventArgs e)
        {
            Handle_ItemSelected(typeof(View1));
        }

        void View2Tapped(object sender, System.EventArgs e)
        {
            Handle_ItemSelected(typeof(View2));
        }

        void View3Tapped(object sender, System.EventArgs e)
        {
            Handle_ItemSelected(typeof(View3));
        }

        void View4Tapped(object sender, System.EventArgs e)
        {
            Handle_ItemSelected(typeof(View4));
        }

        private void Handle_ItemSelected(Type targetType)
        {
            //HOMEなら別遷移
            if(targetType == typeof(TopView))
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            }

            //選択されたページをインスタンス化してNavigationPageを作成し、画面を遷移する
            Page displayPage = Activator.CreateInstance(targetType) as Page;

            if (displayPage != null)
            {
                var detail = new NavigationPage(displayPage);
                this.Detail = detail;

                // Detail Pageに戻る
                this.IsPresented = false;
            }
        }
    }
}
