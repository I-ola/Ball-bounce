using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerInput : MonoBehaviour
{
    private Rigidbody playerRb;

    //public bool isOnGround;
    public bool gameOver = false;

    //private float jumpForce = 35;
    //private float gravityModifier = 10;
    private float playerSpeed = 70f;
    private float horizontalInput;

   // private Score scoreScript;
    private float spinSpeed = 100f;

   // private float scoreLimit = 5f;
    private float xRange = 4.4f;
    // Start is called before the first frame update
    void Start()
    {
         playerRb = GetComponent<Rigidbody>();
        // Physics.gravity *= gravityModifier; 
       // scoreScript= GameObject.Find("Score").GetComponent<Score>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PositionReset();

        /*if(scoreScript.score > scoreLimit)
        {
            playerSpeed++;
        }*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        /* if (collision.gameObject.CompareTag("Ground"))
         {
              isOnGround = true;
          } */
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
             playerRb.AddForce(Vector3.right* playerSpeed * horizontalInput );
             transform.Rotate(Vector3.right, spinSpeed * Time.deltaTime ); 

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
