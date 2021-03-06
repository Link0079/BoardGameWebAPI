
namespace Imi.Project.Api.Core.Entities.Base
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
