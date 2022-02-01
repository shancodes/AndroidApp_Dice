using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mine
{
    public static class TaskExtensions
    {
        //NOTE : Async void is intentional here. This is to provide a way to call all async method from constructor
        //while communicating intent to fire and forget, and allow handling of exception
        public static async void SafeFireAndForget(this Task task, bool returnToCallingContext, Action<Exception> onException = null)
        {
            try
            {
                await task.ConfigureAwait(returnToCallingContext);
            }
            //if the provided action is not null, catch and pass the thrown exception
            catch (Exception ex) when (onException != null)
            {
                onException(ex);
            }
        }
    

    }
}
