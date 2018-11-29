// Source 
// https://www.c-sharpcorner.com/UploadFile/1d42da/deadlock-in-threading-in-C-Sharp/
//
using System;
using System.Threading;
namespace deadlockincsharp
{
    public class Akshay
    {
        static readonly object firstLock = new object();
        static readonly object secondLock = new object();
        static bool banderin = false;
        static void ThreadJob()
        {
            Console.WriteLine("\t\t\t\tLocking firstLock");
            lock (firstLock)
            {
                Console.WriteLine("\t\t\t\tLocked firstLock");
                // Wait until we're fairly sure the first thread
                // has grabbed secondLock
                Thread.Sleep(1000);
                Console.WriteLine("\t\t\t\tLocking secondLock");
                lock (secondLock)
                {
                    Console.WriteLine("\t\t\t\tLocked secondLock");
                }
                Console.WriteLine("\t\t\t\tReleased secondLock");
                banderin = true;

            }
            Console.WriteLine("\t\t\t\tReleased firstLock");
        }
        static void Main()
        {
            new Thread(new ThreadStart(ThreadJob)).Start();
            // Wait until we're fairly sure the other thread
            // has grabbed firstLock
            int i = 0;
            while (!banderin)
            {
                Thread.Sleep(1);
                i++;
            }
            Console.WriteLine("Se necesitan " + i +"ms");
            Console.WriteLine("Locking secondLock");
            lock (secondLock)
            {
                Console.WriteLine("Locked secondLock");
                Console.WriteLine("Locking firstLock");
                lock (firstLock)
                {
                    Console.WriteLine("Locked firstLock");
                }
                Console.WriteLine("Released firstLock");
            }
            Console.WriteLine("Released secondLock");
            Console.Read();
        }
    }
}