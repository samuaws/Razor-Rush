using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitler : MonoBehaviour
{
  
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position , -transform.up , out hit))
        {
            Destroy(hit.transform.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstical"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}
