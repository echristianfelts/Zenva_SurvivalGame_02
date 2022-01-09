using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int score;
    public TextMeshProUGUI scoreText;

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }


    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
