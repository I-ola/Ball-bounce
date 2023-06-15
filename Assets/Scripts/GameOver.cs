using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{ 
    private PlayerInput playerInputScript; 
    public GameObject gameOverMenu;
    // Start is called before the first frame update
    void Start()
    {
        
        playerInputScript = GameObject.Find("Player").GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInputScript.gameOver == true)
        {
            gameOverMenu.SetActive(true);
        }
    }
}
