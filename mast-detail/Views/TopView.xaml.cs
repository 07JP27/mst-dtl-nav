using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace mastdetail.Views
{
    public partial class TopView : ContentPage
    {
        public TopView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void View1Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new mast_detailPage(typeof(View1));
        }

        void View2Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new mast_detailPage(typeof(View2));
        }

        void View3Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new mast_detailPage(typeof(View3));
        }

        void View4Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new mast_detailPage(typeof(View4));
        }
    }
}
