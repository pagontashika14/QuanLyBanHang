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
        public const string URL_SERVICE = @"http://localhost:32608/QLBanHang.asmx/";
        public const string URL_GET_LOAI_HANG = URL_SERVICE + @"DanhSachLoaiHang";
        public const string URL_LAY_DANH_SACH_HANG_THEO_LOAI_HANG = URL_SERVICE + @"LayDanhSachHangHoaTheoLoaiHangHoa";
        public const string URL_GET_TAG = URL_SERVICE;
        public const string URL_THEM_HANG_HOA = URL_SERVICE + "ThemHangHoa";

        public delegate void CompleteHandle<T>(T data);
        static void requestDataWithParam<T>(Dictionary<string, object> param
            , string url
            , Form f
            , CompleteHandle<T> MyDelegate
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
        static void requestDataWithParam<T>(Dictionary<string, object> param
            , string url
            , CompleteHandle<T> MyDelegate
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
                        MyDelegate(jsonObject);
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
        static void requestDataWithParam<T>(Dictionary<string, object> param
           , string url
           , Control user_control
           , CompleteHandle<T> MyDelegate
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
                        user_control.Invoke(new Action(() =>
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
        public static void GetDanhSachLoaiHang(
            Form f,
            CompleteHandle<LOAI_HANG> MyDelegate)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            requestDataWithParam<LOAI_HANG>(param, URL_GET_LOAI_HANG, f, MyDelegate);
        }
        public static void GetDanhSachLoaiHang(
           Control uc,
           CompleteHandle<LOAI_HANG> MyDelegate)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            requestDataWithParam<LOAI_HANG>(param, URL_GET_LOAI_HANG, uc, MyDelegate);
        }
        public static void LayDanhSachHangHoaTheoLoaiHangHoa(decimal id_loai_hang, Form f, CompleteHandle<DanhSachHangHoa> MyDelegate)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param["id_loai_hang_hoa"] = id_loai_hang;
            requestDataWithParam<DanhSachHangHoa>(param, URL_LAY_DANH_SACH_HANG_THEO_LOAI_HANG, f, MyDelegate);
        }
        public static void ThemHangHoa(
            List<ThemHangHoaPost> list_hang_hoa,
            Form f,
            CompleteHandle<ThemHangHoa> MyDelegate)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param["list_hang_hoa"] = JsonConvert.SerializeObject(list_hang_hoa);
            requestDataWithParam<ThemHangHoa>(param, URL_THEM_HANG_HOA,f,MyDelegate);
        }

    }
}
