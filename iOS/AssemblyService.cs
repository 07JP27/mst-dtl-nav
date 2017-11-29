using Foundation;
using mastdetail.Interfaces;
using mastdetail.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(AssemblyService))]
namespace mastdetail.iOS
{
    public class AssemblyService: IAssemblyService
    {
        //アプリ名称を取得する
        public string GetPackageName()
        {
            string name = NSBundle.MainBundle.InfoDictionary["CFBundleDisplayName"].ToString();
            return name.ToString();
        }
        //アプリバージョン文字列を取得する
        public string GetVersionName()
        {
            string name = NSBundle.MainBundle.InfoDictionary["CFBundleShortVersionString"].ToString();
            return name.ToString();
        }

        //ビルドバージョン文字列を取得する
        public string GetBuildName()
        {
            string name = NSBundle.MainBundle.InfoDictionary["CFBundleVersion"].ToString();
            return name.ToString();
        }
    }
}
