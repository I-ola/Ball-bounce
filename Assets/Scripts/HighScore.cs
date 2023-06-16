using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScore;
    //private Score scoreScript;
    // Start is called before the first frame update
    void Start()
    {
       // scoreScript = GameObject.Find("Score").GetComponent<Score>();
        highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
