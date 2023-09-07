using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainChunk : MonoBehaviour
{

    public Transform corridorTerrainPos;
    public Transform openTerrainPos;
    public List<Transform> obsticalPositions = new List<Transform>();
    public List<Transform> enemyPositions = new List<Transform>();
    public GameObject enemyPrefabs;
    public List<GameObject> obsticalPrefabs = new List<GameObject>();

    private void Start()
    {
        foreach(Transform obsPos in obsticalPositions)
        {
            int obsIndex = Random.Range(0, obsticalPrefabs.Count);
            Instantiate(obsticalPrefabs[obsIndex] , obsPos.position , Quaternion.identity);
        }
        foreach (Transform enyPos in enemyPositions)
        {
            Instantiate(enemyPrefabs, enyPos.position, Quaternion.identity);
        }
    }

}
