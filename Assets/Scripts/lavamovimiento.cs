using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavamovimiento : MonoBehaviour
{
    public float moveSpeed = 2f; // Velocidad de movimiento
    public float finalvida = 50f; // Posici�n Z donde se regenera el objeto

    private Vector3 originalPosition; // Posici�n inicial del objeto

    private void Start()
    {
        // Guardar la posici�n inicial del objeto con la coordenada X fija en 747f
        originalPosition = new Vector3(transform.position.x, transform.position.y, 747f);
    }

    private void Update()
    {
        // Mover el objeto hacia atr�s en el eje Z
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        // Verificar si el objeto ha llegado a la posici�n Z donde debe regenerarse
        if (transform.position.z <= finalvida)
        {
            // Reposicionar el objeto a la posici�n original pero en una nueva posici�n Z
            transform.position = new Vector3(originalPosition.x, originalPosition.y, 747f);
        }
    }
}
