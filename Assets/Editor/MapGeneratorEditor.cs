using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor (typeof (MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerator MapGen = (MapGenerator)target;

        DrawDefaultInspector();

        if (MapGen.autoUpdate)
        {
            MapGen.DrawMapInEditor();
        }

        if (GUILayout.Button("Generate"))
        {
            MapGen.DrawMapInEditor();
        }
    }
}
