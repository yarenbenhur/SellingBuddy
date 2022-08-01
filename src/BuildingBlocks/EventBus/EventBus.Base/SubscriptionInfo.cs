using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base
{
    // dışardan gönderilen verilerin içerid tutulması 
    // verilen integrationevent tipini tutup tipten onunhandler metodunu çağıracağız
    public class SubscriptionInfo
    {
        public Type HandlerType { get; }
        public SubscriptionInfo(Type handlerType)
        {
            HandlerType = handlerType ?? throw new ArgumentNullException(nameof(handlerType));
        }
        public static SubscriptionInfo Typed(Type handlerType)
        {
            return new SubscriptionInfo(handlerType);
        }

    }
}
