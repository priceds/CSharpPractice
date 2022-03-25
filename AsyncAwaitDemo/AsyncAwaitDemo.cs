using System;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    public class Demo
    {
        public async Task DoStuff()
        {
           
                LongRunningOperation();
           
        }

        private static async Task<string> LongRunningOperation()
        {
            int counter;

            for (counter = 0; counter < 50000; counter++)
            {
                Console.WriteLine(counter);
            }

            return "Counter = " + counter;
        }
    }
    public class AsyncAwaitDemo
    {
        static void Main(string[] args)
        {
            var demo = new Demo();
            demo.DoStuff();

            while (true)
            {
                Console.WriteLine("Doing Stuff on the Main Thread...................");
            }
        }
       


    }
}
