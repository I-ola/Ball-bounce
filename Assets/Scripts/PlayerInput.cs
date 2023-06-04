using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Rigidbody playerRb;
    
    public bool isOnPlatform = true;
    
    private float jumpForce = 35;
    private float gravityModifier = 10;
    private float playerSpeed = 5;
    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();

        PlayerJump();
        
        if(transform.position.x > 4.25f)
        {
            
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnPlatform = true;
    }

    private void PlayerMove()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);
    }
    private void PlayerJump()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isOnPlatform)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnPlatform = false;
        }
    }
}
