using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singkeyo.Xearch.Service.Interfaces;
using Singkeyo.Xearch.Service.Messages;

namespace Singkeyo.Xearch.Service
{
    public static class StringToRequestExtension
    {
        public static IRequest<string> ToRequest(this string body) => new Request<string>(body);
    }
}
