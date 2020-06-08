using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering.Universal.ShaderGUI
{
    public static class FluorescenceGUI
    {
        public static class Styles
        {
            public static readonly GUIContent fluorescenceLabel = new GUIContent("Fluorescence");

            public static readonly GUIContent fluorescenceMap = new GUIContent("Fluorescence Map",
                "Sets a Texture map to use for fluorescence. You can also select a color with the color picker. Colors are multiplied over the Texture.");
        }
    }
}