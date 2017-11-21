using System;

using Xamarin.Forms;

namespace mastdetail
{
    public class TopView : ContentPage
    {
        public TopView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

