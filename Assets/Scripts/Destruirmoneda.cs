using UnityEngine;

public class Detruirmoneda : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("jugador"))
        {
            Contadormonedas contarmonedas = FindObjectOfType<Contadormonedas>();
            if (contarmonedas != null)
            {
                contarmonedas.Increasecontarmonedas(); // Aumenta el contador de monedas.
            }

            Destroy(gameObject); // Destruye la moneda.
        }
    }
}
