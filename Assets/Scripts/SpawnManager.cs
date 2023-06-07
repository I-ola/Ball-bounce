using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 3;
    private float repeatRate = 2f;
    public GameObject[] prefab;

    private float spawnRangeX = 0.5f;
    private float spawnRangeZ = 13f;
    private float spawnRange = 5f;
    private float y = -1.965f;

    private PlayerInput playerInputScript;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerInputScript = GameObject.Find("Player").GetComponent < PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {

       




    }

    
     void SpawnObstacle()
    {
        float xPosition = Random.Range(-spawnRangeX, spawnRangeX);
        float zPosition = Random.Range(-spawnRangeZ, spawnRange);
        Vector3 spawnPosition = new Vector3(xPosition, y , zPosition);
       
        int obstacleNo = Random.Range(0, prefab.Length);

        if (playerInputScript.gameOver == false)
        {
           Instantiate(prefab[obstacleNo], spawnPosition, prefab[obstacleNo].transform.rotation);
        }
       
    }
}
