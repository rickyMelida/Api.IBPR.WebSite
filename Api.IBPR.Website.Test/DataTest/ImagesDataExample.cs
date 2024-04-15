using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.IBPR.Website.Domain.Common;

namespace Api.IBPR.Website.Test.DataTest
{
    public static class ImagesDataExample
    {
        public static List<Image> GetImages()
        {
            return new List<Image>
            {
                new Image { Id=1, Name="Church image", Picture=new byte[] { 0, 0,}}
            };
        }

    }
}