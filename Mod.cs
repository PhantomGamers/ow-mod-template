using OWML.ModHelper;

using System.Reflection;

namespace ModTemplate
{
    public class Mod : ModBehaviour
    {
        public void Start()
        {
            // Mod startup logic
            ModHelper.Console.WriteLine($"{Assembly.GetExecutingAssembly().GetName().Name} loaded");
        }
    }
}
