using UnityEngine;
using System.Collections;
using UnityEditor;

public class ConversationAssetCreator : MonoBehaviour {

	[MenuItem("Assets/Create/Conversation")]
    public static void CreateAsset()
    {
        CustomAssetUtility.CreateAsset<Conversation>();
    }
}
