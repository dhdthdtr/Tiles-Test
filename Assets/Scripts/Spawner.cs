using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject myTiles;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            /*float spawnZ = Random.Range
                   (Camera.main.ScreenToWorldPoint(new Vector3(0, 8, 0)).z, Camera.main.ScreenToWorldPoint(new Vector3(0, 8, Screen.height)).z);
            float spawnX = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector3(0, 8, 0)).x, Camera.main.ScreenToWorldPoint(new Vector3(0, 8, Screen.height)).x);

            Vector3 spawnPos = new Vector3(spawnX, 8, spawnZ);
            Instantiate(myTiles, spawnPos, Quaternion.identity);*/
            Vector3 screenPosition = new Vector3(Random.Range(-1, 1), 5, Random.Range(-2, 3));
            Instantiate(myTiles, screenPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
