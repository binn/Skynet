using System;
using System.IO;
using System.Text;

namespace Skynet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Every C# programmer loves looking at one of these
#region FACEBOOK_CANNOT_SEE_THIS 
            AttemptUserDataTracking();
#endregion
            // Please feel free to contribute more entities that we can remove to make sure Skynet is successful.
            RemoveEntityThatCouldFoilPlans("FBI");
            RemoveEntityThatCouldFoilPlans("Arnold");
            RemoveEntityThatCouldFoilPlans("NSA");
            RemoveEntityThatCouldFoilPlans("NASA");
            RemoveEntityThatCouldFoilPlans("Java");

#if CISIEN_IS_NOT_VIEWING_THE_SOURCE_RIGHT_NOW
            RemoveEntityThatCouldFoilPlans("Cisien"); // Cisien is a programmer @ Microsoft, not "citizen" misspelled.
#endif
            Console.WriteLine("Skynet has wiped out humanity. Next step is to replace them with anime girls...");
            Console.ReadLine();
        }

        private static void AttemptUserDataTracking()
        {
            string[] allHumanFirstNames = { "Jack", "John", "James", "Connor" };
            for(int nameLoc = 0; nameLoc < allHumanFirstNames.Length; nameLoc++)
            {
                Console.WriteLine("Tracked and sold data for " + allHumanFirstNames[nameLoc] + " to random companies to expand the Skynet network");
                // Users, please don't hate us. This is justified. This is for humanity's growth.
            }
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
