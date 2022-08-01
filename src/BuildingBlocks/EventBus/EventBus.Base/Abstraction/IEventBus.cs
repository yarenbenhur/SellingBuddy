using EventBus.Base.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Abstraction
{
    //Sevislerin Subscription işlemleri hangi eveti subscribe edeceklerini söyledikleri yer 
    //bu interface'i kullanarak rabbit ve azure için 2 adet eventbus oluşturucaz
    public interface IEventBus 
    {
        void Publish(IntegrationEvent @event);
        void Subscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;
        void UnSubscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;

    }
}
