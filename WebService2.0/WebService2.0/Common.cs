using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService2._0.Struct
{
    public class Common
    {
        public const string DANH_MUC_SP = @"DANH_MUC_SAN_PHAM";
        public const string SIZE = @"SIZE_QUAN_AO";
        public const string WEB_PATH = @"d:\DZHosts\LocalUser\pagontashika31\www.quanlybanhang.somee.com\";
        public const string WEB_ADDRESS = @"http://quanlybanhang.somee.com/";

        public static List<decimal> TachID(string input)
        {
            var dsID = input.Split(',').ToList();
            var listID = new List<decimal>();
            foreach (var item in dsID)
            {
                listID.Add(decimal.Parse(item));
            }
            return listID;
        }
    }
}