using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public Brick BrickPrefab;
    public int LineCount = 6;
    public Rigidbody Ball;

    /* Score text and max score*/

    public Text ScoreText;
    public Text MaxScoreText;
    public GameObject GameOverText;


    private bool m_Started = false;
    private int m_Points;
    private bool m_GameOver = false;

    //custom start
    public UI_InputWindow popup;
    string namePlayer;
    int m_MaxPoints;
    Score score;
    public ScoreManager scoreManager;
    //custom end

    // Start is called before the first frame update
    void Start()
    {
        //MaxScoreText.text = $"Name:{namePlayer} Max Score: { m_MaxPoints} ";
        const float step = 0.6f;
        int perLine = Mathf.FloorToInt(4.0f / step);
        
        int[] pointCountArray = new [] {1,1,2,2,5,5};
        for (int i = 0; i < LineCount; ++i)
        {
            for (int x = 0; x < perLine; ++x)
            {
                Vector3 position = new Vector3(-1.5f + step * x, 2.5f + i * 0.3f, 0);
                var brick = Instantiate(BrickPrefab, position, Quaternion.identity);
                brick.PointValue = pointCountArray[i];
                brick.onDestroyed.AddListener(AddPoint);
            }
        }
    }

    private void Update()
    {
        MaxScoreText.text = $"Name:{namePlayer} Max Score: { m_MaxPoints} ";
        if (!m_Started)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_Started = true;
                float randomDirection = Random.Range(-1.0f, 1.0f);
                Vector3 forceDir = new Vector3(randomDirection, 1, 0);
                forceDir.Normalize();

                Ball.transform.SetParent(null);
                Ball.AddForce(forceDir * 2.0f, ForceMode.VelocityChange);
            }
        }
        else if (m_GameOver)
        {
            //call custom method
            MaxScore();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    void AddPoint(int point)
    {
        m_Points += point;
        ScoreText.text = $"Score : {m_Points}";
    }


    public void GameOver()
    {
        m_GameOver = true;
        GameOverText.SetActive(true);
        //MaxScoreText.SetActive(true);
        MaxScoreText.text = $"Name:{namePlayer} Max Score: { m_MaxPoints} ";
    }

    //custom method max score

    public void MaxScore()
    {
        if (m_MaxPoints < m_Points)
        {
            m_MaxPoints = m_Points;
            Debug.Log("Max score: " + m_MaxPoints); //player score
            //show popup okno
            popup.Show();
            namePlayer = popup.PlayerName.text; //player name
            Debug.Log("Player name from main manager: " +namePlayer);
            score = new Score(namePlayer, m_MaxPoints);
            scoreManager.SaveScore();
            

        }
    }


}
