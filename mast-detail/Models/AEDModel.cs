using System;
namespace mastdetail.Models
{
    public class AEDModel
    {
        public string Id { get; set; }                      //-- ID
        public string LocationName { get; set; }            //-- 場所_地名【名称】
        public string Perfecture { get; set; }              //-- 構造化住所_都道府県
        public string City { get; set; }                    //-- 構造化住所_市区町村
        public string AddressArea { get; set; }             //-- 構造化住所_町名
        public string Latitude { get; set; }                //-- 緯度経度座標系_緯度
        public string Longitude { get; set; }               //-- 緯度経度座標系_経度
        public string FacilityId { get; set; }              //-- 公共設備_ID
        public string FacilityName { get; set; }            //-- 公共設備_名称
        public string FacilityPlace { get; set; }           //-- 公共設備_設置場所【設置場所】※受付横とか
        public string ScheduleDayType { get; set; }         //-- 公共設備_利用可能時間【利用可能時間】
        public string ScheduleDayStartTime { get; set; }    //-- 開始時間
        public string ScheduleDayEndTime { get; set; }      //-- 終了時間
        public string AccessAvailabilityOfPad { get; set; } //-- 公共設備_建物内外【建物内外】
        public string FacilityUser { get; set; }            //-- 公共設備_利用者【利用制限】
        public string FacilityNote { get; set; }            //-- 公共設備_補足【補足】
        public string DayOfInstallation { get; set; }       //-- 公共設備_設置日
        public string PhotoOfAedUrl { get; set; }           //-- 公共設備_写真URL【写真】
        public string Url { get; set; }                     //-- 公共設備_ホームページ【ホームページ】
        public string FacilityOwner { get; set; }           //-- 公共設備_設置者【設置者】
        public string FacilityOperater { get; set; }        //-- 公共設備_管理者
        public string ContactPoint { get; set; }            //-- 公共設備_連絡先【連絡先】
        public string ContactTelephone { get; set; }        //-- 連絡先_電話番号
        public string ContactExtension { get; set; }        //-- 連絡先_内線番号
        public string TypeOfPad { get; set; }               //-- AED_パッド種類
        public string ExpiryDate { get; set; }              //-- AED_有効期限
        public string ExpiryDateOfPads { get; set; }        //-- AED_パッド有効期限
        public string ExpiryDateOfBatteries { get; set; }   //-- AED_バッテリ有効期限
        public string TypeOfDefibrillator { get; set; }     //-- AED_タイプ
        public string ModelNumber { get; set; }             //-- AED_モデルナンバー
        public string SerialNumber { get; set; }            //-- AED_シリアルナンバー
        public string Source { get; set; }                  //-- メタデータ_情報源
        public string DateOfUpdatingInformation { get; set; } //-- 更新日時
    }
}
