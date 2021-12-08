using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singkeyo.Xearch.Service.Interfaces
{
    public interface IDocument
    {
        string Name { get; }

        string Body { get; }

        string Path { get; }
    }
}
