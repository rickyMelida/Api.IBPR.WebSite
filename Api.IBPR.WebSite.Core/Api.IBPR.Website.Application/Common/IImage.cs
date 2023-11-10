using Api.IBPR.Website.Core.Domain.Entities.Common;

namespace Api.IBPR.Website.Core.Application.Common
{
    public interface IImage
    {
        public Image GetImge (int Id);
        public Image SetImage (Image image);
        public Image DeleteImage (Image image);
        public Image UpdateImage (Image image);
    }
}