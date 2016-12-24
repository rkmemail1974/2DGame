using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {
    public float xOffset = 0f;
    public float yOffset = 0f;
    public Transform player;

    void LateUpdate()
    {
        this.transform.position = new Vector3(player.transform.position.x + xOffset, this.transform.position.y + yOffset, -10);

    }
}
