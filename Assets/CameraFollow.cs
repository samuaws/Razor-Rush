using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    private void Update()
    {
        if(GameManager.Instance.player)
        transform.position = GameManager.Instance.player.transform.position + offset;
    }
}
