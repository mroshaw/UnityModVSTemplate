using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace $safeprojectname$
{
    // TODO Review this file and update to your own requirements.

    [BepInPlugin(MyGUID, PluginName, VersionString)]
    public class PluginClass1 : BaseUnityPlugin
    {
        // Mod specific details. MyGUID should be unique, and follow the reverse domain pattern
        // e.g.
        // com.mynameororg.pluginname
        // Version should be a valid version string.
        // e.g.
        // 1.0.0
        private const string MyGUID = "MYGUID";
        private const string PluginName = "PLUGINNAME";
        private const string VersionString = "1.0.0";

        // Config entry key strings
        // These will appear in the config file created by BepInEx and can also be used
        // by the OnSettingsChange event to determine which setting has changed.
        public static string FloatExampleKey = "Float Example Key";
        public static string IntExampleKey = "Int Example Key";
        public static string KeyboardShortcutExampleKey = "Recall Keyboard Shortcut";

        // Configuration entries. Static, so can be accessed directly elsewhere in code via
        // e.g.
        // float myFloat = PLUGINCLASS.FloatExample.Value;
        // TODO Change this code or remove the code if not required.
        public static ConfigEntry<float> FloatExample;
        public static ConfigEntry<int> IntExample;
        public static ConfigEntry<KeyboardShortcut> KeyboardShortcutExample;

        private static readonly Harmony Harmony = new Harmony(MyGUID);
        public static ManualLogSource Log = new ManualLogSource(PluginName);

        /// <summary>
        /// Initialise the configuration settings and patch methods
        /// </summary>
        private void Awake()
        {
            // Float configuration setting example
            // TODO Change this code or remove the code if not required.
            FloatExample = Config.Bind("General",    // The section under which the option is shown
                FloatExampleKey,                            // The key of the configuration option
                1.0f,                            // The default value
                new ConfigDescription("Example float configuration setting.",         // Description that appears in Configuration Manager
                    new AcceptableValueRange<float>(0.0f, 10.0f)));     // Acceptable range, enabled slider and validation in Configuration Manager

            // Int setting example
            // TODO Change this code or remove the code if not required.
            IntExample = Config.Bind("General",
                IntExampleKey,
                1,
                new ConfigDescription("Example int configuration setting.",
                    new AcceptableValueRange<int>(0, 10)));

            // Keyboard shortcut setting example
            // TODO Change this code or remove the code if not required.
            KeyboardShortcutExample = Config.Bind("General",
                KeyboardShortcutExampleKey,
                new KeyboardShortcut(KeyCode.A, KeyCode.LeftControl));

            // Add listeners methods to run if and when settings are changed by the player.
            // TODO Change this code or remove the code if not required.
            FloatExample.SettingChanged += ConfigSettingChanged;
            IntExample.SettingChanged += ConfigSettingChanged;
            KeyboardShortcutExample.SettingChanged += ConfigSettingChanged;

            // Apply all of our patches
            Harmony.PatchAll();
            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loaded.");

            // Sets up our static Log, so it can be used elsewhere in code.
            // .e.g.
            // PLUGINCLASS.Log.LogDebug("Debug Message to BepInEx log file");
            Log = Logger;
        }

        /// <summary>
        /// Method to handle changes to configuration made by the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigSettingChanged(object sender, System.EventArgs e)
        {
            SettingChangedEventArgs settingChangedEventArgs = e as SettingChangedEventArgs;

            // Check if null and return
            if (settingChangedEventArgs == null)
            {
                return;
            }

            // Example Float Shortcut setting changed handler
            if (settingChangedEventArgs.ChangedSetting.Definition.Key == FloatExampleKey)
            {
                // TODO - Add your code here or remove this section if not required.
                // Code here to do something with the new value
            }

            // Example Int Shortcut setting changed handler
            if (settingChangedEventArgs.ChangedSetting.Definition.Key == IntExampleKey)
            {
                // TODO - Add your code here or remove this section if not required.
                // Code here to do something with the new value
            }

            // Example Keyboard Shortcut setting changed handler
            if (settingChangedEventArgs.ChangedSetting.Definition.Key == KeyboardShortcutExampleKey)
            {
                KeyboardShortcut newValue = (KeyboardShortcut)settingChangedEventArgs.ChangedSetting.BoxedValue;

                // TODO - Add your code here or remove this section if not required.
                // Code here to do something with the new value
            }
        }
    }
}
