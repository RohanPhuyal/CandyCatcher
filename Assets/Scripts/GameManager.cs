using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public GameObject livesHolder;


    int score = 0;
    bool gameOver=false;

    public Text scoreText;

    int lives = 3;

    public GameObject gameOverPanel;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;

            scoreText.text = score.ToString();
        }
    }
    public void DecreaseLive()
    {
        if (lives > 0)
        {
            lives--;

            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }

        if(lives <= 0)
        {
            gameOver = true;
            GameOver();
        }

    }
    public void GameOver()
    {
        //gameover script
        CandySpawner.instance.StopSpawningCandies();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;

        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
