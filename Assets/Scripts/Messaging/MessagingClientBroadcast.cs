using UnityEngine;
using System.Collections;

public class MessagingClientBroadcast : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        MessagingManager.Instance.Broadcast();
    }
    
}
