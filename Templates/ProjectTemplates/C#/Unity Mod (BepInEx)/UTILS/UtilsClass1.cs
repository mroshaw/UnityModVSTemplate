using UnityEngine;

namespace $safeprojectname$.Utils
{
    /// <summary>
    /// Static utilities class for common functions and properties to be used within your mod code
    /// </summary>
    internal static class ModUtils
    {
        /// <summary>
        /// Example static method to return Players current location / transform
        /// </summary>
        /// <returns></returns>
        public static Transform GetPlayerTransform()
        {
            return Player.main.transform;
        }
    }
}
