using UnityEngine;

public class Spawner : MonoBehaviour
{
<<<<<<< HEAD
    public ObjectPool objectPool;  // Aseg�rate de que este pool est� configurado correctamente
=======
    public ObjectPool objectPool;  
>>>>>>> 0cbaad9 (final)
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable()
    {
<<<<<<< HEAD
=======
        // Inicia la repetici�n del m�todo Spawn() a intervalos definidos por 'spawnRate'.
        // Esto genera nuevas tuber�as de manera continua cada 'spawnRate' segundos.
>>>>>>> 0cbaad9 (final)
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
<<<<<<< HEAD
=======
        // Detiene la repetici�n del m�todo Spawn() cuando el objeto se desactiva.
        // Esto evita que las tuber�as sigan gener�ndose cuando el objeto que las genera ya no est� activo.
>>>>>>> 0cbaad9 (final)
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
<<<<<<< HEAD
        GameObject pipes = objectPool.GetObject();

        // Colocamos las tuber�as en una posici�n aleatoria en el eje Y
        pipes.transform.position = transform.position + Vector3.up * Random.Range(minHeight, maxHeight);

        // Accedemos al componente Obstacle y nos suscribimos al evento OnOutOfScreen
        Obstacle obstacleScript = pipes.GetComponent<Obstacle>();
        
    }

    // M�todo que se llama cuando la tuber�a sale de la pantalla
    private void ReturnPipeToPool(GameObject pipes)
    {
        // Desuscribir del evento
        Obstacle obstacleScript = pipes.GetComponent<Obstacle>();
        obstacleScript.OnOutOfScreen -= () => ReturnPipeToPool(pipes);

        // Liberar el objeto al pool
        objectPool.ReturnObject(pipes);
    }
=======
        // Obtiene una tuber�a del Object Pool para reutilizarlo.
        GameObject pipes = objectPool.GetObject();

        // Coloca las tuber�as en una posici�n aleatoria a lo largo del eje Y dentro del rango definido.
        pipes.transform.position = transform.position + Vector3.up * Random.Range(minHeight, maxHeight);

        // Accede al componente 'Obstacle' de la tuber�a para gestionar su comportamiento.
        Obstacle obstacleScript = pipes.GetComponent<Obstacle>();

    }

    // M�todo que se llama cuando la tuber�a sale de la pantalla.
    private void ReturnPipeToPool(GameObject pipes)
    {
        // Desuscribe el objeto del evento OnOutOfScreen para que no vuelva a intentar devolverlo al pool.
        Obstacle obstacleScript = pipes.GetComponent<Obstacle>();
        obstacleScript.OnOutOfScreen -= () => ReturnPipeToPool(pipes);

        // Devuelve el objeto al pool de objetos, permitiendo reutilizarlo en lugar de crear uno nuevo.
        objectPool.ReturnObject(pipes);
    }

>>>>>>> 0cbaad9 (final)
}

