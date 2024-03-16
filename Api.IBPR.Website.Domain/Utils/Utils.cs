using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Domain.Utils
{
    public static class Utils
    {
        public static byte[] CreateSpecialByteArray(int length)
        {
            var arr = new byte[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0x20;
            }
            return arr;
        }
    }
}