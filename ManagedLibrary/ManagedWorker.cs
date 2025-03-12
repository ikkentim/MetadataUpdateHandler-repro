using ManagedLibrary;
using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

[assembly: MetadataUpdateHandler(typeof(ManagedWorker))]
namespace ManagedLibrary
{
    public class ManagedWorker
    {
        public static void ClearCache(Type[]? updatedTypes)
        {
            Console.WriteLine("ClearCache");
        }

        public static void UpdateApplication(Type[]? updatedTypes)
        {
            Console.WriteLine("UpdateApplication");
        }

        private static int _counter;

        [UnmanagedCallersOnly]
        public static void DoWork()
        {
            Console.WriteLine($"working! {_counter++}");
            // Console.WriteLine("changes made");
        }

        public static void Main()
        {
        }
    }
}
