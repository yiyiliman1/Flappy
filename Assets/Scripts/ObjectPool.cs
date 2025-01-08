using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;               // El prefab del objeto (tubería) que se va a reutilizar.
    public int poolSize = 10;               // El tamaño del pool (cantidad de objetos que vamos a almacenar).
    private Queue<GameObject> pool;         // La cola donde vamos a almacenar las tuberías disponibles.

    private void Awake()
    {
        pool = new Queue<GameObject>();

        // Rellenamos el pool con objetos inactivos
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);  // Desactivamos el objeto cuando lo agregamos al pool
            pool.Enqueue(obj);
        }
    }

    // Método para obtener un objeto del pool
    public GameObject GetObject()
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue(); // Sacamos el objeto de la cola
            obj.SetActive(true);              // Activamos el objeto
            return obj;
        }
        else
        {
            // Si el pool está vacío, instanciamos un nuevo objeto 
            GameObject obj = Instantiate(prefab);
            return obj;
        }
    }

    // Método para devolver un objeto al pool
    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false); // Desactivamos el objeto antes de devolverlo

        // Aquí puedes restablecer las propiedades del objeto antes de devolverlo si es necesario.
        // Por ejemplo, restablecer la posición, eliminar cualquier estado persistente, etc.

        pool.Enqueue(obj);    // Lo agregamos al final de la cola
    }
}

