using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float leftBound = -21.5f;
    private float speed = 10.0f;
    private PlayerInput playerInputScript;
    // Start is called before the first frame update
    void Start()
    {
        playerInputScript = GameObject.Find("Player").GetComponent<PlayerInput>();
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
    }
}
