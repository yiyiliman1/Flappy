using UnityEngine;

public class Spawner : MonoBehaviour
{
    public ObjectPool objectPool;  // Asegúrate de que este pool esté configurado correctamente
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = objectPool.GetObject();

        // Colocamos las tuberías en una posición aleatoria en el eje Y
        pipes.transform.position = transform.position + Vector3.up * Random.Range(minHeight, maxHeight);

        // Accedemos al componente Obstacle y nos suscribimos al evento OnOutOfScreen
        Obstacle obstacleScript = pipes.GetComponent<Obstacle>();
        
    }

    // Método que se llama cuando la tubería sale de la pantalla
    private void ReturnPipeToPool(GameObject pipes)
    {
        // Desuscribir del evento
        Obstacle obstacleScript = pipes.GetComponent<Obstacle>();
        obstacleScript.OnOutOfScreen -= () => ReturnPipeToPool(pipes);

        // Liberar el objeto al pool
        objectPool.ReturnObject(pipes);
    }
}

