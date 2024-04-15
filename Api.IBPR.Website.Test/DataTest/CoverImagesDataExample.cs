using System.Collections.Generic;

namespace Api.IBPR.Website.Test.DataTest
{
    public static class CoverImagesDataExample
    {
        public static List<Domain.Entities.CoverImages> GetCoverImages()
        {
            return new List<Domain.Entities.CoverImages>()
            {
                new Domain.Entities.CoverImages{Id=1, Section=1, Image=1}
            };
        }
    }
}