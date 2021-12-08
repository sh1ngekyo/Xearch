using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singkeyo.Xearch.Service.Interfaces
{
    public interface IResponse<T>
    {
        T Result { get; }
    }
}
