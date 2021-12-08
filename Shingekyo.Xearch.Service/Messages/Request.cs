using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Singkeyo.Xearch.Service.Interfaces;

namespace Singkeyo.Xearch.Service.Messages
{
    public class Request<T> : IRequest<T>
    {
        public T Body { get; }

        public Request(T Body)
        {
            this.Body = Body;
        }
    }
}
