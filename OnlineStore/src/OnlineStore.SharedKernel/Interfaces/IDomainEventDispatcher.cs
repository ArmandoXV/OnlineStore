using OnlineStore.SharedKernel;
using System.Threading.Tasks;

namespace OnlineStore.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}