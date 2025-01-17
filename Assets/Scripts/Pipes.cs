using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    private float leftEdge;

    private void Start()
    {
<<<<<<< HEAD
=======
        // Calcula el borde izquierdo de la pantalla en coordenadas del mundo y lo guarda en 'leftEdge'.
        // Esto se utiliza para detectar cuándo el objeto sale de la pantalla.
>>>>>>> 0cbaad9 (final)
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
<<<<<<< HEAD
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftEdge)
        {
=======
        // Mueve el objeto hacia la izquierda a una velocidad constante.
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Comprueba si el objeto ha salido completamente de la pantalla.
        if (transform.position.x < leftEdge)
        {
            // Destruye el objeto para liberar memoria y mantener la escena limpia.
>>>>>>> 0cbaad9 (final)
            Destroy(gameObject);
        }
    }

<<<<<<< HEAD
=======

>>>>>>> 0cbaad9 (final)
}
