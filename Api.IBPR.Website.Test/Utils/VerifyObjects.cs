using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IBPR.Website.Test.Utils
{
    public class VerifyObjects
    {

        public static bool IsTheSameObjects(object obj1, object obj2)
        {
            if (obj1 == null || obj2 == null)
                return false;

            if (obj1.GetType() != obj2.GetType())
                return false;

            return true;
        }

    }
}