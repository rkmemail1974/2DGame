using UnityEngine;
using System.Collections;


public class NavigationPrompt : MonoBehaviour {

    void OnTriggerEnter2D (Collider2D col)
    {
        if (NavigationManager.CanNavigate(this.tag))
        {
         
            Debug.Log("attempting to exit via " + tag);
            NavigationManager.NavigateTo(this.tag);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
