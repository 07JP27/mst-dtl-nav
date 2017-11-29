using System;
using System.Collections.Generic;
using mastdetail.Interfaces;
using Xamarin.Forms;

namespace mastdetail.Views
{
    public partial class View2 : ContentPage
    {
        public View2()
        {
            InitializeComponent();

            nameLabel.Text = DependencyService.Get<IAssemblyService>().GetPackageName();
            verLabel.Text = DependencyService.Get<IAssemblyService>().GetVersionName();
            buildLabel.Text = DependencyService.Get<IAssemblyService>().GetBuildName();
        }
    }
}
