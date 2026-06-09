using UnityEngine;
using UnityModManagerNet;

namespace FallenADOFAIModTemplate
{
    public class Settings : UnityModManager.ModSettings
    {
        public void OnGUI(UnityModManager.ModEntry modEntry)
        {
            GUILayout.Label("No settings");
        }

        public void OnSaveGUI(UnityModManager.ModEntry modEntry)
        {
            Save(modEntry);
        }

        public override void Save(UnityModManager.ModEntry modEntry)
        {
            Save(this, modEntry);
        }

        public static Settings Load(UnityModManager.ModEntry modEntry)
        {
            return Load<Settings>(modEntry);
        }
    }
}
