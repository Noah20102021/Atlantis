using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] int speed = 25;
    [SerializeField] Transform player;

    private void FixedUpdate() {
        Vector3 newPosition = new (player.position.x, player.position.y, -10);
        transform.position = Vector3.Slerp(transform.position, newPosition, speed * Time.deltaTime);
    }
}
