using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;    // oyuncunun Transform bileşeni
    public float lerpValue;    // yumuşak geçiş için lerp değeri

    void LateUpdate()
    {
        if (player.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, player.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPosition, lerpValue);
        }
    }
}
