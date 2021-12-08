using static System.Console;
using Singkeyo.Xearch.Service.Interfaces;
using Singkeyo.Xearch.Service.Messages;
using Singkeyo.Xearch.Service;
using System.Collections.Generic;

namespace Xearch.Presentation.UserInterface.Console
{
    internal sealed class EntryPoint
    {
        private static void Main()
        {
            var response = SearchServiceSingleton.Instanse.Search<string, List<IDocument>>("test".ToRequest());
            response.Result.ForEach(x =>
            {
                WriteLine(x.Name + "\t" + x.Path);
            });
            ReadLine();
            /*
             * Create Request
             * Call Search
             * Recive result
             */
        }
    }
}
