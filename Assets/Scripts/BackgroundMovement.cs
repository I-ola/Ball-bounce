using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    private Vector3 startPos;
    private float width;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        width = 35f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < startPos.z - width)
        {
            transform.position = startPos;
        }
    }
}
