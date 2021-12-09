using UnityEditor;
using UnityEngine;

namespace Logger.Editor
{
#if UNITY_EDITOR
    public class LoggerEditor : EditorWindow
    {
        [MenuItem("Logger/Open Log")]
        private static void OpenLog()
        {

            EditorUtility.RevealInFinder($"{Application.persistentDataPath}/Logs");
        }
    }
}
#endif
