using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeed = 1f;

    private void Awake()
    {
<<<<<<< HEAD
=======
        // Obtiene y almacena la referencia al componente MeshRenderer del objeto.
>>>>>>> 0cbaad9 (final)
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
<<<<<<< HEAD
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
=======
        // Desplaza la textura del material a lo largo del eje X para crear un efecto de desplazamiento.
        // La velocidad del desplazamiento está controlada por la variable 'animationSpeed'.
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }

>>>>>>> 0cbaad9 (final)
}
