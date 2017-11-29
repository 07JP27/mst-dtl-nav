using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using mastdetail.Models;
using Newtonsoft.Json;

namespace mastdetail.Services
{
    public class WebService
    {
        public ObservableCollection<AEDModel> AEDList;
        // 仙台のAEDデータ
        public string AED_URL = "https://aed.azure-mobile.net/api/aedinfo/%E5%AE%AE%E5%9F%8E%E7%9C%8C/%E4%BB%99%E5%8F%B0%E5%B8%82/";
        // データを取得するメソッド
        public async Task<ObservableCollection<AEDModel>> GetAEDDataAsync()
        {
            var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate };
            handler.Proxy = WebRequest.DefaultWebProxy;
            ObservableCollection<AEDModel> responseModels;

            using (var client = new HttpClient(handler))
            {
                var url = new Uri(AED_URL);
                var response = await client.GetAsync(url);
                var responseText = await response.Content.ReadAsStringAsync();
                responseModels = JsonConvert.DeserializeObject<ObservableCollection<AEDModel>>(responseText);
            }

            return responseModels;
        }
    }
}
