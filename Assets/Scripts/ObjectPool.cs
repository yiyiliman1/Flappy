using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
<<<<<<< HEAD
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
=======
    public GameObject prefab;               
    public int poolSize = 10;               
    private Queue<GameObject> pool;

    private void Awake()
    {
        // Inicializa la cola que servirá como pool de objetos.
        pool = new Queue<GameObject>();

        // Llena el pool con objetos desactivados.
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab); // Crea una instancia del prefab.
            obj.SetActive(false);                 // Desactiva el objeto.
            pool.Enqueue(obj);                    // Lo añade a la cola del pool.
        }
    }

    // Método para obtener un objeto del pool.
    public GameObject GetObject()
    {
        // Si hay objetos disponibles en el pool.
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue();  // Saca un objeto del pool.
            obj.SetActive(true);              // Activa el objeto antes de retornarlo.
>>>>>>> 0cbaad9 (final)
            return obj;
        }
        else
        {
<<<<<<< HEAD
            // Si el pool está vacío, instanciamos un nuevo objeto 
=======
            // Si el pool está vacío, crea una nueva instancia del prefab.
>>>>>>> 0cbaad9 (final)
            GameObject obj = Instantiate(prefab);
            return obj;
        }
    }

<<<<<<< HEAD
    // Método para devolver un objeto al pool
    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false); // Desactivamos el objeto antes de devolverlo

        // Aquí puedes restablecer las propiedades del objeto antes de devolverlo si es necesario.
        // Por ejemplo, restablecer la posición, eliminar cualquier estado persistente, etc.

        pool.Enqueue(obj);    // Lo agregamos al final de la cola
    }
=======
    // Método para devolver un objeto al pool.
    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);   // Desactiva el objeto antes de devolverlo.
        pool.Enqueue(obj);      // Añade el objeto de nuevo al pool.
    }

>>>>>>> 0cbaad9 (final)
}

