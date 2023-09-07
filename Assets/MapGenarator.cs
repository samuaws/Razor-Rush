using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenarator : MonoBehaviour
{
    public TerrainChunk currentChunk;
    public GameObject corridorTerrainPrefab;
    public GameObject openTerrainPrefab;
    private void Update()
    {
        RaycastHit hit;
        GameObject terr;
        if (!Physics.Raycast(transform.position, -transform.up, out hit))
        {
            int open = Random.Range(0, 4);
            if(open == 1)
            {
              terr =   Instantiate(openTerrainPrefab , currentChunk.openTerrainPos.position , Quaternion.identity);

            }
            else
            {
               terr =  Instantiate(corridorTerrainPrefab , currentChunk.corridorTerrainPos.position , Quaternion.identity);
                
            }
            currentChunk = terr.GetComponent<TerrainChunk>();
        }
    }
}
