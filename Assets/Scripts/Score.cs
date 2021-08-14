using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public Transform player;
    public Text scoreText;
    public int score;

    // Update is called once per frame
    void Update()
    {
        AddScore(score);
    }

    public void AddScore(int point)
    {
        score += point;
        scoreText.text = "Score: " + score.ToString();
    }
}
