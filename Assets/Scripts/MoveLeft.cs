using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float leftBound = -19.3f;
    private float speed = 5.0f;
    private PlayerInput playerInputScript;
    private Score scoreScript;
    private float scoreLimit = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerInputScript = GameObject.Find("Player").GetComponent<PlayerInput>();
        scoreScript = GameObject.Find("Score").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInputScript.gameOver == false) {
        
            transform.Translate(Vector3.back * Time.deltaTime * speed);
       
        }
        
        if( transform.position.z < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            
        }

        if(scoreScript.score > scoreLimit && speed <= 8.0f)
        {
            speed++;
        }
    }
}
