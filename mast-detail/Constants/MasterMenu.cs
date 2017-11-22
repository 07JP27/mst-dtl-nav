using System;
using mastdetail.Models;
using mastdetail.Views;
using System.Collections.Generic;


namespace mastdetail.Constants
{
    public static class MasterMenu
    {
        static MasterMenu()
        {
            MasterMenuList = new List<MasterItem>()
            {
                new MasterItem() {Title = "Home", IconSource="icon.png" ,TargetType = typeof(TopView)},
                new MasterItem() {Title = "View1",IconSource="icon.png" ,TargetType = typeof(View1)},
                new MasterItem() {Title = "View2",IconSource="icon.png" ,TargetType = typeof(View2)},
                new MasterItem() {Title = "View3",IconSource="icon.png" ,TargetType = typeof(View3)},
            };
        }


        public static readonly List<MasterItem> MasterMenuList;
    }
}
