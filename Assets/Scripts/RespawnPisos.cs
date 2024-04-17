using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPisos : MonoBehaviour
{
    public GameObject[] prefabsToSpawn; // Array de prefabs disponibles para spawnear
    public Vector3 spawnPosition; // Posici�n fija donde spawnear los prefabs

    public float respawnInterval = 5f; // Intervalo de tiempo en segundos para respawnear

    private void Start()
    {
        // Comenzar el proceso de respawnear objetos
        StartCoroutine(RespawnCoroutine());
    }

    private IEnumerator RespawnCoroutine()
    {
        while (true) // Bucle infinito para respawnear continuamente
        {
            yield return new WaitForSeconds(respawnInterval);

            // Obtener un �ndice aleatorio para elegir un prefab de la lista
            int randomIndex = Random.Range(0, prefabsToSpawn.Length);

            // Instanciar el prefab en la posici�n fija especificada
            Instantiate(prefabsToSpawn[randomIndex], spawnPosition, Quaternion.identity);
        }
    }
}