﻿using UnityEngine;
using System.Collections;

public class MessageClientReceiver : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MessagingManager.Instance.Subscribe(ThePlayerIsTryingToLeave);
	}
	
    void ThePlayerIsTryingToLeave()
    {
        var dialog = GetComponent<ConversationComponent>();
        if (dialog != null)
        {
            if (dialog.Conversations != null && dialog.Conversations.Length > 0)
            {
                var conversation = dialog.Conversations[0];
                if (conversation != null)
                {
                    ConversationManager.Instance.StartConversation(conversation);
                
                }
            }
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
