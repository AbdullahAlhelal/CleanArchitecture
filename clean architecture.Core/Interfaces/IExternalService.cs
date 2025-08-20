using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.Core.Interfaces
{
    public interface IExternalService
    {

        ValueTask<TResult> Post<TResult,TRequest>(string url ,TRequest Content);
        ValueTask<HttpResponseMessage> Post<TRequest>(string url ,TRequest Content);
        ValueTask<TResult> Get<TResult>(string url);
        ValueTask<TResult> Put<TResult, TRequest>(string url, TRequest Content);
        ValueTask<HttpResponseMessage> Put<TRequest>(string url, TRequest Content);
        ValueTask<HttpResponseMessage> Delete<TResult>(string url);
    }
}
