using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstical : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            //Instantiate(GameManager.Instance.explosionPrefab ,GameManager.Instance.player.transform.position , Quaternion.identity);   
            Instantiate(GameManager.Instance.explosionPrefab ,collision.GetContact(0).point , Quaternion.identity);   
            Destroy(GameManager.Instance.player );
            GameManager.Instance.GameLost();
        }
    }
}
