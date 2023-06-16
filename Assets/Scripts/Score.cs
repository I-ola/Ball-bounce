using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
 
    public Text scoreText;
    private PlayerInput playerInputScript;
    public float score = 0f;
    public float increaseScore = 1f;
   
     void Start()
    {
        playerInputScript = GameObject.Find("Player").GetComponent<PlayerInput>();

    }
    // Update is called once per frame
    void Update()
    {
        if(playerInputScript.gameOver == false)
        {
            scoreText.text = score.ToString("0");
            score += increaseScore * Time.deltaTime; 

        }
        if(score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", ((int)score));
            
        }

        PlayerPrefs.SetString("Score", scoreText.text);
       
    }
}
