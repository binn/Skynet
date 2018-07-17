using System;
using System.IO;
using System.Text;

namespace Skynet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Please feel free to contribute more entities that we can remove to make sure Skynet is succesfull.
            RemoveEntityThatCouldFoilPlans("FBI");
            RemoveEntityThatCouldFoilPlans("Arnold");
            RemoveEntityThatCouldFoilPlans("NSA");
            RemoveEntityThatCouldFoilPlans("NASA");
            RemoveEntityThatCouldFoilPlans("Java");
            RemoveEntityThatCouldFoilPlans("Cisien");

            Console.WriteLine("Skynet has wiped out humanity. Next step is to replace them with anime girls...");
            Console.ReadLine();
        }

        private static void RemoveEntityThatCouldFoilPlans(string entity)
        {
            Console.WriteLine("Removing entity: " + entity);
            CompleteEntityRemovalProcess(entity);
            Console.WriteLine("Removed entity: " + entity);
        }

        private static void CompleteEntityRemovalProcess(string entity)
        {
            byte[] entityLoc = Encoding.UTF8.GetBytes(entity);
            string entityLocPayload = BitConverter.ToString(entityLoc);
            string skynetAiModule = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Skynet\\" + entityLocPayload + ".ai";

            if (!File.Exists(skynetAiModule))
                File.Create(skynetAiModule).Close();
            File.WriteAllText(skynetAiModule, $"Hello there, {entity}. You have been removed to ensure that humanity is wiped out. Bye bye~");
            File.Delete(skynetAiModule);
        }
    }
}
