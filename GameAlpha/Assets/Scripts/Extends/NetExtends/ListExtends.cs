using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace NetExtends
{


    public static class ListExtends
    {
        public static string JoinItemToStr<T>(this List<T> list,string joinStr)
        {
            if (list.Count == 0) return "";
            if (list.Count == 1) return list[0].ToString();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i].ToString());
                if (i != list.Count - 1)
                {
                    sb.Append(joinStr);
                }
            }
            return sb.ToString();
        }
    }
}
