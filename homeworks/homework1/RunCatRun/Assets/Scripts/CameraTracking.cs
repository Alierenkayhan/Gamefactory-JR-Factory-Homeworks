using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    public Transform player;
    Vector3 offset;

    void Update()
    {
        Vector3 targetPos = player.position + offset;
        targetPos.x = 46.32f;
        targetPos.y = 9.71f;
        targetPos.z = targetPos.z - 13.56f;
        transform.position = targetPos;

    }
}
