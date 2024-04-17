using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavamovimiento : MonoBehaviour
{
    public float moveSpeed = 2f; // Velocidad de movimiento
    public float finalvida = 50f; // Posición Z donde se regenera el objeto

    private Vector3 originalPosition; // Posición inicial del objeto

    private void Start()
    {
        // Guardar la posición inicial del objeto con la coordenada X fija en 747f
        originalPosition = new Vector3(transform.position.x, transform.position.y, 747f);
    }

    private void Update()
    {
        // Mover el objeto hacia atrás en el eje Z
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        // Verificar si el objeto ha llegado a la posición Z donde debe regenerarse
        if (transform.position.z <= finalvida)
        {
            // Reposicionar el objeto a la posición original pero en una nueva posición Z
            transform.position = new Vector3(originalPosition.x, originalPosition.y, 747f);
        }
    }
}
