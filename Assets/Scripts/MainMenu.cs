using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
<<<<<<< HEAD
    // Start is called before the first frame update
    public void Play()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        SceneManager.LoadScene("SampleScene");

=======
    public void Play()
    {
        // Carga la siguiente escena en el �ndice de construcci�n de Unity.
        // �til para comenzar el juego desde el men� principal.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
>>>>>>> 0cbaad9 (final)
    }

    public void Credits()
    {
<<<<<<< HEAD
        SceneManager.LoadScene("Credits");
    }
    // Update is called once per frame
    public void Exit()
    {
        Debug.Log("salir");
        Application.Quit();
    }
=======
        // Carga la escena llamada "Credits".
        // Se utiliza para mostrar los cr�ditos del juego.
        SceneManager.LoadScene("Credits");
    }

    public void Exit()
    {
        // Imprime el mensaje "salir" en la consola (solo visible en el editor de Unity).
        Debug.Log("salir");

        // Cierra la aplicaci�n cuando se ejecuta en una build (no funciona en el editor de Unity).
        Application.Quit();
    }

>>>>>>> 0cbaad9 (final)
}
