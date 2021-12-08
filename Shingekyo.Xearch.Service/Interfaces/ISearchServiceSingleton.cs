using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singkeyo.Xearch.Service.Interfaces
{
    public interface ISearchServiceSingleton
    {
        IResponse<O> Search<T, O>(IRequest<T> request) where O: IEnumerable<IDocument>;
    }
}
