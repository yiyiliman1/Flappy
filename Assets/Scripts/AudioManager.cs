using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioClip scoreSound;
    public AudioClip deathSound;

    private AudioSource audioSource;

    private void Awake()
    {
<<<<<<< HEAD
        // Singleton para evitar duplicados del AudioManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }
    public void PlayScoreSound()
    {
=======
        // Configura un patrón Singleton para asegurarse de que solo haya una instancia de AudioManager en la escena.
        if (Instance == null)
        {
            Instance = this; // Asigna la instancia actual como la única.
            DontDestroyOnLoad(gameObject); // Evita que se destruya al cambiar de escena.
        }
        else
        {
            Destroy(gameObject); // Destruye cualquier instancia duplicada.
        }

        // Obtiene la referencia al componente AudioSource del objeto.
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayScoreSound()
    {
        // Reproduce un efecto de sonido al aumentar la puntuación.
>>>>>>> 0cbaad9 (final)
        audioSource.PlayOneShot(scoreSound);
    }

    public void PlayDeathSound()
    {
<<<<<<< HEAD
        audioSource.PlayOneShot(deathSound);
    }
=======
        // Reproduce un efecto de sonido al morir el jugador.
        audioSource.PlayOneShot(deathSound);
    }

>>>>>>> 0cbaad9 (final)
}
