using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    private Vector3 startPos;
    private float width;
    private PlayerInput playerInputScript;
    private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        playerInputScript = GameObject.Find("Player").GetComponent<PlayerInput>();
        startPos = transform.position;
        width = 35f;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInputScript.gameOver == false)
        {

            transform.Translate(Vector3.back * Time.deltaTime * speed);

        }
        if (transform.position.z < startPos.z - width)
        {
            transform.position = startPos;
        }
    }
}
