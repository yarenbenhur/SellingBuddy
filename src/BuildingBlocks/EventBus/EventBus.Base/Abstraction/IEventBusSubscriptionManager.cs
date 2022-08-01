using EventBus.Base.Events;
using System;
using System.Collections.Generic;

namespace EventBus.Base.Abstraction
{
    //gönderilen subscriptionları memoryde tutacağız. Dictionary ve liste yapacağız içinde gönderilen integration eventleri ve handlerları tutacağız.
    //sonradan veri tabanında tutulması istenilebilir. Değiştirilebilir olması için interface kullanacağız.
    public interface IEventBusSubscriptionManager
    {
        // herhangi bir eventi dinliyor muuyuz? bu ebnt silindiğinde içerde bir event oluşturacağız ve dışardan gelen unsubscribe metodu çalıştığında bu eventi de tetikleyeceğiz
        public bool IsEmpty { get; }
        event EventHandler<string> OnEventRemoved;
        void AddSubscription<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;
        void RemoveSubscription<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;
        bool HasSubscriptionForEvent<T>() where T : IntegrationEvent;
        bool HasSubscriptionForEvent(string eventName);
        Type GetEventTypeByName(string eventName);
        void Clear();
        IEnumerable<SubscriptionInfo> GetHandlersForEvents<T>() where T : IntegrationEvent;
        IEnumerable<SubscriptionInfo> GetHandlersForEvents(string eventName);
        string GetEventKey<T>(); // routing key 




    }
}
