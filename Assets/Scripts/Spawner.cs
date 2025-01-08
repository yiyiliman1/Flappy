using UnityEngine;

public class Spawner : MonoBehaviour
{
    public ObjectPool objectPool;  // Aseg�rate de que este pool est� configurado correctamente
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
}

