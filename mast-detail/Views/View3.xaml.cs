using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using mastdetail.Models;
using mastdetail.Services;
using Xamarin.Forms;

namespace mastdetail.Views
{
    public partial class View3 : ContentPage
    {
        string[] fList = { "aaa", "bbb", "ccc", "ddd", "eee"};
            
        public View3()
        {
            InitializeComponent();
            GetData(new WebService());
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var label = e.SelectedItem.ToString();
            Navigation.PushAsync(new View3_1(label));
        }

        // 非同期でデータ取得のメソッドを実行するメソッド
        async void GetData(WebService webDS)
        {
            ObservableCollection<AEDModel> AEDlist;
            try
            {
                // 取得したデータをListに設定
                AEDlist = await webDS.AsyncGetWebAPIData();
                this.list.ItemsSource = AEDlist;
                this.indicator.IsVisible = false;
            }
            // エラー表示処理
            catch (System.Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "OK");
            }

        }
    }
}
