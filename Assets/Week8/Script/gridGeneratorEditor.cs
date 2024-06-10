using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(gridGenerator))]
public class gridGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        gridGenerator gridGenerator = (gridGenerator)target;
        if(GUILayout.Button("Generate Grid"))
        {
            gridGenerator.GenerateGrid();
        }
        if (GUILayout.Button("Clear Grid"))
        {
            gridGenerator.ClearGrid();
        }
        if (GUILayout.Button("Change Material"))
        {
            gridGenerator.AssignMaterial();
        }
    }
    [MenuItem("Tools/Grid/Generate Grid")]
    public static void GenerateGrid()
    {
        gridGenerator gridGenerator = FindObjectOfType<gridGenerator>();
        if(gridGenerator != null)
        {
            gridGenerator.GenerateGrid();
        }
        else
        {
            Debug.LogError("No Grid Generator Found in Scene");
        }
    }
    [MenuItem("Tools/Grid/Clear Grid")]
    public static void ClearGrid()
    {
        gridGenerator gridGenerator = FindObjectOfType<gridGenerator>();
        if (gridGenerator != null)
        {
            gridGenerator.ClearGrid();
        }
        else
        {
            Debug.LogError("No Grid Generator Found in Scene");
        }
    }

    [MenuItem("Tools/Grid/Change Material")]
    public static void ChangeGridMat()
    {
        gridGenerator gridGenerator = FindObjectOfType<gridGenerator>();
        if (gridGenerator != null)
        {
            gridGenerator.AssignMaterial();
        }
        else
        {
            Debug.LogError("No Grid Generator Found in Scene");
        }
    }
}
