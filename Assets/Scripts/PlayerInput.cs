using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerInput : MonoBehaviour
{
    private Rigidbody playerRb;

    public bool gameOver = false;
    private float playerSpeed = 30f;
    private float horizontalInput;
    //private float spinSpeed = 150f;
    private float xRange = 4.4f;
    // Start is called before the first frame update
    void Start()
    {
         playerRb = GetComponent<Rigidbody>();
       

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PositionReset();

       
    }

    private void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
        }
    }

    private void PlayerMove()
    {
        if (gameOver == false)
        {
             horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(horizontalInput* playerSpeed * Time.deltaTime,0,0);
           //  playerRb.AddForce(Vector3.right* playerSpeed * horizontalInput );
            // transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime ); 

        }

    }


    private void PositionReset()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }
    }
   
    
}
