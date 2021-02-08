using OnlineStore.SharedKernel;
using OnlineStore.SharedKernel.Interfaces;
using System.Threading.Tasks;

namespace OnlineStore.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
