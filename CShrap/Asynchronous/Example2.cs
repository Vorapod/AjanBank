using System;
using System.Threading.Tasks;

namespace Asynchronous
{
    static class Example2
    {
        static async Task Main(string[] args)
        {
            Task<int> longRunningTask = LongRunningOperationAsync();
            // independent work which doesn't need the result of LongRunningOperationAsync can be done here

            //and now we call await on the task 
            int result = await longRunningTask;
            //use the result 
            Console.WriteLine(result);
        }

        public static async Task<int> LongRunningOperationAsync()
        {
            await Task.Delay(5000);
            return 1;
        }
    }
}
