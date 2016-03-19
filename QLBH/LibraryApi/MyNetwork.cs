using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Windows;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace LibraryApi
{
    public class MyNetwork
    {
        public const string URL_SERVICE = @"http://quanlybanhang.somee.com//QLBanHang.asmx/";
        public const string URL_GET_LOAI_HANG = URL_SERVICE + @"DanhSachLoaiHang";
        public const string URL_GET_TAG = URL_SERVICE;
        public delegate void CompleteHandle(object data);
        static void requestDataWithParam<T>(Dictionary<string, object> param
            , string url
            , Form f
            , CompleteHandle MyDelegate
            )
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                foreach (KeyValuePair<string, object> pair in param)
                {
                    request.AddParameter(pair.Key, pair.Value);
                }
                client.ExecuteAsync(request, response =>
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        T jsonObject = JsonConvert.DeserializeObject<T>(response.Content);
                        f.Invoke(new Action(() =>
                        {
                            MyDelegate(jsonObject);
                        }));
                    }
                    else
                    {
                        throw new Exception(response.ErrorMessage);
                    }
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public static void requestDatSan(
        //    string ma_phieu,
        //    DateTime ngay_dat,
        //    DateTime ngay_da,
        //    string ten_khach_hang,
        //    string so_dien_thoai,
        //    decimal id_khung_gio,
        //    decimal id_san,
        //    string dat_coc,
        //    string da_thanh_toan,
        //    CompleteHandle MyDelegate)
        //{
        //    Dictionary<string, object> param = new Dictionary<string, object>();
        //    param["ma_phieu"] = ma_phieu;
        //    param["ngay_dat"] = ngay_dat;
        //    param["ngay_da"] = ngay_da;
        //    param["ten_khach_hang"] = ten_khach_hang;
        //    param["so_dien_thoai"] = so_dien_thoai;
        //    param["id_khung_gio"] = id_khung_gio;
        //    param["id_san"] = id_san;
        //    param["dat_coc"] = dat_coc;
        //    param["da_thanh_toan"] = da_thanh_toan;
        //    requestDataWithParam<Dictionary<string, object>>(param, URL_DAT_SAN, MyDelegate);
        //}
        //public static void requstGenMaPhieu(CompleteHandle MyDelegate)
        //{
        //    Dictionary<string, object> param = new Dictionary<string, object>();
        //    requestDataWithParam<GenMaPhieu>(param, URL_GEN_MA_PHIEU, MyDelegate);
        //}
        public static void GetDanhSachLoaiHang(
            Form f,
            CompleteHandle MyDelegate)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            requestDataWithParam<LOAI_HANG>(param, URL_GET_LOAI_HANG,f, MyDelegate);
        }

      
    }
}
