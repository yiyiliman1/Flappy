using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject creditsButton;
    public GameObject exitButton;
    public GameObject gameOver;
    public GameObject returnButton;
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;

        Pause();
    }
    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        creditsButton.SetActive(false);
        exitButton.SetActive(false);
        returnButton.SetActive(true);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>(); 

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    public void Pause() 
    { 
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);   
        playButton.SetActive(true);
        creditsButton.SetActive(true);
        exitButton.SetActive(true); 
        returnButton.SetActive(false);

        Pause();    
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void ShowCredits()
    {
        SceneManager.LoadScene("Fin");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Cerrado");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
