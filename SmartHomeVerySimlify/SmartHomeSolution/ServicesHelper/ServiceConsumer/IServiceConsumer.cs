using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Services.ServiceConsumer
{
    public interface IServiceConsumer<T, K>
    {
        Task<K> PostAsync(T request);
        K PostLogged(T request, ref string log);
    }
}
