using System;
using System.IO;
using System.Threading.Tasks;

namespace Asynchronous
{
    class ExampleBasic
    {
        /// <summary>
        /// First program. We use the async and await keywords to asynchronously run a method. The program begins a long-running method (HandleFileAsync).
        /// First:
        /// We create a Task instance by calling the HandleFileAsync method.The task starts, and we call Wait() for it to finish.
        /// Messages:
        /// The method displays a status message after it starts.When it ends, the results are displayed.
        /// HandleFileAsync:
        /// In HandleFileAsync, we use the StreamReader type and await the ReadToEndAsync method. We perform some computations.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Start the HandleFile method.
            Task<int> task = HandleFileAsync();

            // Control returns here before HandleFileAsync returns.
            // ... Prompt the user.
            Console.WriteLine("Please wait patiently while I do something important.");

            // Do something at the same time as the file is being read.
            string line = Console.ReadLine();
            Console.WriteLine("You entered (asynchronous logic): " + line);

            // Wait for the HandleFile task to complete.
            // ... Display its results.
            task.Wait();
            int x = task.Result;
            Console.WriteLine("Count: " + x);

            Console.WriteLine("[DONE]");
            Console.ReadLine();
        }

        static async Task<int> HandleFileAsync()
        {
            string file = @"D:\AjanBank\CShrap\Asynchronous\message.txt";
            Console.WriteLine("HandleFile enter");
            int count = 0;

            using (StreamReader reader = new StreamReader(file))
            {
                string msg = await reader.ReadToEndAsync();
                count += msg.Length;

                for (int i = 0; i < 100001; i++)
                {
                    if (i == 100000)
                    {
                        count--;
                        //throw new Exception("ErrorFromToon");
                    }
                }
                Console.WriteLine("HandleFile exit");
                return count;
            }
        }
    }
}
