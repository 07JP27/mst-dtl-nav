using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace mastdetail.Views
{
    public partial class View3_1 : ContentPage
    {
        public View3_1(string label)
        {
            InitializeComponent();

            this.txtLabel.Text = label;
        }
    }
}
