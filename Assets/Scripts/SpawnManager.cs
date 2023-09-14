using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //private float startDelay = 1f;
    private float repeatRate = 3;
    public GameObject[] prefab;

    private float spawnRangeX = 3.2f;
    private float spawnRangeZ = 13f;
    private float spawnRange = 7f;
    private float y = -1.965f;

    private PlayerInput playerInputScript;
    private Score scoreScript;
    private float limit = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

        playerInputScript = GameObject.Find("Player").GetComponent < PlayerInput>();
        scoreScript = GameObject.Find("Score").GetComponent< Score>();
        StartCoroutine(ObstaclesSpawned());
    }

    // Update is called once per frame
    void Update()
    {
        
        if (scoreScript.score > limit && repeatRate > 1f)
        {
            repeatRate --;
        }
    }

    
     void SpawnObstacle()
    {
        float xPosition = Random.Range(-spawnRangeX, spawnRangeX);
        float zPosition = Random.Range(-spawnRangeZ, -spawnRange);
        Vector3 spawnPosition = new Vector3(xPosition, y , zPosition);
       
        int obstacleNo = Random.Range(0, prefab.Length);

        if (playerInputScript.gameOver == false)
        {
           Instantiate(prefab[obstacleNo], spawnPosition, prefab[obstacleNo].transform.rotation);
        }
    }

    IEnumerator ObstaclesSpawned()
    {
        while(playerInputScript.gameOver == false)
        {
            yield return new WaitForSeconds(repeatRate);
            SpawnObstacle();
        }
       
    }
}
