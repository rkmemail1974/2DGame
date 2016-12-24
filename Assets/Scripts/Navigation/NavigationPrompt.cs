using UnityEngine;
using System.Collections;


public class NavigationPrompt : MonoBehaviour {

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.CompareTag("Borders"))
        {
            Debug.Log("Leave town");
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
