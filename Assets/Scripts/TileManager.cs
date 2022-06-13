using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] TilePrefabs;
    public float timeRemaining = 4.5f;
    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            timeRemaining = 4.5f;
            SpawnTile();
        }
           
    }
    public void SpawnTile()
    {
        GameObject go;
        go = Instantiate(TilePrefabs[Random.Range(0,2)]) as GameObject;
        go.transform.position = transform.position;
    }

    
}