using UnityEngine;
using System.Collections;
using UnityEditor;

public class PositionManager : MonoBehaviour {

    [MenuItem("Assets/Create/PositionManager")]
    public static void CreateAsset()
    {
        ScriptingObjects positionManager = ScriptableObject.CreateInstance<ScriptingObjects>();

        AssetDatabase.CreateAsset(positionManager, "Assets/newPositionManager.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();
        Selection.activeObject = positionManager;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
