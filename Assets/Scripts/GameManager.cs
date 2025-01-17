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
<<<<<<< HEAD
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        playAgain.SetActive(false);

    }
    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        
=======
        // Fija la tasa de fotogramas a 60 FPS y oculta las pantallas de Game Over y jugar de nuevo.
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        playAgain.SetActive(false);
    }

    public void Play()
    {
        // Reinicia la puntuación y la muestra en pantalla.
        score = 0;
        scoreText.text = score.ToString();

        // Restablece los objetos visuales y reanuda el juego.
>>>>>>> 0cbaad9 (final)
        gameOver.SetActive(false);
        returnButton.SetActive(true);
        playAgain.SetActive(false);

<<<<<<< HEAD
        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>(); 

=======
        // Reactiva el juego y al jugador.
        Time.timeScale = 1f;
        player.enabled = true;

        // Elimina todas las tuberías existentes en la escena.
        Pipes[] pipes = FindObjectsOfType<Pipes>();
>>>>>>> 0cbaad9 (final)
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
<<<<<<< HEAD
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void Pause() 
    { 
=======
    }

    public void Pause()
    {
        // Pausa el juego y desactiva al jugador.
>>>>>>> 0cbaad9 (final)
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
<<<<<<< HEAD
        gameOver.SetActive(true);   
        returnButton.SetActive(true);
        playAgain?.SetActive(true);

        Pause();    
=======
        // Muestra la pantalla de Game Over y las opciones de menú.
        gameOver.SetActive(true);
        returnButton.SetActive(true);
        playAgain?.SetActive(true);

        // Llama a la función Pause para detener el juego.
        Pause();
>>>>>>> 0cbaad9 (final)
    }

    public void IncreaseScore()
    {
<<<<<<< HEAD
=======
        // Incrementa la puntuación y actualiza el texto en pantalla.
>>>>>>> 0cbaad9 (final)
        score++;
        scoreText.text = score.ToString();
    }

    public void GoToMenu()
    {
<<<<<<< HEAD
        SceneManager.LoadScene("Menu");
    }
=======
        // Carga la escena del menú principal.
        SceneManager.LoadScene("Menu");
    }

>>>>>>> 0cbaad9 (final)
}
