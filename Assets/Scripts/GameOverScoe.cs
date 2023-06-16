using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverScoe : MonoBehaviour
{
    public Text gameOverScore;
    // Start is called before the first frame update
    void Start()
    {
        gameOverScore.text = PlayerPrefs.GetString("Score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
