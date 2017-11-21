using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace mastdetail
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
            Application.Current.MainPage = new mast_detailPage(new NavigationPage(new View1()));
        }

        void View2Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new mast_detailPage(new NavigationPage(new View2()));
        }

        void View3Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new mast_detailPage(new NavigationPage(new View3()));
        }
    }
}
