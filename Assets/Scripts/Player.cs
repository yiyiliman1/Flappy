using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;

    private AudioSource audioSource;
    public AudioClip pointSound;
    public AudioClip deathSound;

    private void Awake()
    {
<<<<<<< HEAD
=======
        // Obtiene y almacena referencias a los componentes necesarios.
>>>>>>> 0cbaad9 (final)
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
<<<<<<< HEAD
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);    
=======
        // Inicia la animaci�n del sprite llamando al m�todo AnimateSprite repetidamente cada 0.15 segundos.
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
>>>>>>> 0cbaad9 (final)
    }

    private void OnEnable()
    {
<<<<<<< HEAD
        // Asegura que el jugador comienza en una altura inicial de 0 en Y
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
=======
        // Reinicia la posici�n del jugador al centro de la pantalla en el eje Y.
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;

        // Restablece la direcci�n del movimiento.
>>>>>>> 0cbaad9 (final)
        direction = Vector3.zero;
    }

    private void Update()
    {
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
        }

=======
        // Detecta cuando el jugador presiona la barra espaciadora o hace clic con el rat�n.
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // Aplica un impulso hacia arriba.
            direction = Vector3.up * strength;
        }

        // Detecta toques en la pantalla para dispositivos m�viles.
>>>>>>> 0cbaad9 (final)
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
<<<<<<< HEAD
=======
                // Aplica un impulso hacia arriba al tocar la pantalla.
>>>>>>> 0cbaad9 (final)
                direction = Vector3.up * strength;
            }
        }

<<<<<<< HEAD
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

        float maxY = Camera.main.orthographicSize;
        if (transform.position.y > maxY)
        {
=======
        // Aplica gravedad al movimiento.
        direction.y += gravity * Time.deltaTime;

        // Actualiza la posici�n del jugador basada en la direcci�n calculada.
        transform.position += direction * Time.deltaTime;

        // Limita la altura m�xima del jugador al borde superior de la pantalla.
        float maxY = Camera.main.orthographicSize;
        if (transform.position.y > maxY)
        {
            // Si supera el l�mite, lo reposiciona y detiene su movimiento ascendente.
>>>>>>> 0cbaad9 (final)
            transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
            direction.y = 0;
        }
    }

    private void AnimateSprite()
    {
<<<<<<< HEAD
        spriteIndex++;

=======
        // Cambia el sprite actual al siguiente en la secuencia de animaci�n.
        spriteIndex++;

        // Si llega al final de la lista de sprites, vuelve al primero.
>>>>>>> 0cbaad9 (final)
        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
<<<<<<< HEAD
=======

        // Actualiza el sprite del SpriteRenderer con el sprite actual.
>>>>>>> 0cbaad9 (final)
        spriteRenderer.sprite = sprites[spriteIndex];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
<<<<<<< HEAD
        if (other.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().GameOver();
            AudioManager.Instance.PlayDeathSound();
        } else if (other.gameObject.tag == "Scoring")
        {
=======
        // Detecta colisiones con objetos etiquetados como "Obstacle".
        if (other.gameObject.tag == "Obstacle")
        {
            // Llama al GameManager para finalizar la partida y reproduce el sonido de muerte.
            FindObjectOfType<GameManager>().GameOver();
            AudioManager.Instance.PlayDeathSound();
        }
        // Detecta colisiones con objetos etiquetados como "Scoring".
        else if (other.gameObject.tag == "Scoring")
        {
            // Llama al GameManager para aumentar la puntuaci�n y reproduce el sonido de puntuaci�n.
>>>>>>> 0cbaad9 (final)
            FindObjectOfType<GameManager>().IncreaseScore();
            AudioManager.Instance.PlayScoreSound();
        }
    }
<<<<<<< HEAD
=======

>>>>>>> 0cbaad9 (final)
}
