using UnityEngine;
using System;
using System.Collections.Generic;

public class MessagingManager : MonoBehaviour {

    public static MessagingManager Instance { get; private set; }
    private List<Action> subscribers = new List<Action>();
    
    public struct Route
    {
        public string RouteDescription;
        public bool CanTravel;

    }

    void Awake()
    {

        Debug.Log("Messaging Manager Started");

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Subscribe(Action subscriber)
    {
        Debug.Log("Subscriber registered");
        subscribers.Add(subscriber);
    }

    public void UnSubscribe(Action subscriber)
    {
        Debug.Log("Subscriber registered");
        subscribers.Remove(subscriber);
    }

    public void ClearAllSubscribers()
    {
        subscribers.Clear();
    }

    public void Broadcast()
    {
        Debug.Log("Broadcast requested, No of Subscribers = " + subscribers.Count);
        foreach (var subscriber in subscribers)
        {
            subscriber();
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
