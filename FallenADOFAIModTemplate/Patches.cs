using HarmonyLib;

namespace FallenADOFAIModTemplate
{
    [HarmonyPatch(typeof(scnEditor), "Awake")]
    public static class Patches
    {
        public static scnEditor Instance;
        public static void Prefix(scnEditor __instance)
        {
            Instance = __instance;
        }
    }
}
