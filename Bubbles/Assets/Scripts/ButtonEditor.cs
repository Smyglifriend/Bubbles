using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LevelButtonGenerator))]
public class ButtonEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        var generator = (LevelButtonGenerator)target;
        if (GUILayout.Button("Create Buttons"))
        {
            generator.GenerateButtons();
        }
    }
}
