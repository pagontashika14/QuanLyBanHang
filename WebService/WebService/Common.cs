using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class Common
    {
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