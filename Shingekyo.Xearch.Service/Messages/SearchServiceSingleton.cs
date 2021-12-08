using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Singkeyo.Xearch.Service.Interfaces;

namespace Singkeyo.Xearch.Service.Messages
{
    public class SearchServiceSingleton : ISearchServiceSingleton
    {
        private SearchServiceSingleton() // connect to db
        {

        }

        private static Lazy<ISearchServiceSingleton> _instanse => new Lazy<ISearchServiceSingleton>(() => new SearchServiceSingleton());

        public static ISearchServiceSingleton Instanse => _instanse.Value;

        public IResponse<O> Search<T, O>(IRequest<T> request) where O: IEnumerable<IDocument>
        {
            // CALL LAYER DOWN

            //THROW OUTPUT BACK
            throw new NotImplementedException();
        }
    }
}
