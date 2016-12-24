﻿using UnityEngine;
using System.Collections;

public class Sorting : MonoBehaviour {
    public Transform player;

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y >= player.transform.position.y)
        {
            //Debug.Log("behind player");
            GetComponent<SpriteRenderer>().sortingOrder = (player.GetComponent<SpriteRenderer>().sortingOrder) - 1;
            GetComponents<BoxCollider2D>()[1].enabled = false;
            GetComponents <BoxCollider2D>()[2].enabled = true;
        }
        if (transform.position.y < player.transform.position.y)
        {
           // Debug.Log("in front of player");
            GetComponent<SpriteRenderer>().sortingOrder = (player.GetComponent<SpriteRenderer>().sortingOrder) + 1;
            GetComponents<BoxCollider2D>()[1].enabled = true;
            GetComponents<BoxCollider2D>()[2].enabled = false;
        }
    }
}
