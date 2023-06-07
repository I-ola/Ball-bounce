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
    private float playerSpeed = 5;
    private float horizontalInput;

    
    private float spinSpeed = 100f;

    private float xRange = 4.4f;
    // Start is called before the first frame update
    void Start()
    {
        /*  playerRb = GetComponent<Rigidbody>();
         Physics.gravity *= gravityModifier; */


    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PositionReset();

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
             transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);
             transform.Rotate(Vector3.right, spinSpeed * Time.deltaTime ); 

         /*   float horizontalInput = Input.GetAxis("Horizontal");

            // Rotate the sphere around its local up-axis (Y-axis)
            transform.Rotate(Vector3.right , spinSpeed * Time.deltaTime);

            // Move the sphere left or right
            float horizontalMovement = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
            transform.Translate(horizontalMovement, 0f, 0f);*/
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
    
    /*  private void PlayerJump()
   {

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    } */

    
}
