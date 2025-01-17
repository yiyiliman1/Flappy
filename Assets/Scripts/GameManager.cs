using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject gameOver;
    public GameObject returnButton;
    public GameObject playAgain;
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        playAgain.SetActive(false);

    }
    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        
        gameOver.SetActive(false);
<<<<<<< HEAD
        returnButton.SetActive(true);
=======
        returnButton.SetActive(false);
>>>>>>> 08fe5c2 (Funciona)
        playAgain.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>(); 

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
<<<<<<< HEAD
=======

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
>>>>>>> 08fe5c2 (Funciona)
    }
    public void Pause() 
    { 
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);   
        returnButton.SetActive(true);
        playAgain?.SetActive(true);

        Pause();    
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
