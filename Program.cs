using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace AnimationExample
{
    class Program
    {
        private const string msg = "Welcome to be, I'll be uploading exercises and projects... Follow me and don't forget to support me with one star for more. ";
        public static async Task Main(string[] args)
        {
            for (int i = 0; i < msg.Length; i++)
            {
                // a kind of an animation
                Console.WriteLine(msg.Substring(0, i + 1));
                await Task.Delay(100);
            }

            Console.WriteLine("Done!");
            await Task.Delay(0);
        }  
    }
}
