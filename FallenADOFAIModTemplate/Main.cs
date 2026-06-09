using HarmonyLib;
using System.Reflection;
using UnityModManagerNet;

namespace FallenADOFAIModTemplate
{
    public static class Main
    {
        public static string ModName = "ADOFAIModTemplate";
        public static UnityModManager.ModEntry Mod { get; private set; }
        public static UnityModManager.ModEntry.ModLogger Logger { get; private set; }
        public static Harmony Harmony { get; private set; }
        public static Settings Settings { get; private set; } = null!;

        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            Mod = modEntry;
            Logger = modEntry.Logger;

            Settings = Settings.Load(modEntry);

            modEntry.OnToggle = OnToggle;
            modEntry.OnGUI = Settings.OnGUI;
            modEntry.OnSaveGUI = Settings.OnSaveGUI;

            Harmony = new Harmony(modEntry.Info.Id);

            Logger.Log("Mod loaded!");
            return true;
        }

        private static bool OnToggle(UnityModManager.ModEntry modEntry, bool value) 
        {
            if (value)
            {
                Logger.Log("Mod enabled");
                Harmony.PatchAll(Assembly.GetExecutingAssembly());
            }
            else
            {
                Logger.Log("Mod disabled");
                Harmony.UnpatchAll();
            }
            return true;
        }
    }
}
