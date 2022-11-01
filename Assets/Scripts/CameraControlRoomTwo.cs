using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlRoomTwo : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    }
}
