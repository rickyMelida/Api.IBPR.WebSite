using Api.IBPR.Website.Core.Domain.Common;

namespace Api.IBPR.Website.Core.Domain.Entities
{
    public class Values: BaseEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}