using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Singkeyo.Xearch.Service.Interfaces;

namespace Singkeyo.Xearch.Service.Messages
{
    public class Response<T> : IResponse<T>
    {
        public T Result { get; }

        internal Response(T Result)
        {
            this.Result = Result;
        }
    }
}
