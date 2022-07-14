using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameScore(int ringScore)
    {
        score += ringScore;
        scoreText.text = score + "";
    }
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
