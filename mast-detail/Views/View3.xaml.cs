using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace mastdetail.Views
{
    public partial class View3 : ContentPage
    {
        string[] fList = { "aaa", "bbb", "ccc", "ddd", "eee"};
            
        public View3()
        {
            InitializeComponent();

            this.list.ItemsSource = fList;
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var label = e.SelectedItem.ToString();
            Navigation.PushAsync(new View3_1(label));
        }
    }
}
