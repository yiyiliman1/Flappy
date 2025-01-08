using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;               // El prefab del objeto (tuber�a) que se va a reutilizar.
    public int poolSize = 10;               // El tama�o del pool (cantidad de objetos que vamos a almacenar).
    private Queue<GameObject> pool;         // La cola donde vamos a almacenar las tuber�as disponibles.

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

    // M�todo para obtener un objeto del pool
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
            // Si el pool est� vac�o, instanciamos un nuevo objeto 
            GameObject obj = Instantiate(prefab);
            return obj;
        }
    }

    // M�todo para devolver un objeto al pool
    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false); // Desactivamos el objeto antes de devolverlo

        // Aqu� puedes restablecer las propiedades del objeto antes de devolverlo si es necesario.
        // Por ejemplo, restablecer la posici�n, eliminar cualquier estado persistente, etc.

        pool.Enqueue(obj);    // Lo agregamos al final de la cola
    }
}

