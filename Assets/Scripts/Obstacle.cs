using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Este es el evento que será llamado cuando la tubería salga de la pantalla
    public System.Action OnOutOfScreen;

    private void Update()
    {
<<<<<<< HEAD
        // Verificamos si el objeto ha salido de la pantalla (por ejemplo, en el eje X)
        if (transform.position.x < -10f)  // Cambia -10f según tu configuración
=======
        // Verificamos si el objeto ha salido de la pantalla
        if (transform.position.x < -10f)  
>>>>>>> 0cbaad9 (final)
        {
            // Llamamos al evento
            OnOutOfScreen?.Invoke();
        }
    }
}
